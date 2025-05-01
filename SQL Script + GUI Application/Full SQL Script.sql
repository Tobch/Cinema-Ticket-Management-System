-- Create Database
CREATE DATABASE Cinema;
GO

USE Cinema;
GO

-- Tables
CREATE TABLE Movie (
    MovieId INT PRIMARY KEY ,
    Name NVARCHAR(100) NOT NULL,
    Genre NVARCHAR(50),
    Language NVARCHAR(50),
    Rating NVARCHAR(10)
);

CREATE TABLE Show (
    Show_No INT PRIMARY KEY ,
    StartTime DATETIME NOT NULL,
    EndTime DATETIME NOT NULL
);

CREATE TABLE Play (
    MovieId INT FOREIGN KEY REFERENCES Movie(MovieId),
    Show_No INT FOREIGN KEY REFERENCES Show(Show_No),
    PRIMARY KEY (MovieId, Show_No)
);

CREATE TABLE Halls (
    Hall_Id INT PRIMARY KEY ,
    Name NVARCHAR(50),
    SeatCapacity INT NOT NULL CHECK (SeatCapacity > 0),
    SeatType NVARCHAR(20) NOT NULL
);

CREATE TABLE Customer (
    CustId INT PRIMARY KEY ,
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE
);

CREATE TABLE Customer_Phone (
    Cust_Id INT FOREIGN KEY REFERENCES Customer(CustId),
    Phone_no NVARCHAR(20) NOT NULL,
    PRIMARY KEY (Cust_Id, Phone_no)
);

CREATE TABLE Employee (
    Emp_Id INT PRIMARY KEY ,
    EmpName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    City NVARCHAR(50),
    St_Name NVARCHAR(100),
    Building_no NVARCHAR(20)
);
CREATE TABLE Employee_Phone (
    Emp_Id INT FOREIGN KEY REFERENCES Employee(Emp_Id),
    Phone_no NVARCHAR(20) NOT NULL,
    PRIMARY KEY (Emp_Id, Phone_no)
);

CREATE TABLE Tickets (
    Ticket_no INT PRIMARY KEY ,
    Price DECIMAL(10,2) NOT NULL CHECK (Price > 0),
    Customer_Id INT FOREIGN KEY REFERENCES Customer(CustId),
    Emp_Id INT FOREIGN KEY REFERENCES Employee(Emp_Id),
    Show_No INT FOREIGN KEY REFERENCES Show(Show_No),
    Hall_Id INT FOREIGN KEY REFERENCES Halls(Hall_Id),
    Book_Date DATETIME DEFAULT GETDATE()
);
GO


--Sample data insertion (INSERT INTO)
-- Insert Movies
INSERT INTO Movie (Name, Genre, Language, Rating)
VALUES 
('Inception', 'Sci-Fi', 'English', 'PG-13'),
('Parasite', 'Thriller', 'Korean', 'R');

-- Insert Shows
INSERT INTO Show (StartTime, EndTime)
VALUES 
('2024-01-20 18:00:00', '2024-01-20 20:30:00'),
('2024-01-20 21:00:00', '2024-01-20 23:30:00');

-- Link Movies to Shows (Play)
INSERT INTO Play (MovieId, Show_No)
VALUES (1, 1), (2, 2);

-- Insert Halls
INSERT INTO Halls (Name, SeatCapacity, SeatType)
VALUES 
('Hall A', 150, 'Standard'),
('Hall B', 50, 'VIP');

-- Insert Customers
INSERT INTO Customer (Name, Email)
VALUES 
('John Doe', 'john@example.com'),
('Jane Smith', 'jane@example.com');

-- Insert Customer Phones
INSERT INTO Customer_Phone (Cust_Id, Phone_no)
VALUES 
(1, '123-456-7890'),
(2, '987-654-3210');

-- Insert Employees
INSERT INTO Employee (Name, Phone_no, Email, City, St_Name, Building_no)
VALUES 
('Alice Brown', '555-1234', 'alice@cinema.com', 'New York', '5th Ave', '10'),
('Bob Green', '555-5678', 'bob@cinema.com', 'Los Angeles', 'Sunset Blvd', '25');

-- Insert Tickets
INSERT INTO Tickets (Price, Customer_Id, Emp_Id, Show_No, Hall_Id)
VALUES 
(15.99, 1, 1, 1, 1),
(25.99, 2, 2, 2, 2);
GO





--Queries (SELECT, JOIN, GROUP BY, etc.)
-- List all tickets sold by employee 'Alice Brown'
SELECT T.T_no, T.Price, C.Name AS Customer, E.Name AS Employee
FROM Tickets T
JOIN Employee E ON T.Emp_Id = E.Emp_Id
JOIN Customer C ON T.Customer_Id = C.CustId
WHERE E.Name = 'Alice Brown';

