using HotelEase.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEase
{
    public partial class Staffs : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        bool isEditing = false;

        public Staffs()
        {
            InitializeComponent();
            LoadStaffs();
            InitializeListView();
        }

        private void InitializeListView()
        {
            lvStaffs.View = View.Details;
            lvStaffs.Columns.Add("Staff ID", 100, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("Username", 150, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("Password", 150, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("First Name", 200, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("Last Name", 200, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("Role", 100, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("Email", 200, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("Phone", 150, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("CreatedAt", 150, HorizontalAlignment.Left);
            lvStaffs.Columns.Add("UpdatedAt", 150, HorizontalAlignment.Left);
        }

        private void LoadStaffs()
        {
            lvStaffs.Items.Clear();

            string query = "SELECT StaffID, Username, Password, FirstName, LastName, Role, Email, Phone, CreatedAt, UpdatedAt FROM Staff";
            string search = txtSearch.Text;
            string sort = cmbSort.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " WHERE Username LIKE @Search OR FirstName LIKE @Search OR LastName LIKE @Search OR Email LIKE @Search OR Phone LIKE @Search";
            }

            if (!string.IsNullOrWhiteSpace(sort))
            {
                query += $" ORDER BY {sort}";
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{search}%");
                    }

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["StaffID"].ToString());
                        item.SubItems.Add(reader["Username"].ToString());
                        item.SubItems.Add(reader["Password"].ToString());
                        item.SubItems.Add(reader["FirstName"].ToString());
                        item.SubItems.Add(reader["LastName"].ToString());
                        item.SubItems.Add(reader["Role"].ToString());
                        item.SubItems.Add(reader["Email"].ToString());
                        item.SubItems.Add(reader["Phone"].ToString());
                        item.SubItems.Add(reader["CreatedAt"].ToString());
                        item.SubItems.Add(reader["UpdatedAt"].ToString());

                        lvStaffs.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteStaff()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Staff WHERE StaffID = @StaffID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StaffID", txtStaffId.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStaff()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Staff SET Username = @Username, Password = @Password, FirstName = @FirstName, LastName = @LastName, Role = @Role, Email = @Email, Phone = @Phone, UpdatedAt = GETDATE() WHERE StaffID = @StaffID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StaffID", txtStaffId.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isEditing = false;
                btnSave.Text = "Save";
                btnSave.Image = Resources.save_16; // Reset the icon to default if needed
            }
        }

        private void InsertStaff()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Staff (Username, Password, FirstName, LastName, Role, Email, Phone) VALUES (@Username, @Password, @FirstName, @LastName, @Role, @Email, @Phone)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFields()
        {
            txtStaffId.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            cmbRole.SelectedIndex = -1;

            isEditing = false;
            btnSave.Text = "Save";
            btnSave.Image = Resources.save_16; // Reset the icon to default if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) ||
                cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please fill all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEditing)
            {
                UpdateStaff();
            }
            else
            {
                InsertStaff();
            }

            LoadStaffs();
            ResetFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffId.Text))
            {
                MessageBox.Show("Please select a staff to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DeleteStaff();
            LoadStaffs();
            ResetFields();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStaffId.Text) || !string.IsNullOrWhiteSpace(txtUsername.Text) ||
                !string.IsNullOrWhiteSpace(txtPassword.Text) || !string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                !string.IsNullOrWhiteSpace(txtLastName.Text) || !string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !string.IsNullOrWhiteSpace(txtPhone.Text) || cmbRole.SelectedItem != null)
            {
                var result = MessageBox.Show("Do you want to reset the fields?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ResetFields();
                }
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lvStaffs_DoubleClick(object sender, EventArgs e)
        {
            if (lvStaffs.SelectedItems.Count == 0) return;

            ListViewItem item = lvStaffs.SelectedItems[0];
            txtStaffId.Text = item.SubItems[0].Text;
            txtUsername.Text = item.SubItems[1].Text;
            txtPassword.Text = item.SubItems[2].Text; // Ideally, password should not be loaded this way for security reasons
            txtFirstName.Text = item.SubItems[3].Text;
            txtLastName.Text = item.SubItems[4].Text;
            cmbRole.SelectedItem = item.SubItems[5].Text;
            txtEmail.Text = item.SubItems[6].Text;
            txtPhone.Text = item.SubItems[7].Text;

            isEditing = true;
            btnSave.Text = "Update";
            btnSave.Image = Properties.Resources.edit_16;
            tabControl.SelectedTab = staffsTabPage;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStaffs();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStaffs();
        }
    }
}
