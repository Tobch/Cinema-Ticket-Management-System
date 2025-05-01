using System.Xml.Linq;

namespace SeatMe
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPlays = new DataGridView();
            lblShowNo = new Label();
            txtshowno = new TextBox();
            lbMovieId = new Label();
            txtMovieId = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlays).BeginInit();
            SuspendLayout();
            // 
            // dgvPlays
            // 
            dgvPlays.Location = new Point(12, 161);
            dgvPlays.Name = "dgvPlays";
            dgvPlays.Size = new Size(765, 277);
            dgvPlays.TabIndex = 11;
            dgvPlays.SelectionChanged += new System.EventHandler(this.dgvPlays_SelectionChanged);
            // 
            // lblShowNo
            // 
            lblShowNo.AutoSize = true;
            lblShowNo.Location = new Point(26, 62);
            lblShowNo.Name = "lblShowNo";
            lblShowNo.Size = new Size(60, 15);
            lblShowNo.TabIndex = 12;
            lblShowNo.Text = "Show_No:";
            // 
            // txtshowno
            // 
            txtshowno.Location = new Point(113, 54);
            txtshowno.Name = "txtshowno";
            txtshowno.Size = new Size(150, 23);
            txtshowno.TabIndex = 13;
            // 
            // lbMovieId
            // 
            lbMovieId.AutoSize = true;
            lbMovieId.Location = new Point(26, 27);
            lbMovieId.Name = "lbMovieId";
            lbMovieId.Size = new Size(59, 15);
            lbMovieId.TabIndex = 14;
            lbMovieId.Text = "MovieId : ";
            // 
            // txtMovieId
            // 
            txtMovieId.Location = new Point(113, 19);
            txtMovieId.Name = "txtMovieId";
            txtMovieId.Size = new Size(150, 23);
            txtMovieId.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(293, 24);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(293, 54);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(293, 84);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(293, 114);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // PlayForm
            // 
            ClientSize = new Size(853, 453);
            ControlBox = false;
            Controls.Add(dgvPlays);
            Controls.Add(lblShowNo);
            Controls.Add(txtshowno);
            Controls.Add(lbMovieId);
            Controls.Add(txtMovieId);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Name = "PlayForm";
            Text = "Manage Plays ";
            ((System.ComponentModel.ISupportInitialize)dgvPlays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPlays;
        private Label lblShowNo;
        private TextBox txtshowno;
        private Label lbMovieId;
        private TextBox txtMovieId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
    }
}