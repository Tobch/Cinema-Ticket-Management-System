using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SeatMe
{
    public partial class PlayForm : Form
    {

        private readonly string _connStr =
           ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString;


        public PlayForm()
        {
            InitializeComponent();
            LoadPlays();

        }


        private void LoadPlays()
        {
            using var conn = new SqlConnection(_connStr);
            using var da = new SqlDataAdapter(
                "SELECT MovieId ,Show_No FROM Play", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dgvPlays.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try {
                using var conn = new SqlConnection(_connStr);
                using var cmd = new SqlCommand(
                    "INSERT INTO Play (Show_No) " +
                    "VALUES (@Show_No)", conn);

                cmd.Parameters.AddWithValue("@Show_No", int.Parse(txtshowno.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadPlays();

            } catch (Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                using var cmd = new SqlCommand(
                    "UPDATE Play SET Show_No=@NewShowNo " +
                    "WHERE MovieId=@MovieId AND Show_No=@OldShowNo", conn);

                // Add parameters for the WHERE clause
                cmd.Parameters.AddWithValue("@MovieId", int.Parse(txtMovieId.Text));
                cmd.Parameters.AddWithValue("@OldShowNo", int.Parse(dgvPlays.CurrentRow.Cells["Show_No"].Value.ToString()));

                // Add parameter for the new value
                cmd.Parameters.AddWithValue("@NewShowNo", int.Parse(txtshowno.Text));

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();


                LoadPlays();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "DELETE FROM Play WHERE MovieId=@Id AND Show_No=@Show_No", conn);
            cmd.Parameters.AddWithValue("@Id ", int.Parse(txtMovieId.Text));
            cmd.Parameters.AddWithValue("@Show_No", int.Parse(txtshowno.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadPlays();
        }

        private void btnRefresh_Click(object sender, EventArgs e)=> LoadPlays();


        private void dgvPlays_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlays.CurrentRow == null) return;
            var row = dgvPlays.CurrentRow;
            txtMovieId.Text = row.Cells["MovieId"].Value.ToString();
            txtshowno.Text = row.Cells["Show_No"].Value.ToString();
         
        }
    }
}
