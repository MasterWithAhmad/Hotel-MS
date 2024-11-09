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
    public partial class Rooms : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        bool isEditing = false;
        int editingRoomId = 0;
        public Rooms()
        {
            InitializeComponent();
            InitializeListView();
            LoadRooms();
        }

        // Initialize the ListView with columns
        private void InitializeListView()
        {
            lvRooms.View = View.Details;
            lvRooms.Columns.Add("Room ID", 100, HorizontalAlignment.Left);
            lvRooms.Columns.Add("Room Number", 100, HorizontalAlignment.Left);
            lvRooms.Columns.Add("Type", 150, HorizontalAlignment.Left);
            lvRooms.Columns.Add("Rate", 150, HorizontalAlignment.Left);
            lvRooms.Columns.Add("Status", 120, HorizontalAlignment.Left);
            lvRooms.Columns.Add("Description", 300, HorizontalAlignment.Left);
        }

        // Load rooms data into the ListView
        private void LoadRooms()
        {
            lvRooms.Items.Clear();

            string query = "SELECT RoomID, RoomNumber, Type, Rate, Status, Description FROM Rooms";
            string search = txtSearch.Text;
            string sort = cmbSort.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " WHERE RoomNumber LIKE @Search OR Type LIKE @Search OR Status LIKE @Search OR Description LIKE @Search";
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
                        ListViewItem item = new ListViewItem(reader["RoomID"].ToString());
                        item.SubItems.Add(reader["RoomNumber"].ToString());
                        item.SubItems.Add(reader["Type"].ToString());
                        item.SubItems.Add(Convert.ToDecimal(reader["Rate"]).ToString("C2"));
                        item.SubItems.Add(reader["Status"].ToString());
                        item.SubItems.Add(reader["Description"].ToString());

                        lvRooms.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string roomNumber = txtRoomNumber.Text;
            string type = txtRoomType.Text;
            decimal rate;
            if (!decimal.TryParse(txtStatus.Text, out rate))
            {
                MessageBox.Show("Please enter a valid rate.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = txtStatus.Text;
            string description = txtDescription.Text;

            if (string.IsNullOrWhiteSpace(roomNumber) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (isEditing)
                    {
                        cmd.CommandText = "UPDATE Rooms SET RoomNumber = @RoomNumber, Type = @Type, Rate = @Rate, Status = @Status, Description = @Description WHERE RoomID = @RoomID";
                        cmd.Parameters.AddWithValue("@RoomID", editingRoomId);
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Rooms (RoomNumber, Type, Rate, Status, Description) VALUES (@RoomNumber, @Type, @Rate, @Status, @Description)";
                    }

                    cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Rate", Convert.ToDecimal(txtStatus.Text.Replace("$", "").Trim()));
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Description", description);

                    cmd.ExecuteNonQuery();
                }

                if (isEditing)
                {
                    MessageBox.Show("Room updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAddRoom.Text = "Add Room";
                    btnAddRoom.Image = Properties.Resources.icons8_add_16;
                    isEditing = false;
                }
                else
                {
                    MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ResetForm();
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (lvRooms.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a room to delete.", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = int.Parse(lvRooms.SelectedItems[0].SubItems[0].Text);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Rooms WHERE RoomID = @RoomID", conn);
                    cmd.Parameters.AddWithValue("@RoomID", roomId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtRoomNumber.Text != "" || txtRoomType.Text != "" || txtStatus.Text != "" || txtStatus.Text != "" || txtDescription.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to reset the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetForm();
                }
            }
        }

        // Reset form fields
        private void ResetForm()
        {
            txtRoomNumber.Clear();
            txtRoomType.Clear();
            txtStatus.Clear();
            txtStatus.Clear();
            txtDescription.Clear();
            btnAddRoom.Text = "Add Room";
            btnAddRoom.Image = Properties.Resources.icons8_add_16;
            isEditing = false;
            editingRoomId = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void lvRooms_DoubleClick(object sender, EventArgs e)
        {
            if (lvRooms.SelectedItems.Count > 0)
            {
                ListViewItem item = lvRooms.SelectedItems[0];
                editingRoomId = int.Parse(item.SubItems[0].Text);
                txtRoomNumber.Text = item.SubItems[1].Text;
                txtRoomType.Text = item.SubItems[2].Text;
                txtStatus.Text = item.SubItems[3].Text.Replace("$", ""); //Remove dollar sigh for editing
                txtStatus.Text = item.SubItems[4].Text;
                txtDescription.Text = item.SubItems[5].Text;

                btnAddRoom.Text = "Update Room";
                btnAddRoom.Image = Properties.Resources.edit_16;
                isEditing = true;

                // Switch to the rooms tab
                tabControl.SelectedTab = roomsTabPage;
            }
        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {

        }
    }
}
