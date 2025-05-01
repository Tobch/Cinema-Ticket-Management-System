namespace CinemaTicketSystem
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtId, txtName, txtEmail;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnRefresh;
        private System.Windows.Forms.Label lblId, lblName, lblEmail;

        private System.Windows.Forms.DataGridView dgvPhoneNumbers;
        private System.Windows.Forms.Button btnAddPhone, btnUpdatePhone, btnDeletePhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCustomers = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            lblId = new Label();
            lblName = new Label();
            lblEmail = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvPhoneNumbers = new DataGridView();
            btnAddPhone = new Button();
            btnDeletePhone = new Button();
            btnUpdatePhone = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCustomers.Location = new Point(12, 214);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.Size = new Size(733, 420);
            dgvCustomers.TabIndex = 0;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(80, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(44, 15);
            lblId.TabIndex = 1;
            lblId.Text = "CustId:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(260, 40);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 69);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(260, 99);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvPhoneNumbers
            // 
            dgvPhoneNumbers.Location = new Point(360, 10);
            dgvPhoneNumbers.Name = "dgvPhoneNumbers";
            dgvPhoneNumbers.Size = new Size(230, 150);
            dgvPhoneNumbers.TabIndex = 10;
            // 
            // btnAddPhone
            // 
            btnAddPhone.Location = new Point(316, 170);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(100, 23);
            btnAddPhone.TabIndex = 0;
            btnAddPhone.Text = "Add Phone";
            btnAddPhone.Click += btnAddPhone_Click;
            // 
            // btnDeletePhone
            // 
            btnDeletePhone.Location = new Point(503, 170);
            btnDeletePhone.Name = "btnDeletePhone";
            btnDeletePhone.Size = new Size(100, 23);
            btnDeletePhone.TabIndex = 0;
            btnDeletePhone.Text = "Delete Phone";
            btnDeletePhone.Click += btnDeletePhone_Click;
            // 
            // btnUpdatePhone
            // 
            btnUpdatePhone.Location = new Point(422, 170);
            btnUpdatePhone.Name = "btnUpdatePhone";
            btnUpdatePhone.Size = new Size(75, 23);
            btnUpdatePhone.TabIndex = 0;
            btnUpdatePhone.Text = "Update Phone";
            btnUpdatePhone.Click += btnUpdatePhone_Click;
            // 
            // CustomerForm
            // 
            ClientSize = new Size(757, 570);
            ControlBox = false;
            Controls.Add(dgvCustomers);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(dgvPhoneNumbers);
            Controls.Add(btnAddPhone);
            Controls.Add(btnUpdatePhone);
            Controls.Add(btnDeletePhone);
            Name = "CustomerForm";
            Text = "Manage Customers";
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
