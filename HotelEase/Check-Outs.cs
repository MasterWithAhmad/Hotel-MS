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
    public partial class Check_Outs : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public Check_Outs()
        {
            InitializeComponent();
            InitializeListView();
            LoadCheckOuts();
            cmbStatus.Items.AddRange(new string[] { "Checked-Out", "Cancelled" });
            cmbStatus.Text = "Checked Out";
        }

        private void InitializeListView()
        {
            lvCheckOuts.View = View.Details;
            lvCheckOuts.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Guest ID", 150, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Room ID", 150, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Check In Date", 250, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Check Out Date", 250, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Total Amount", 200, HorizontalAlignment.Left);
            //lvCheckOuts.Columns.Add("Status", 150, HorizontalAlignment.Left);
        }

        // Load check ins data into the ListView
        private void LoadCheckOuts()
        {
            lvCheckOuts.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID, GuestID, RoomID, CheckInDate, CheckOutDate, TotalAmount FROM Bookings WHERE Status = 'Checked Out'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["BookingID"].ToString());
                    item.SubItems.Add(reader["GuestID"].ToString());
                    item.SubItems.Add(reader["RoomID"].ToString());
                    item.SubItems.Add(reader["CheckInDate"].ToString());
                    item.SubItems.Add(reader["CheckOutDate"].ToString());
                    item.SubItems.Add("$" + reader["TotalAmount"].ToString());
                    lvCheckOuts.Items.Add(item);
                }

                reader.Close();
                connection.Close();
            }
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Bookings SET Status = 'Checked Out', CheckOutDate = @CheckOutDate WHERE BookingID = @BookingID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CheckOutDate", dtpCheckOutDate.Value);
                command.Parameters.AddWithValue("@BookingID", int.Parse(txtBookingID.Text));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                UpdateRoomStatus(int.Parse(txtRoomID.Text), "Available");

                LoadCheckOuts();
                ResetFields();
            }
        }

        private void ResetFields()
        {

            txtBookingID.Text = string.Empty;
            txtGuestID.Text = string.Empty;
            txtRoomID.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            txtRoomRate.Text = string.Empty;
            dtpCheckOutDate.Value = DateTime.Now;
            lblTotalAmount.Text = string.Empty;
            txtGuestName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
        }

        private void btnGetRoomNumber_Click(object sender, EventArgs e)
        {
            OccupiedRooms occupiedRoomsForm = new OccupiedRooms();
            if (occupiedRoomsForm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem selectedItem = occupiedRoomsForm.lvOccupiedRooms.SelectedItems[0];
                txtBookingID.Text = selectedItem.SubItems[0].Text;
                txtGuestID.Text = selectedItem.SubItems[1].Text;
                txtRoomID.Text = selectedItem.SubItems[2].Text;
                dtpCheckOutDate.Value = DateTime.Now;
                lblTotalAmount.Text = "$" + selectedItem.SubItems[5].Text;

                txtGuestName.Text = GetGuestName(int.Parse(txtGuestID.Text));
                txtEmail.Text = GetGuestEmail(int.Parse(txtGuestID.Text));
                txtRoomNumber.Text = GetRoomNumber(int.Parse(txtRoomID.Text));
                txtRoomRate.Text = "$" + GetRoomRate(int.Parse(txtRoomID.Text));
                cmbStatus.Text = "Checked Out";
            }
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

        private void UpdateRoomStatus(int roomId, string status)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Rooms SET Status = @Status WHERE RoomID = @RoomID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", roomId);
                command.Parameters.AddWithValue("@Status", status);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


    }
}