-- List all movies with their show times
SELECT M.Name, S.StartTime, S.EndTime
FROM Movie M
JOIN Play P ON M.MovieId = P.MovieId
JOIN Show S ON P.Show_No = S.Show_No;

-- Count tickets sold per movie
SELECT M.Name, COUNT(*) AS Tickets_Sold
FROM Tickets T
JOIN Play P ON T.Show_No = P.Show_No
JOIN Movie M ON P.MovieId = M.MovieId
GROUP BY M.Name;

-- Employee ticket sales
SELECT E.Name, COUNT(*) AS Tickets_Sold
FROM Employee E
JOIN Tickets T ON E.Emp_Id = T.Emp_Id
GROUP BY E.Name;

-- Total revenue per movie
SELECT M.Name, SUM(T.Price) AS TotalRevenue
FROM Tickets T
JOIN Show S ON T.Show_No = S.Show_No
JOIN Play P ON S.Show_No = P.Show_No
JOIN Movie M ON P.MovieId = M.MovieId
GROUP BY M.Name;

-- Shows in Hall A
SELECT S.Show_No, S.StartTime, S.EndTime, H.Name AS Hall
FROM Show S
JOIN Tickets T ON S.Show_No = T.Show_No
JOIN Halls H ON T.Hall_Id = H.Hall_Id
WHERE H.Name = 'Hall A';
GO






--Stored procedures/functions/Constraints
-- Stored Procedure: Book a Ticket (Checks seat availability)
CREATE PROCEDURE BookTicket1
    @CustomerId INT,
    @EmpId INT,
    @ShowNo INT,
    @HallId INT,
    @Price DECIMAL(10,2)
AS
BEGIN
    DECLARE @SeatCapacity INT = (SELECT SeatCapacity FROM Halls WHERE Hall_Id = @HallId);
    DECLARE @TicketsSold INT = (SELECT COUNT(*) FROM Tickets WHERE Show_No = @ShowNo AND Hall_Id = @HallId);

    IF @TicketsSold < @SeatCapacity
    BEGIN
        INSERT INTO Tickets (Price, Customer_Id, Emp_Id, Show_No, Hall_Id)
        VALUES (@Price, @CustomerId, @EmpId, @ShowNo, @HallId);
        PRINT 'Ticket booked successfully.';
    END
    ELSE
        PRINT 'Error: Hall is full.';
END
GO

-- Function: Total tickets sold by a hall
CREATE FUNCTION GetTicketsSoldByHall(@HallId INT)
RETURNS INT
AS
BEGIN
    RETURN (SELECT COUNT(*) FROM Tickets WHERE Hall_Id = @HallId);
END
GO


CREATE PROCEDURE GetTicketsByCustomer @CustId INT
AS
BEGIN
    SELECT T.T_no, T.Price, T.Book_Date, M.Name AS Movie
    FROM Tickets T
    JOIN Play P ON T.Show_No = P.Show_No
    JOIN Movie M ON P.MovieId = M.MovieId
    WHERE T.Customer_Id = @CustId;
END;




