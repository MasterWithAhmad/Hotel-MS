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
    public partial class Guests : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        bool isEditing = false;
        public Guests()
        {
            InitializeComponent();
            LoadGuests(); // Load guests when form is initialized
            InitializeListView();
        }

        // Initialize the ListView columns
        private void InitializeListView()
        {
            lvGuests.Columns.Clear();
            lvGuests.Columns.Add("Guest ID", 100);
            lvGuests.Columns.Add("First Name", 150);
            lvGuests.Columns.Add("Last Name", 150);
            lvGuests.Columns.Add("Email", 170);
            lvGuests.Columns.Add("Phone", 150);
            lvGuests.Columns.Add("Address", 150);
            lvGuests.Columns.Add("Date of Birth", 100);

            // Optionally set ListView view
            lvGuests.View = View.Details;
        }

        private void AddGuest()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Guests (FirstName, LastName, Email, Phone, Address, DateOfBirth) VALUES (@FirstName, @LastName, @Email, @Phone, @Address, @DateOfBirth)";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Text); // Handle DateOfBirth if needed

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"An error occurred while adding the guest: {ex.Message}");
                }
            }
        }

        private void UpdateGuest()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Guests SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, Address = @Address, DateOfBirth = @DateOfBirth, UpdatedAt = GETDATE() WHERE GuestID = @GuestID";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                command.Parameters.AddWithValue("@Address", txtAddress.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dtpDateOfBirth.Text); // Handle DateOfBirth if needed
                                                                                      // 
                command.Parameters.AddWithValue("@GuestID", int.Parse(txtGuestId.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"An error occurred while updating the guest: {ex.Message}");
                }
            }
        }

        private void DeleteGuest()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Guests WHERE GuestID = @GuestID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", int.Parse(txtGuestId.Text));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"An error occurred while deleting the guest: {ex.Message}");
                }
            }
        }

        // Load all guests into the ListView
        private void LoadGuests()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Guests", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    lvGuests.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["GuestID"].ToString());
                        item.SubItems.Add(row["FirstName"].ToString());
                        item.SubItems.Add(row["LastName"].ToString());
                        item.SubItems.Add(row["Email"].ToString());
                        item.SubItems.Add(row["Phone"].ToString());
                        item.SubItems.Add(row["Address"].ToString());
                        item.SubItems.Add(((DateTime)row["DateOfBirth"]).ToString("d"));
                        lvGuests.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading guests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


     

        // Validate input fields
        private bool ValidateGuestInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Clear all input fields
        private void ClearInputFields()
        {
            txtGuestId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dtpDateOfBirth.Value = DateTime.Today;
            isEditing = false;
            btnSave.Text = "Save";            
        }        
           

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (isEditing)
                {
                    // Update existing guest
                    UpdateGuest();
                }
                else
                {
                    // Add new guest
                    AddGuest();
                }
                MessageBox.Show(isEditing ? "Guest updated successfully!" : "Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                LoadGuests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sortOrder = txtSearch.SelectedText.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM Guests ORDER BY {sortOrder}", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    lvGuests.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["GuestID"].ToString());
                        item.SubItems.Add(row["FirstName"].ToString());
                        item.SubItems.Add(row["LastName"].ToString());
                        item.SubItems.Add(row["Email"].ToString());
                        item.SubItems.Add(row["Phone"].ToString());
                        item.SubItems.Add(row["Address"].ToString());
                        item.SubItems.Add(((DateTime)row["DateOfBirth"]).ToString("d"));
                        lvGuests.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sorting guests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (lvGuests.SelectedItems.Count > 0)
            {
                var selectedItem = lvGuests.SelectedItems[0];
                int guestId = Convert.ToInt32(selectedItem.Text);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM Guests WHERE GuestID = @GuestID";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@GuestID", guestId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Guest deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadGuests(); // Refresh the ListView
                            ClearInputFields(); // Clear fields
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting guest: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a guest to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            if (txtGuestId.Text != string.Empty || txtFirstName.Text != string.Empty || txtLastName.Text != string.Empty || txtEmail.Text != string.Empty || txtPhone.Text != string.Empty || txtAddress.Text != string.Empty)
            {
                ClearInputFields();
            }
        }

        private void lvGuests_DoubleClick_1(object sender, EventArgs e)
        {
            if (lvGuests.SelectedItems.Count > 0)
            {
                var selectedItem = lvGuests.SelectedItems[0];
                txtGuestId.Text = selectedItem.Text;
                txtFirstName.Text = selectedItem.SubItems[1].Text;
                txtLastName.Text = selectedItem.SubItems[2].Text;
                txtEmail.Text = selectedItem.SubItems[3].Text;
                txtPhone.Text = selectedItem.SubItems[4].Text;
                txtAddress.Text = selectedItem.SubItems[5].Text;
                dtpDateOfBirth.Value = DateTime.Parse(selectedItem.SubItems[6].Text);


                isEditing = true;
                btnSave.Text = "Update";
                btnSave.Image = Properties.Resources.edit_16;

                // Switch to the rooms tab
                tabControl.SelectedTab = guestTabPage;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Guests WHERE FirstName LIKE @Search OR LastName LIKE @Search OR Email LIKE @Search", conn);
                    da.SelectCommand.Parameters.AddWithValue("@Search", $"%{searchQuery}%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    lvGuests.Items.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row["GuestID"].ToString());
                        item.SubItems.Add(row["FirstName"].ToString());
                        item.SubItems.Add(row["LastName"].ToString());
                        item.SubItems.Add(row["Email"].ToString());
                        item.SubItems.Add(row["Phone"].ToString());
                        item.SubItems.Add(row["Address"].ToString());
                        item.SubItems.Add(((DateTime)row["DateOfBirth"]).ToString("d"));
                        lvGuests.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching guests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guestTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
