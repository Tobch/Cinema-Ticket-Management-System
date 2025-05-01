using CinemaTicketSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeatMe
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is CustomerForm)
                {
                    child.Activate();
                    return;
                }
            }

            var form = new CustomerForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }


        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is EmployeeForm)
                {
                    child.Activate();
                    return;
                }
            }

            var form = new EmployeeForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is MovieForm)
                {
                    child.Activate();
                    return;
                }
            }

            var form = new MovieForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }

        private void showsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is ShowForm)
                {
                    child.Activate();
                    return;
                }
            }

            var form = new ShowForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized

            };
            form.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is TicketForm)
                {
                    child.Activate();
                    return;
                }
            }

            var form = new TicketForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is PlayForm)
                {
                    child.Activate();
                    return;
                }
            }

            var form = new PlayForm
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            form.Show();
        }

        private void hallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if HallForm is already open
            foreach (Form child in this.MdiChildren)
            {
                if (child is HallForm)
                {
                    // Activate the HallForm if it's already open
                    child.Activate();
                    return;
                }
            }

            // Create a new HallForm instance if not already open
            var hallForm = new HallForm
            {
                MdiParent = this,  // Set MainForm as the parent (MDI container)
                WindowState = FormWindowState.Maximized  // Optionally, maximize the form
            };

            hallForm.Show();  // Show the HallForm
        }






    }
}
