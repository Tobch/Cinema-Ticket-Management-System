namespace CinemaTicketSystem
{
    partial class MovieForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TextBox
            txtId, txtName, txtGenre, txtLanguage, txtRating;
        private System.Windows.Forms.Button
            btnAdd, btnUpdate, btnDelete, btnRefresh;
        private System.Windows.Forms.Label
            lblId, lblName, lblGenre, lblLanguage, lblRating;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.ControlBox = false;                            // Hide Minimize, Maximize, and Close

            dgvMovies = new System.Windows.Forms.DataGridView();
            txtId        = new System.Windows.Forms.TextBox();
            txtName      = new System.Windows.Forms.TextBox();
            txtGenre     = new System.Windows.Forms.TextBox();
            txtLanguage  = new System.Windows.Forms.TextBox();
            txtRating    = new System.Windows.Forms.TextBox();
            lblId        = new System.Windows.Forms.Label();
            lblName      = new System.Windows.Forms.Label();
            lblGenre     = new System.Windows.Forms.Label();
            lblLanguage  = new System.Windows.Forms.Label();
            lblRating    = new System.Windows.Forms.Label();
            btnAdd       = new System.Windows.Forms.Button();
            btnUpdate    = new System.Windows.Forms.Button();
            btnDelete    = new System.Windows.Forms.Button();
            btnRefresh   = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvMovies)).BeginInit();
            this.SuspendLayout();
            // dgvMovies
            dgvMovies.Anchor = ((System.Windows.Forms.AnchorStyles)
               ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
            dgvMovies.Location = new System.Drawing.Point(12, 180);
            dgvMovies.Name     = "dgvMovies";
            dgvMovies.Size     = new System.Drawing.Size(576, 208);
            dgvMovies.SelectionChanged += new System.EventHandler(this.dgvMovies_SelectionChanged);
            // Labels & TextBoxes
            lblId.AutoSize      = true; lblId.Location      = new System.Drawing.Point(12,15);   lblId.Text      = "MovieId:";
            txtId.Location      = new System.Drawing.Point(100,12); txtId.Width     = 150;
            lblName.AutoSize    = true; lblName.Location    = new System.Drawing.Point(12,45);   lblName.Text    = "Name:";
            txtName.Location    = new System.Drawing.Point(100,42); txtName.Width   = 150;
            lblGenre.AutoSize   = true; lblGenre.Location   = new System.Drawing.Point(12,75);   lblGenre.Text   = "Genre:";
            txtGenre.Location   = new System.Drawing.Point(100,72); txtGenre.Width  = 150;
            lblLanguage.AutoSize= true; lblLanguage.Location= new System.Drawing.Point(12,105);  lblLanguage.Text= "Language:";
            txtLanguage.Location= new System.Drawing.Point(100,102);txtLanguage.Width=150;
            lblRating.AutoSize  = true; lblRating.Location  = new System.Drawing.Point(12,135);  lblRating.Text  = "Rating:";
            txtRating.Location  = new System.Drawing.Point(100,132);txtRating.Width  =150;
            // Buttons
            btnAdd   .Location = new System.Drawing.Point(280,12); btnAdd.Text    = "Add";    btnAdd.Click   += new System.EventHandler(this.btnAdd_Click);
            btnUpdate.Location = new System.Drawing.Point(280,42); btnUpdate.Text = "Update"; btnUpdate.Click+= new System.EventHandler(this.btnUpdate_Click);
            btnDelete.Location = new System.Drawing.Point(280,72); btnDelete.Text = "Delete"; btnDelete.Click+= new System.EventHandler(this.btnDelete_Click);
            btnRefresh.Location= new System.Drawing.Point(280,102);btnRefresh.Text= "Refresh";btnRefresh.Click+= new System.EventHandler(this.btnRefresh_Click);
            // MovieForm
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                dgvMovies,
                lblId, txtId,
                lblName, txtName,
                lblGenre, txtGenre,
                lblLanguage, txtLanguage,
                lblRating, txtRating,
                btnAdd, btnUpdate, btnDelete, btnRefresh });
            this.Name = "MovieForm";
            this.Text = "Manage Movies";
            ((System.ComponentModel.ISupportInitialize)(dgvMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
