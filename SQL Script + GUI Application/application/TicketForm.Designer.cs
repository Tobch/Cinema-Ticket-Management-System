namespace CinemaTicketSystem
{
    partial class TicketForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.TextBox
            txtNo, txtPrice, txtCustomer, txtEmployee, txtShow, txtHall, txtDate;
        private System.Windows.Forms.Button
            btnAdd, btnUpdate, btnDelete, btnRefresh;
        private System.Windows.Forms.Label
            lblNo, lblPrice, lblCustomer, lblEmployee, lblShow, lblHall, lblDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvTickets = new DataGridView();
            txtNo = new TextBox();
            txtPrice = new TextBox();
            txtCustomer = new TextBox();
            txtEmployee = new TextBox();
            txtShow = new TextBox();
            txtHall = new TextBox();
            txtDate = new TextBox();
            lblNo = new Label();
            lblPrice = new Label();
            lblCustomer = new Label();
            lblEmployee = new Label();
            lblShow = new Label();
            lblHall = new Label();
            lblDate = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // dgvTickets
            // 
            dgvTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTickets.ColumnHeadersHeight = 29;
            dgvTickets.Location = new Point(12, 258);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.Size = new Size(696, 306);
            dgvTickets.TabIndex = 0;
            dgvTickets.SelectionChanged += dgvTickets_SelectionChanged;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(100, 12);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(150, 27);
            txtNo.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(100, 42);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(100, 72);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(150, 27);
            txtCustomer.TabIndex = 6;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(100, 102);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(150, 27);
            txtEmployee.TabIndex = 8;
            // 
            // txtShow
            // 
            txtShow.Location = new Point(100, 132);
            txtShow.Name = "txtShow";
            txtShow.Size = new Size(150, 27);
            txtShow.TabIndex = 10;
            // 
            // txtHall
            // 
            txtHall.Location = new Point(100, 162);
            txtHall.Name = "txtHall";
            txtHall.Size = new Size(150, 27);
            txtHall.TabIndex = 12;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(100, 192);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(150, 27);
            txtDate.TabIndex = 14;
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(12, 15);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(43, 20);
            lblNo.TabIndex = 1;
            lblNo.Text = "T_no:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 45);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(12, 75);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(59, 20);
            lblCustomer.TabIndex = 5;
            lblCustomer.Text = "Cust_Id:";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(12, 105);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(61, 20);
            lblEmployee.TabIndex = 7;
            lblEmployee.Text = "Emp_Id:";
            // 
            // lblShow
            // 
            lblShow.AutoSize = true;
            lblShow.Location = new Point(12, 135);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(74, 20);
            lblShow.TabIndex = 9;
            lblShow.Text = "Show_No:";
            // 
            // lblHall
            // 
            lblHall.AutoSize = true;
            lblHall.Location = new Point(12, 165);
            lblHall.Name = "lblHall";
            lblHall.Size = new Size(58, 20);
            lblHall.TabIndex = 11;
            lblHall.Text = "Hall_Id:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(12, 195);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(84, 20);
            lblDate.TabIndex = 13;
            lblDate.Text = "Book_Date:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(280, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(280, 42);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 72);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(280, 102);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // TicketForm
            // 
            ClientSize = new Size(720, 518);
            ControlBox = false;
            Controls.Add(dgvTickets);
            Controls.Add(lblNo);
            Controls.Add(txtNo);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblCustomer);
            Controls.Add(txtCustomer);
            Controls.Add(lblEmployee);
            Controls.Add(txtEmployee);
            Controls.Add(lblShow);
            Controls.Add(txtShow);
            Controls.Add(lblHall);
            Controls.Add(txtHall);
            Controls.Add(lblDate);
            Controls.Add(txtDate);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Name = "TicketForm";
            Text = "Manage Tickets";
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
