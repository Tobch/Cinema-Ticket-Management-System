namespace SeatMe
{
    partial class HallForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtHallId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSeatCapacity;
        private System.Windows.Forms.TextBox txtSeatType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvHalls;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblHallId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSeatCapacity;
        private System.Windows.Forms.Label lblSeatType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ControlBox = false;
            // Initialize controls
            dgvHalls = new System.Windows.Forms.DataGridView();
            txtHallId = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtSeatCapacity = new System.Windows.Forms.TextBox();
            txtSeatType = new System.Windows.Forms.TextBox();
            lblHallId = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblSeatCapacity = new System.Windows.Forms.Label();
            lblSeatType = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();

            // DataGridView
            ((System.ComponentModel.ISupportInitialize)dgvHalls).BeginInit();
            this.SuspendLayout();

            // 
            // dgvHalls
            // 
            dgvHalls.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHalls.Location = new System.Drawing.Point(12, 150);
            dgvHalls.Name = "dgvHalls";
            dgvHalls.Size = new System.Drawing.Size(760, 300);
            dgvHalls.TabIndex = 0;
            dgvHalls.SelectionChanged += new System.EventHandler(this.dgvHalls_SelectionChanged);

            // 
            // lblHallId
            // 
            lblHallId.AutoSize = true;
            lblHallId.Location = new System.Drawing.Point(12, 20);
            lblHallId.Name = "lblHallId";
            lblHallId.Size = new System.Drawing.Size(53, 15);
            lblHallId.TabIndex = 1;
            lblHallId.Text = "Hall ID:";

            // 
            // txtHallId
            // 
            txtHallId.Location = new System.Drawing.Point(100, 17);
            txtHallId.Name = "txtHallId";
            txtHallId.Size = new System.Drawing.Size(200, 20);
            txtHallId.TabIndex = 2;
            this.txtHallId.Enabled = true; // Allow editing of Hall ID


            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(12, 50);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";

            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(100, 47);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(200, 20);
            txtName.TabIndex = 4;

            // 
            // lblSeatCapacity
            // 
            lblSeatCapacity.AutoSize = true;
            lblSeatCapacity.Location = new System.Drawing.Point(12, 80);
            lblSeatCapacity.Name = "lblSeatCapacity";
            lblSeatCapacity.Size = new System.Drawing.Size(84, 15);
            lblSeatCapacity.TabIndex = 5;
            lblSeatCapacity.Text = "Seat Capacity:";

            // 
            // txtSeatCapacity
            // 
            txtSeatCapacity.Location = new System.Drawing.Point(100, 77);
            txtSeatCapacity.Name = "txtSeatCapacity";
            txtSeatCapacity.Size = new System.Drawing.Size(200, 20);
            txtSeatCapacity.TabIndex = 6;

            // 
            // lblSeatType
            // 
            lblSeatType.AutoSize = true;
            lblSeatType.Location = new System.Drawing.Point(12, 110);
            lblSeatType.Name = "lblSeatType";
            lblSeatType.Size = new System.Drawing.Size(60, 15);
            lblSeatType.TabIndex = 7;
            lblSeatType.Text = "Seat Type:";

            // 
            // txtSeatType
            // 
            txtSeatType.Location = new System.Drawing.Point(100, 107);
            txtSeatType.Name = "txtSeatType";
            txtSeatType.Size = new System.Drawing.Size(200, 20);
            txtSeatType.TabIndex = 8;

            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(330, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(330, 45);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(330, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(330, 105);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(75, 23);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // 
            // HallForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(dgvHalls);
            this.Controls.Add(txtHallId);
            this.Controls.Add(txtName);
            this.Controls.Add(txtSeatCapacity);
            this.Controls.Add(txtSeatType);
            this.Controls.Add(lblHallId);
            this.Controls.Add(lblName);
            this.Controls.Add(lblSeatCapacity);
            this.Controls.Add(lblSeatType);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnRefresh);
            this.Name = "HallForm";
            this.Text = "Hall Management";
            ((System.ComponentModel.ISupportInitialize)(dgvHalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}