namespace CinemaTicketSystem
{
    partial class ShowForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvShows;
        private System.Windows.Forms.TextBox txtNo, txtStart, txtEnd;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnRefresh;
        private System.Windows.Forms.Label lblNo, lblStart, lblEnd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ControlBox = false;                            // Hide Minimize, Maximize, and Close

            dgvShows = new System.Windows.Forms.DataGridView();
            txtNo       = new System.Windows.Forms.TextBox();
            txtStart    = new System.Windows.Forms.TextBox();
            txtEnd      = new System.Windows.Forms.TextBox();
            lblNo       = new System.Windows.Forms.Label();
            lblStart    = new System.Windows.Forms.Label();
            lblEnd      = new System.Windows.Forms.Label();
            btnAdd      = new System.Windows.Forms.Button();
            btnUpdate   = new System.Windows.Forms.Button();
            btnDelete   = new System.Windows.Forms.Button();
            btnRefresh  = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvShows)).BeginInit();
            this.SuspendLayout();
            // dgvShows
            dgvShows.Anchor = ((System.Windows.Forms.AnchorStyles)
               ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
            dgvShows.Location = new System.Drawing.Point(12, 160);
            dgvShows.Name     = "dgvShows";
            dgvShows.Size     = new System.Drawing.Size(576, 228);
            dgvShows.SelectionChanged += new System.EventHandler(this.dgvShows_SelectionChanged);
            // Labels & TextBoxes
            lblNo.AutoSize    = true; lblNo.Location    = new System.Drawing.Point(12,15); lblNo.Text    = "Show_No:";
            txtNo.Location    = new System.Drawing.Point(100,12);txtNo.Width    =150;
            lblStart.AutoSize = true; lblStart.Location = new System.Drawing.Point(12,45); lblStart.Text = "StartTime:";
            txtStart.Location = new System.Drawing.Point(100,42);txtStart.Width =150;
            lblEnd.AutoSize   = true; lblEnd.Location   = new System.Drawing.Point(12,75); lblEnd.Text   = "EndTime:";
            txtEnd.Location   = new System.Drawing.Point(100,72);txtEnd.Width   =150;
            // Buttons
            btnAdd   .Location = new System.Drawing.Point(280,12); btnAdd.Text    = "Add";    btnAdd.Click   += new System.EventHandler(this.btnAdd_Click);
            btnUpdate.Location = new System.Drawing.Point(280,42); btnUpdate.Text = "Update"; btnUpdate.Click+= new System.EventHandler(this.btnUpdate_Click);
            btnDelete.Location = new System.Drawing.Point(280,72); btnDelete.Text = "Delete"; btnDelete.Click+= new System.EventHandler(this.btnDelete_Click);
            btnRefresh.Location= new System.Drawing.Point(280,102);btnRefresh.Text= "Refresh";btnRefresh.Click+= new System.EventHandler(this.btnRefresh_Click);
            // ShowForm
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                dgvShows,
                lblNo, txtNo,
                lblStart, txtStart,
                lblEnd, txtEnd,
                btnAdd, btnUpdate, btnDelete, btnRefresh });
            this.Name = "ShowForm";
            this.Text = "Manage Shows";
            ((System.ComponentModel.ISupportInitialize)(dgvShows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
