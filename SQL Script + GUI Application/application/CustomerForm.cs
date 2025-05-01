using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class CustomerForm : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["Cinema"].ConnectionString;

        public CustomerForm()
        {
            InitializeComponent();
          
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using var conn = new SqlConnection(_connStr);
            using var da   = new SqlDataAdapter(
                "SELECT CustId, Name, Email FROM Customer", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dgvCustomers.DataSource = dt;
        }


        private void LoadPhoneNumbers(int customerId)
        {
            using var conn = new SqlConnection(_connStr);
            using var da = new SqlDataAdapter(
                "SELECT Phone_no FROM Customer_Phone WHERE Cust_Id = @custId", conn);
            da.SelectCommand.Parameters.AddWithValue("@custId", customerId);
            var dt = new DataTable();
            da.Fill(dt);
            dgvPhoneNumbers.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadCustomers();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try { 
            using var conn = new SqlConnection(_connStr);
            using var cmd  = new SqlCommand(
            "INSERT INTO Customer (Name, Email) VALUES (@name, @email)", conn);

            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadCustomers();
            }
            catch (Exception ex ) 
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try {
            using var conn = new SqlConnection(_connStr);
            using var cmd  = new SqlCommand(
                "UPDATE Customer SET Name=@name, Email=@email WHERE CustId=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadCustomers();
            }catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

    

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using var conn = new SqlConnection(_connStr);
            conn.Open();

            using var transaction = conn.BeginTransaction();
            try
            {
                // Delete related records in Customer_Phone
                using (var cmd = new SqlCommand(
                    "DELETE FROM Customer_Phone WHERE Cust_Id = @id", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    cmd.ExecuteNonQuery();
                }

                // Delete the Customer record
                using (var cmd = new SqlCommand(
                    "DELETE FROM Customer WHERE CustId = @id", conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    cmd.ExecuteNonQuery();
                }

                transaction.Commit();
                LoadCustomers();
            }
            catch
            {
                transaction.Rollback();
                MessageBox.Show("An error occurred while deleting the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.CurrentRow == null) return;
            txtId.Text = dgvCustomers.CurrentRow.Cells["CustId"].Value.ToString();
            txtName.Text = dgvCustomers.CurrentRow.Cells["Name"].Value.ToString();
            txtEmail.Text = dgvCustomers.CurrentRow.Cells["Email"].Value.ToString();

            if (dgvCustomers.CurrentRow.Cells["CustId"].Value == DBNull.Value || string.IsNullOrWhiteSpace(dgvCustomers.CurrentRow.Cells["CustId"].Value.ToString()))
            {
                txtId.Text = string.Empty;
                return;
            }
            int customerId = int.Parse(txtId.Text);
          
            LoadPhoneNumbers(customerId);
        }


        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) return;

            string phoneNumber = Prompt.ShowDialog("Enter Phone Number:", "Add Phone");
            if (string.IsNullOrWhiteSpace(phoneNumber)) return;

            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "INSERT INTO Customer_Phone (Phone_no, Cust_Id) VALUES (@phone, @custId)", conn);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            cmd.Parameters.AddWithValue("@custId", int.Parse(txtId.Text));
            conn.Open();
            cmd.ExecuteNonQuery();

            LoadPhoneNumbers(int.Parse(txtId.Text));
        }


        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            if (dgvPhoneNumbers.CurrentRow == null) return;

            string phoneNumber = dgvPhoneNumbers.CurrentRow.Cells["Phone_no"].Value.ToString();

            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "DELETE FROM Customer_Phone WHERE Phone_no = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            conn.Open();
            cmd.ExecuteNonQuery();

            LoadPhoneNumbers(int.Parse(txtId.Text));
        }


        private void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            if (dgvPhoneNumbers.CurrentRow == null) return;

            string oldPhone = dgvPhoneNumbers.CurrentRow.Cells["Phone_no"].Value.ToString();
            string newPhone = Prompt.ShowDialog("Enter New Phone Number:", "Update Phone");

            if (string.IsNullOrWhiteSpace(newPhone)) return;

            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "UPDATE Customer_Phone SET Phone_no = @newPhone WHERE Phone_no = @oldPhone", conn);
            cmd.Parameters.AddWithValue("@newPhone", newPhone);
            cmd.Parameters.AddWithValue("@oldPhone", oldPhone);
            conn.Open();
            cmd.ExecuteNonQuery();

            LoadPhoneNumbers(int.Parse(txtId.Text));
        }

    }
}
