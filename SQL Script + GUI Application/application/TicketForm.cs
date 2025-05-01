using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class TicketForm : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString;

        public TicketForm()
        {
            InitializeComponent();
            LoadTickets();
        }

        private void LoadTickets()
        {
            using var conn = new SqlConnection(_connStr);
            using var da = new SqlDataAdapter(
                "SELECT T_no, Price, Customer_Id, Emp_Id, Show_No, Hall_Id, Book_Date FROM Tickets", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dgvTickets.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadTickets();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "INSERT INTO Tickets (Price, Customer_Id, Emp_Id, Show_No, Hall_Id, Book_Date) " +
                "VALUES (@price,@cust,@emp,@show,@hall,@date)", conn);

            cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@cust", int.Parse(txtCustomer.Text));
            cmd.Parameters.AddWithValue("@emp", int.Parse(txtEmployee.Text));
            cmd.Parameters.AddWithValue("@show", int.Parse(txtShow.Text));
            cmd.Parameters.AddWithValue("@hall", int.Parse(txtHall.Text));
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(txtDate.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadTickets();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "UPDATE Tickets SET Price=@price, Customer_Id=@cust, Emp_Id=@emp, " +
                "Show_No=@show, Hall_Id=@hall, Book_Date=@date WHERE T_no=@no", conn);
            cmd.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
            cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
            cmd.Parameters.AddWithValue("@cust", int.Parse(txtCustomer.Text));
            cmd.Parameters.AddWithValue("@emp", int.Parse(txtEmployee.Text));
            cmd.Parameters.AddWithValue("@show", int.Parse(txtShow.Text));
            cmd.Parameters.AddWithValue("@hall", int.Parse(txtHall.Text));
            cmd.Parameters.AddWithValue("@date", DateTime.Parse(txtDate.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadTickets();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "DELETE FROM Tickets WHERE T_no=@no", conn);
            cmd.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadTickets();
        }

        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow == null) return;
            var row = dgvTickets.CurrentRow;
            txtNo.Text = row.Cells["T_no"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtCustomer.Text = row.Cells["Customer_Id"].Value.ToString();
            txtEmployee.Text = row.Cells["Emp_Id"].Value.ToString();
            txtShow.Text = row.Cells["Show_No"].Value.ToString();
            txtHall.Text = row.Cells["Hall_Id"].Value.ToString();
            txtDate.Text = row.Cells["Book_Date"].Value.ToString();
        }

       
    }
}
