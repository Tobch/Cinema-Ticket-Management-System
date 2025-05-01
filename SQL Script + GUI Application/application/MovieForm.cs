using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class MovieForm : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString;

        public MovieForm()
        {
            InitializeComponent();
            LoadMovies();
        }

        private void LoadMovies()
        {
            using var conn = new SqlConnection(_connStr);
            using var da   = new SqlDataAdapter(
                "SELECT MovieId, Name, Genre, Language, Rating FROM Movie", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dgvMovies.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadMovies();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try { 
            using var conn = new SqlConnection(_connStr);
            using var cmd  = new SqlCommand(
                "INSERT INTO Movie (Name, Genre, Language, Rating) " +
                "VALUES (@name,@genre,@lang,@rating)", conn);

            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@genre", txtGenre.Text);
            cmd.Parameters.AddWithValue("@lang", txtLanguage.Text);
            cmd.Parameters.AddWithValue("@rating", decimal.Parse(txtRating.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadMovies();
            
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
                "UPDATE Movie SET Name=@name, Genre=@genre, Language=@lang, Rating=@rating " +
                "WHERE MovieId=@id", conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@lang", txtLanguage.Text);
                cmd.Parameters.AddWithValue("@rating", decimal.Parse(txtRating.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
            LoadMovies();
            }
            catch (Exception ex){
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(_connStr);
            using var cmd  = new SqlCommand(
                "DELETE FROM Movie WHERE MovieId=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadMovies();
        }

        private void dgvMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovies.CurrentRow == null) return;
            var row = dgvMovies.CurrentRow;
            txtId.Text       = row.Cells["MovieId"].Value.ToString();
            txtName.Text     = row.Cells["Name"].Value.ToString();
            txtGenre.Text    = row.Cells["Genre"].Value.ToString();
            txtLanguage.Text = row.Cells["Language"].Value.ToString();
            txtRating.Text   = row.Cells["Rating"].Value.ToString();
        }
    }
}
