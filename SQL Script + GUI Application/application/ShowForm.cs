using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class ShowForm : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString;

        public ShowForm()
        {
            InitializeComponent();
            LoadShows();
        }

        private void LoadShows()
        {
            using var conn = new SqlConnection(_connStr);
            using var da   = new SqlDataAdapter(
                "SELECT Show_No, StartTime, EndTime FROM Show", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dgvShows.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadShows();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            { 
                using var conn = new SqlConnection(_connStr);
                using var cmd  = new SqlCommand(
                "INSERT INTO Show (StartTime, EndTime) VALUES (@start,@end)", conn);

                cmd.Parameters.AddWithValue("@start", (txtStart.Text));
                cmd.Parameters.AddWithValue("@end", (txtEnd.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadShows();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try { 
             using var conn = new SqlConnection(_connStr);
            using var cmd  = new SqlCommand(
                "UPDATE Show SET StartTime=@start, EndTime=@end WHERE Show_No=@no", conn);
            cmd.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
            cmd.Parameters.AddWithValue("@start", (txtStart.Text));
            cmd.Parameters.AddWithValue("@end", (txtEnd.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadShows();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(_connStr);
            using var cmd  = new SqlCommand(
                "DELETE FROM Show WHERE Show_No=@no", conn);
            cmd.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadShows();
        }

        private void dgvShows_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShows.CurrentRow == null) return;
            var row = dgvShows.CurrentRow;
            txtNo.Text    = row.Cells["Show_No"].Value.ToString();
            txtStart.Text = row.Cells["StartTime"].Value.ToString();
            txtEnd.Text   = row.Cells["EndTime"].Value.ToString();
        }
    }
}
