namespace SeatMe
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hallsToolStripMenuItem;  

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            customersToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            moviesToolStripMenuItem = new ToolStripMenuItem();
            showsToolStripMenuItem = new ToolStripMenuItem();
            ticketsToolStripMenuItem = new ToolStripMenuItem();
            playToolStripMenuItem = new ToolStripMenuItem();
            hallsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { customersToolStripMenuItem, employeesToolStripMenuItem, moviesToolStripMenuItem, showsToolStripMenuItem, ticketsToolStripMenuItem, playToolStripMenuItem, hallsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(990, 24);
            menuStrip1.TabIndex = 0;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(76, 20);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += CustomersToolStripMenuItem_Click;
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(76, 20);
            employeesToolStripMenuItem.Text = "Employees";
            employeesToolStripMenuItem.Click += EmployeesToolStripMenuItem_Click;
            // 
            // moviesToolStripMenuItem
            // 
            moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            moviesToolStripMenuItem.Size = new Size(57, 20);
            moviesToolStripMenuItem.Text = "Movies";
            moviesToolStripMenuItem.Click += moviesToolStripMenuItem_Click;
            // 
            // showsToolStripMenuItem
            // 
            showsToolStripMenuItem.Name = "showsToolStripMenuItem";
            showsToolStripMenuItem.Size = new Size(53, 20);
            showsToolStripMenuItem.Text = "Shows";
            showsToolStripMenuItem.Click += showsToolStripMenuItem_Click;
            // 
            // ticketsToolStripMenuItem
            // 
            ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            ticketsToolStripMenuItem.Size = new Size(56, 20);
            ticketsToolStripMenuItem.Text = "Tickets";
            ticketsToolStripMenuItem.Click += ticketsToolStripMenuItem_Click;
            // 
            // playToolStripMenuItem
            // 
            playToolStripMenuItem.Name = "playToolStripMenuItem";
            playToolStripMenuItem.Size = new Size(41, 20);
            playToolStripMenuItem.Text = "Play";
            playToolStripMenuItem.Click += playToolStripMenuItem_Click;
            // 
            // hallsToolStripMenuItem
            // 
            hallsToolStripMenuItem.Name = "hallsToolStripMenuItem";
            hallsToolStripMenuItem.Size = new Size(45, 20);
            hallsToolStripMenuItem.Text = "Halls";
            hallsToolStripMenuItem.Click += hallsToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(990, 468);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "SeatMe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}