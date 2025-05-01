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
    public partial class HallForm : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString;

        public HallForm()
        {
            InitializeComponent();
            LoadHalls();
        }

        // Load Halls Data
        private void LoadHalls()
        {
            using var conn = new SqlConnection(_connStr);
            try
            {
                using var da = new SqlDataAdapter("SELECT Hall_Id, Name, SeatCapacity, SeatType FROM Halls", conn);
                var dt = new DataTable();
                da.Fill(dt);

                // Bind data to the DataGridView
                dgvHalls.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading halls: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add New Hall
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                using var cmd = new SqlCommand(
                    "INSERT INTO Halls (Name, SeatCapacity, SeatType) VALUES (@name, @seatCapacity, @seatType)", conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@seatCapacity", int.Parse(txtSeatCapacity.Text));
                cmd.Parameters.AddWithValue("@seatType", txtSeatType.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadHalls(); // Reload halls to show the newly added hall
                MessageBox.Show("Hall added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Existing Hall
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                using var cmd = new SqlCommand(
                    "UPDATE Halls SET Name=@name, SeatCapacity=@seatCapacity, SeatType=@seatType WHERE Hall_Id=@hallId", conn);

                cmd.Parameters.AddWithValue("@hallId", int.Parse(txtHallId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@seatCapacity", int.Parse(txtSeatCapacity.Text));
                cmd.Parameters.AddWithValue("@seatType", txtSeatType.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadHalls(); // Reload halls to show the updated hall
                MessageBox.Show("Hall updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Hall
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new SqlConnection(_connStr);
                using var cmd = new SqlCommand("DELETE FROM Halls WHERE Hall_Id=@hallId", conn);
                cmd.Parameters.AddWithValue("@hallId", int.Parse(txtHallId.Text));

                conn.Open();
                cmd.ExecuteNonQuery();
                LoadHalls(); // Reload halls to remove the deleted hall
                MessageBox.Show("Hall deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display Selected Hall Data in Textboxes
        private void dgvHalls_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHalls.CurrentRow == null) return;
            var row = dgvHalls.CurrentRow;

            txtHallId.Text = row.Cells["Hall_Id"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtSeatCapacity.Text = row.Cells["SeatCapacity"].Value.ToString();
            txtSeatType.Text = row.Cells["SeatType"].Value.ToString();
        }

        // Refresh Halls Data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHalls();
        }
    }
}
