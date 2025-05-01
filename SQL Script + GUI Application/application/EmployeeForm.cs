using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaTicketSystem
{
    public partial class EmployeeForm : Form
    {
        private readonly string _connStr =
            ConfigurationManager.ConnectionStrings["Cinema"]?.ConnectionString
            ?? throw new InvalidOperationException("Connection string 'Cinema' is not configured.");

        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using var conn = new SqlConnection(_connStr);
            using var da = new SqlDataAdapter(
                "SELECT Emp_Id, Name, Email, City, St_Name, Building_no FROM Employee", conn);
            var dt = new DataTable();
            da.Fill(dt);
            dgvEmployees.DataSource = dt;
        }


        private void LoadPhoneNumbers(int EmpId)
        {
            using var conn = new SqlConnection(_connStr);
            using var da = new SqlDataAdapter(
                "SELECT Phone_no FROM Employee_Phone WHERE Emp_Id = @empId", conn);
            da.SelectCommand.Parameters.AddWithValue("@empId", EmpId);
            var dt = new DataTable();
            da.Fill(dt);
            dgvPhoneNumbers.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
            => LoadEmployees();

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                using var conn = new SqlConnection(_connStr);
                using var cmd = new SqlCommand(
                    "INSERT INTO Employee (Name, Email, City, St_Name, Building_no) " +
                    "VALUES (@name,@mail,@city,@street,@build)", conn);

                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@street", txtStreet.Text);
                cmd.Parameters.AddWithValue("@build", txtBuilding.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadEmployees();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                using var conn = new SqlConnection(_connStr);
                using var cmd = new SqlCommand(
                    "UPDATE Employee SET Name=@name, Email=@mail, " +
                    "City=@city, St_Name=@street, Building_no=@build WHERE Emp_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@street", txtStreet.Text);
                cmd.Parameters.AddWithValue("@build", txtBuilding.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadEmployees();

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
                "DELETE FROM Employee WHERE Emp_Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadEmployees();
        }

        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;
            var row = dgvEmployees.CurrentRow;

            txtId.Text = row.Cells["Emp_Id"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtCity.Text = row.Cells["City"].Value.ToString();
            txtStreet.Text = row.Cells["St_Name"].Value.ToString();
            txtBuilding.Text = row.Cells["Building_no"].Value.ToString();

            if (dgvEmployees.CurrentRow.Cells["Emp_Id"].Value == DBNull.Value || string.IsNullOrWhiteSpace(dgvEmployees.CurrentRow.Cells["Emp_Id"].Value.ToString()))
            {
                txtId.Text = string.Empty;
                return;
            }
            int EmpId = int.Parse(txtId.Text);

            LoadPhoneNumbers(EmpId);

        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) return;

            string phoneNumber = Prompt.ShowDialog("Enter Phone Number:", "Add Phone");
            if (string.IsNullOrWhiteSpace(phoneNumber)) return;

            using var conn = new SqlConnection(_connStr);
            using var cmd = new SqlCommand(
                "INSERT INTO Employee_Phone (Phone_no, Emp_Id) VALUES (@phone, @Emp_Id)", conn);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            cmd.Parameters.AddWithValue("@Emp_Id", int.Parse(txtId.Text));
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
                "UPDATE Employee_Phone SET Phone_no = @newPhone WHERE Phone_no = @oldPhone", conn);
            cmd.Parameters.AddWithValue("@newPhone", newPhone);
            cmd.Parameters.AddWithValue("@oldPhone", oldPhone);
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
                "DELETE FROM Employee_Phone WHERE Phone_no = @phone", conn);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            conn.Open();
            cmd.ExecuteNonQuery();

            LoadPhoneNumbers(int.Parse(txtId.Text));
        }
    }
}