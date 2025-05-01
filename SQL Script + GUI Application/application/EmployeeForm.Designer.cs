namespace CinemaTicketSystem
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button
            btnAdd, btnUpdate, btnDelete, btnRefresh;
        private System.Windows.Forms.Label
            lblId, lblName, lblEmail, lblCity, lblStreet, lblBuilding;

        private System.Windows.Forms.TextBox
            txtId, txtName, txtEmail, txtCity, txtStreet, txtBuilding;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvEmployees = new DataGridView();
            txtId = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            txtBuilding = new TextBox();
            lblId = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblCity = new Label();
            lblStreet = new Label();
            lblBuilding = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            dgvPhoneNumbers = new DataGridView();
            btnAddPhone = new Button();
            btnUpdatePhone = new Button();
            btnDeletePhone = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.ColumnHeadersHeight = 29;
            dgvEmployees.Location = new Point(12, 236);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(852, 272);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.SelectionChanged += dgvEmployees_SelectionChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 23);
            txtId.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(100, 112);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 23);
            txtCity.TabIndex = 10;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(100, 147);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(150, 23);
            txtStreet.TabIndex = 12;
            // 
            // txtBuilding
            // 
            txtBuilding.Location = new Point(100, 181);
            txtBuilding.Name = "txtBuilding";
            txtBuilding.Size = new Size(150, 23);
            txtBuilding.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 15);
            lblId.TabIndex = 1;
            lblId.Text = "Emp_Id:";
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
            lblEmail.Location = new Point(12, 82);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(12, 116);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 9;
            lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(12, 150);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(40, 15);
            lblStreet.TabIndex = 11;
            lblStreet.Text = "Street:";
            // 
            // lblBuilding
            // 
            lblBuilding.AutoSize = true;
            lblBuilding.Location = new Point(12, 184);
            lblBuilding.Name = "lblBuilding";
            lblBuilding.Size = new Size(54, 15);
            lblBuilding.TabIndex = 13;
            lblBuilding.Text = "Building:";
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
            // dgvPhoneNumbers
            // 
            dgvPhoneNumbers.Location = new Point(414, 15);
            dgvPhoneNumbers.Name = "dgvPhoneNumbers";
            dgvPhoneNumbers.Size = new Size(230, 150);
            dgvPhoneNumbers.TabIndex = 22;
            // 
            // btnAddPhone
            // 
            btnAddPhone.Location = new Point(384, 189);
            btnAddPhone.Name = "btnAddPhone";
            btnAddPhone.Size = new Size(100, 23);
            btnAddPhone.TabIndex = 19;
            btnAddPhone.Text = "Add Phone";
            btnAddPhone.Click += btnAddPhone_Click;
            // 
            // btnUpdatePhone
            // 
            btnUpdatePhone.Location = new Point(490, 189);
            btnUpdatePhone.Name = "btnUpdatePhone";
            btnUpdatePhone.Size = new Size(75, 23);
            btnUpdatePhone.TabIndex = 20;
            btnUpdatePhone.Text = "Update Phone";
            btnUpdatePhone.Click += btnUpdatePhone_Click;
            // 
            // btnDeletePhone
            // 
            btnDeletePhone.Location = new Point(571, 189);
            btnDeletePhone.Name = "btnDeletePhone";
            btnDeletePhone.Size = new Size(100, 23);
            btnDeletePhone.TabIndex = 21;
            btnDeletePhone.Text = "Delete Phone";
            btnDeletePhone.Click += btnDeletePhone_Click;
            // 
            // EmployeeForm
            // 
            ClientSize = new Size(876, 509);
            ControlBox = false;
            Controls.Add(dgvPhoneNumbers);
            Controls.Add(btnAddPhone);
            Controls.Add(btnUpdatePhone);
            Controls.Add(btnDeletePhone);
            Controls.Add(dgvEmployees);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(lblStreet);
            Controls.Add(txtStreet);
            Controls.Add(lblBuilding);
            Controls.Add(txtBuilding);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Name = "EmployeeForm";
            Text = "Manage Employees";
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhoneNumbers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridView dgvPhoneNumbers;
        private Button btnAddPhone;
        private Button btnUpdatePhone;
        private Button btnDeletePhone;
    }
}