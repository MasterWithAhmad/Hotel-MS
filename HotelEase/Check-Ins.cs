using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEase
{
    public partial class Check_Ins : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public Check_Ins()
        {
            InitializeComponent();
            InitializeListView();
            LoadCheckIns();
        }

        private void InitializeListView()
        {
            lvCheckIns.View = View.Details;
            lvCheckIns.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            lvCheckIns.Columns.Add("Guest ID", 150, HorizontalAlignment.Left);
            lvCheckIns.Columns.Add("Room ID", 150, HorizontalAlignment.Left);
            lvCheckIns.Columns.Add("Check In Date", 200, HorizontalAlignment.Left);
            lvCheckIns.Columns.Add("Check Out Date", 200, HorizontalAlignment.Left);
            lvCheckIns.Columns.Add("Total Amount", 200, HorizontalAlignment.Left);
            lvCheckIns.Columns.Add("Status", 150, HorizontalAlignment.Left);
        }

        // Load check ins data into the ListView
        private void LoadCheckIns()
        {
            lvCheckIns.Items.Clear();

            string query = "SELECT BookingID, GuestID, RoomID, CheckInDate, CheckOutDate, TotalAmount, Status FROM Bookings";
            string search = txtSearch.Text;
            string sort = cmbSort.SelectedItem?.ToString();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query += " WHERE RoomNID LIKE @Search OR Type LIKE @Search OR Status LIKE @Search OR GuestID LIKE @Search";
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
                        ListViewItem item = new ListViewItem(reader["BookingID"].ToString());
                        item.SubItems.Add(reader["GuestID"].ToString());
                        item.SubItems.Add(reader["RoomID"].ToString());
                        item.SubItems.Add(reader["CheckInDate"].ToString());
                        item.SubItems.Add(reader["CheckOutDate"].ToString());
                        item.SubItems.Add(Convert.ToDecimal(reader["TotalAmount"]).ToString("C2"));
                        item.SubItems.Add(reader["Status"].ToString());

                        lvCheckIns.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateBookingQuery = "UPDATE Bookings SET CheckInDate = @CheckInDate, Status = 'Checked In' WHERE BookingID = @BookingID";
                    SqlCommand updateBookingCommand = new SqlCommand(updateBookingQuery, connection, transaction);
                    updateBookingCommand.Parameters.AddWithValue("@CheckInDate", dtpCheckInDate.Value);
                    updateBookingCommand.Parameters.AddWithValue("@BookingID", int.Parse(txtBookingID.Text));
                    updateBookingCommand.ExecuteNonQuery();

                    string updateRoomQuery = "UPDATE Rooms SET Status = 'Occupied' WHERE RoomID = @RoomID";
                    SqlCommand updateRoomCommand = new SqlCommand(updateRoomQuery, connection, transaction);
                    updateRoomCommand.Parameters.AddWithValue("@RoomID", int.Parse(txtRoomID.Text));
                    updateRoomCommand.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Check-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void ResetFields()
        {

            txtBookingID.Text = string.Empty;
            txtGuestID.Text = string.Empty;
            txtRoomID.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            txtRoomRate.Text = string.Empty;
            dtpCheckInDate.Value = DateTime.Now;           
            lblTotalAmount.Text = string.Empty;            
            txtGuestName.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void btnGetRoomNumber_Click(object sender, EventArgs e)
        {
            ReservedRooms reservedRoomsForm = new ReservedRooms();
            if (reservedRoomsForm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem selectedItem = reservedRoomsForm.lvReservations.SelectedItems[0];
                txtBookingID.Text = selectedItem.SubItems[0].Text;
                txtGuestID.Text = selectedItem.SubItems[1].Text;
                txtRoomID.Text = selectedItem.SubItems[2].Text;
                dtpCheckInDate.Value = DateTime.Parse(selectedItem.SubItems[3].Text);
                lblTotalAmount.Text = selectedItem.SubItems[5].Text;
                //lblTotalAmount.Text = "$" +selectedItem.SubItems[5].Text;

                txtGuestName.Text = GetGuestName(int.Parse(txtGuestID.Text));
                txtEmail.Text = GetGuestEmail(int.Parse(txtGuestID.Text));
                txtRoomNumber.Text = GetRoomNumber(int.Parse(txtRoomID.Text));
                txtRoomRate.Text = "$" + GetRoomRate(int.Parse(txtRoomID.Text));
            }
        }

        private void lvCheckIns_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetGuestName(int guestId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FirstName + ' ' + LastName AS FullName FROM Guests WHERE GuestID = @GuestID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guestId);

                connection.Open();
                string fullName = command.ExecuteScalar().ToString();
                connection.Close();

                return fullName;
            }
        }

        private string GetGuestEmail(int guestId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Email FROM Guests WHERE GuestID = @GuestID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guestId);

                connection.Open();
                string email = command.ExecuteScalar().ToString();
                connection.Close();

                return email;
            }
        }

        private string GetRoomNumber(int roomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomNumber FROM Rooms WHERE RoomID = @RoomID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", roomId);

                connection.Open();
                string roomNumber = command.ExecuteScalar().ToString();
                connection.Close();

                return roomNumber;
            }
        }

        private string GetRoomRate(int roomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Rate FROM Rooms WHERE RoomID = @RoomID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", roomId);

                connection.Open();
                string rate = command.ExecuteScalar().ToString();
                connection.Close();

                return rate;
            }
        }
    }
}