--Add a new customer 
IF OBJECT_ID('dbo.sp_AddCustomer','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_AddCustomer;
GO
CREATE PROCEDURE sp_AddCustomer
    @Name  NVARCHAR(100),
    @Email NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Customer (Name, Email)
    VALUES (@Name, @Email);
    SELECT SCOPE_IDENTITY() AS NewCustId;
END
GO

-- Update a customer 
IF OBJECT_ID('dbo.sp_UpdateCustomer','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_UpdateCustomer;
GO
CREATE PROCEDURE sp_UpdateCustomer
    @CustId INT,
    @Name   NVARCHAR(100),
    @Email  NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Customer
       SET Name  = @Name,
           Email = @Email
    WHERE CustId = @CustId;
END
GO

--Delete a customer (and their phone records) 
IF OBJECT_ID('dbo.sp_DeleteCustomer','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_DeleteCustomer;
GO
CREATE PROCEDURE sp_DeleteCustomer
    @CustId INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Customer_Phone WHERE Cust_Id = @CustId;
    DELETE FROM Customer       WHERE CustId   = @CustId;
END
GO

--Get movies by genre 
IF OBJECT_ID('dbo.sp_GetMoviesByGenre','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetMoviesByGenre;
GO
CREATE PROCEDURE sp_GetMoviesByGenre
    @Genre NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT MovieId, Name, Language, Rating
    FROM Movie
    WHERE Genre = @Genre
    ORDER BY Rating DESC;
END
GO

--Get tickets by show 
IF OBJECT_ID('dbo.sp_GetTicketsByShow','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetTicketsByShow;
GO
CREATE PROCEDURE sp_GetTicketsByShow
    @Show_No INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
      T.T_no,
      M.Name   AS Movie,
      H.Name   AS Hall,
      T.Price,
      T.Book_Date,
      C.Name   AS Customer,
      E.Name   AS Employee
    FROM Tickets T
    JOIN Play P    ON T.Show_No     = P.Show_No
    JOIN Movie M   ON P.MovieId     = M.MovieId
    JOIN Halls H   ON T.Hall_Id     = H.Hall_Id
    JOIN Customer C ON T.Customer_Id = C.CustId
    JOIN Employee E ON T.Emp_Id      = E.Emp_Id
    WHERE T.Show_No = @Show_No
    ORDER BY T.Book_Date DESC;
END
GO

 -- Get revenue by date range 
IF OBJECT_ID('dbo.sp_GetRevenueByDateRange','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetRevenueByDateRange;
GO
CREATE PROCEDURE sp_GetRevenueByDateRange
    @StartDate DATE,
    @EndDate   DATE
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
      SUM(Price) AS TotalRevenue,
      COUNT(*)   AS TicketsSold
    FROM Tickets
    WHERE Book_Date BETWEEN @StartDate AND @EndDate;
END
GO

--Get sales by employee 
IF OBJECT_ID('dbo.sp_GetSalesByEmployee','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_GetSalesByEmployee;
GO
CREATE PROCEDURE sp_GetSalesByEmployee
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
      E.Emp_Id,
      E.Name,
      COUNT(T.T_no) AS TicketsSold,
      SUM(T.Price)  AS TotalSales
    FROM Employee E
    LEFT JOIN Tickets T ON E.Emp_Id = T.Emp_Id
    GROUP BY E.Emp_Id, E.Name
    ORDER BY TicketsSold DESC;
END
GO

--Book a ticket (with seat-capacity check)
IF OBJECT_ID('dbo.sp_BookTicket','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_BookTicket;
GO
CREATE PROCEDURE sp_BookTicket
    @Price       DECIMAL(10,2),
    @Customer_Id INT,
    @Emp_Id      INT,
    @Show_No     INT,
    @Hall_Id     INT,
    @Book_Date   DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;

        DECLARE @Capacity  INT, 
                @SoldCount INT;
        SELECT @Capacity  = SeatCapacity FROM Halls WHERE Hall_Id = @Hall_Id;
        SELECT @SoldCount = COUNT(*) FROM Tickets WHERE Show_No = @Show_No AND Hall_Id = @Hall_Id;

        IF @SoldCount >= @Capacity
            THROW 51000, 'No seats available for this show in the selected hall.', 1;

        INSERT INTO Tickets (Price, Customer_Id, Emp_Id, Show_No, Hall_Id, Book_Date)
        VALUES (@Price, @Customer_Id, @Emp_Id, @Show_No, @Hall_Id, @Book_Date);

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        IF XACT_STATE() <> 0
            ROLLBACK TRAN;
        THROW;
    END CATCH
END
GO

-- 1. List all Sci-Fi movies
EXEC sp_GetMoviesByGenre @Genre = 'Sci-Fi';
GO

-- 2. Revenue between April 1 and April 30, 2025
EXEC sp_GetRevenueByDateRange
     @StartDate = '2025-04-01',
     @EndDate   = '2025-04-30';
GO

-- 3. Tickets for show #1
EXEC sp_GetTicketsByShow @Show_No = 1;
GO

-- 4. Book a new ticket via proc
EXEC sp_BookTicket
     @Price       = 80.00,
     @Customer_Id = 2,
     @Emp_Id      = 1,
     @Show_No     = 1,
     @Hall_Id     = 1,
     @Book_Date   = '2025-05-01';
GO

--5- GetTicketsSoldByHall function’s return value
SELECT dbo.GetTicketsSoldByHall(1) AS TicketsSoldInHall1;
GO

-- 6- sales by employee
EXEC sp_GetSalesByEmployee;
GO


--change who books the ticket 

-- Change ticket #5 to be sold by employee #3
UPDATE Tickets
SET Emp_Id = 2
WHERE T_no = 5;
GO


-- Drop if it already exists
IF OBJECT_ID('dbo.sp_UpdateTicketEmployee','P') IS NOT NULL
    DROP PROCEDURE dbo.sp_UpdateTicketEmployee;
GO

CREATE PROCEDURE sp_UpdateTicketEmployee
    @TicketNo INT,
    @NewEmpId INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Tickets
       SET Emp_Id = @NewEmpId
    WHERE T_no = @TicketNo;
END
GO


EXEC sp_UpdateTicketEmployee
    @TicketNo = 5,
    @NewEmpId = 3;
GO
