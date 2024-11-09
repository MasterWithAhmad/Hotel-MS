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
    public partial class Reservations : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        private bool isEditing = false;

        public Reservations()
        {
            InitializeComponent();
            LoadReservations();
            InitializeListView();
            cmbStatus.Items.AddRange(new string[] { "Pending", "Cancelled" });
            cmbStatus.Text = "Checked In";
        }

        private void InitializeListView()
        {
            lvReservations.View = View.Details;
            lvReservations.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Guest ID", 150, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Room ID", 150, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Check In Date", 200, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Check Out Date", 200, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Total Amount", 200, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Status", 150, HorizontalAlignment.Left);
        }

        private void LoadRoomDetails(string roomId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomNumber, Rate FROM Rooms WHERE RoomID = @RoomID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoomID", int.Parse(roomId));

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtRoomNumber.Text = reader["RoomNumber"].ToString();
                        txtRoomRate.Text = reader["Rate"].ToString();
                        CalculateTotalAmount(); // Recalculate total amount based on room rate
                    }
                    else
                    {
                        MessageBox.Show("Room details not found.");
                    }
                }
            }
        }

        private void LoadGuestDetails(int guestId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FirstName, LastName, Email, Address FROM Guests WHERE GuestID = @GuestID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guestId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string lastName = reader["LastName"].ToString();
                        txtGuestName.Text = $"{firstName} {lastName}";
                        txtEmail.Text = reader["Email"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Guest details not found.");
                    }
                }
            }
        }

        private void LoadReservations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bookings";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                lvReservations.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["BookingID"].ToString());
                    item.SubItems.Add(row["GuestID"].ToString());
                    item.SubItems.Add(row["RoomID"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["CheckInDate"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(Convert.ToDateTime(row["CheckOutDate"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(Convert.ToDecimal(row["TotalAmount"]).ToString("C2"));
                    item.SubItems.Add(row["Status"].ToString());
                    lvReservations.Items.Add(item);

                    // Update room status to 'Available' if reservation period has ended
                    DateTime checkOutDate = Convert.ToDateTime(row["CheckOutDate"]);
                    if (checkOutDate < DateTime.Now)
                    {
                        int roomId = Convert.ToInt32(row["RoomID"]);
                        UpdateRoomStatus(roomId, "Available");
                    }
                }
            }
        }

        private void SaveReservation()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query;
                if (isEditing)
                {
                    query = "UPDATE Bookings SET GuestID = @GuestID, RoomID = @RoomID, CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, TotalAmount = @TotalAmount, Status = @Status, UpdatedAt = GETDATE() WHERE BookingID = @BookingID";
                }
                else
                {
                    query = "INSERT INTO Bookings (GuestID, RoomID, CheckInDate, CheckOutDate, Status, TotalAmount) VALUES (@GuestID, @RoomID, @CheckInDate, @CheckOutDate, @Status, @TotalAmount)";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", int.Parse(txtGuestID.Text));
                command.Parameters.AddWithValue("@RoomID", int.Parse(txtRoomID.Text));
                command.Parameters.AddWithValue("@CheckInDate", dtpCheckInDate.Value);
                command.Parameters.AddWithValue("@CheckOutDate", dtpCheckOutDate.Value);
                command.Parameters.AddWithValue("@TotalAmount", decimal.Parse(txtTotalAmount.Text, NumberStyles.Currency));
                command.Parameters.AddWithValue("@Status", cmbStatus.Text);

                if (isEditing)
                {
                    command.Parameters.AddWithValue("@BookingID", int.Parse(txtBookingID.Text));
                }

                connection.Open();
                command.ExecuteNonQuery();                


                // Update room status based on reservation status
                string roomStatus = (cmbStatus.Text == "Pending") ? "Reserved" : "Available";
                UpdateRoomStatus(int.Parse(txtRoomID.Text), roomStatus);

                connection.Close();

                LoadReservations();
                ResetFields();
                isEditing = false; // Reset the editing flag after saving
                btnSaveReservation.Text = "Save";                
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

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
              
        public void SetGuestDetails(string guestId, string guestName, string email, string address)
        {
            txtGuestID.Text = guestId;
            txtGuestName.Text = guestName;
            txtEmail.Text = email;
            txtAddress.Text = address;
        }

        public void SetRoomDetails(string roomId, string roomNumber, string roomRate)
        {
            txtRoomID.Text = roomId;
            txtRoomNumber.Text = roomNumber;
            txtRoomRate.Text = roomRate;

            CalculateTotalAmount();
        }

        private void CalculateTotalAmount()
        {
            if (decimal.TryParse(txtRoomRate.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal roomRate))
            {
                TimeSpan duration = dtpCheckOutDate.Value.Date - dtpCheckInDate.Value.Date;
                decimal totalAmount = roomRate * (decimal)duration.TotalDays;
                txtTotalAmount.Text = totalAmount.ToString("C2", CultureInfo.CurrentCulture); // Formats as currency
            }
            else
            {
                txtTotalAmount.Text = "$0.00"; // Default value if formatting fails
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
            dtpCheckOutDate.Value = DateTime.Now;
            txtTotalAmount.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
            txtGuestName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;

            isEditing = false; // Reset the editing flag
            btnSaveReservation.Text = "Save";            
        }
           

        private void txtRoomRate_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGetRoom_Click(object sender, EventArgs e)
        {
            SelectRoom selectRoomForm = new SelectRoom();
            selectRoomForm.Owner = this;
            selectRoomForm.ShowDialog();
        }

        private void btnGetGuest_Click_1(object sender, EventArgs e)
        {
            SelectGuest selectGuestForm = new SelectGuest();
            selectGuestForm.Owner = this;
            selectGuestForm.ShowDialog();
        }

        private void lvReservations_DoubleClick_1(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvReservations.SelectedItems[0];
                txtBookingID.Text = selectedItem.Text;
                txtGuestID.Text = selectedItem.SubItems[1].Text;
                txtRoomID.Text = selectedItem.SubItems[2].Text;
                dtpCheckInDate.Value = Convert.ToDateTime(selectedItem.SubItems[3].Text);
                dtpCheckOutDate.Value = Convert.ToDateTime(selectedItem.SubItems[4].Text);
                txtTotalAmount.Text = selectedItem.SubItems[5].Text;
                cmbStatus.Text = selectedItem.SubItems[6].Text;

                isEditing = true; // Set the editing flag to true
                btnSaveReservation.Text = "Edit";                
                tabControl.SelectedTab = reservationsTabPage;

                // Load Room details for the selected RoomID
                LoadRoomDetails(txtRoomID.Text);

                // Load Guest details for the selected GuestID
                LoadGuestDetails(int.Parse(txtGuestID.Text));
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Bookings WHERE GuestID LIKE @Search OR RoomID LIKE @Search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", $"%{txtSearch.Text}%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                lvReservations.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["BookingID"].ToString());
                    item.SubItems.Add(row["GuestID"].ToString());
                    item.SubItems.Add(row["RoomID"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(row["CheckInDate"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(Convert.ToDateTime(row["CheckOutDate"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(row["TotalAmount"].ToString());
                    item.SubItems.Add(row["Status"].ToString());
                    lvReservations.Items.Add(item);
                }
            }
        }

        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lvReservations.SelectedItems[0];
            int reservationId = int.Parse(item.SubItems[0].Text);
            int roomId = int.Parse(item.SubItems[2].Text); // Assuming RoomID is the third column

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string deleteReservationQuery = "DELETE FROM Bookings WHERE BookingID = @BookingID";
                string updateRoomStatusQuery = "UPDATE Rooms SET Status = 'Available' WHERE RoomID = @RoomID";

                connection.Open();

                SqlCommand deleteReservationCommand = new SqlCommand(deleteReservationQuery, connection);
                deleteReservationCommand.Parameters.AddWithValue("@BookingID", reservationId);
                deleteReservationCommand.ExecuteNonQuery();

                SqlCommand updateRoomStatusCommand = new SqlCommand(updateRoomStatusQuery, connection);
                updateRoomStatusCommand.Parameters.AddWithValue("@RoomID", roomId);
                updateRoomStatusCommand.ExecuteNonQuery();

                MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

                LoadReservations();
                ResetFields();
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void cmbSort_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSaveReservation_Click_1(object sender, EventArgs e)
        {
            SaveReservation();

            LoadReservations();
            ResetFields();
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
