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
    public partial class OccupiedRooms : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public OccupiedRooms()
        {
            InitializeComponent();
            InitializeListView();
            LoadOccupiedRooms();
        }

        private void InitializeListView()
        {
            lvOccupiedRooms.View = View.Details;
            lvOccupiedRooms.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            lvOccupiedRooms.Columns.Add("Guest ID", 150, HorizontalAlignment.Left);
            lvOccupiedRooms.Columns.Add("Room ID", 150, HorizontalAlignment.Left);
            lvOccupiedRooms.Columns.Add("Check In Date", 250, HorizontalAlignment.Left); 
            lvOccupiedRooms.Columns.Add("Status", 150, HorizontalAlignment.Left);
            lvOccupiedRooms.Columns.Add("Total Amount", 200, HorizontalAlignment.Left);
        }

        private void LoadOccupiedRooms()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID, GuestID, RoomID, CheckInDate, Status, TotalAmount FROM Bookings WHERE Status = 'Checked In'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["BookingID"].ToString());
                    item.SubItems.Add(reader["GuestID"].ToString());
                    item.SubItems.Add(reader["RoomID"].ToString());
                    item.SubItems.Add(reader["CheckInDate"].ToString());
                    item.SubItems.Add(reader["Status"].ToString());
                    item.SubItems.Add("$" + reader["TotalAmount"].ToString());
                    lvOccupiedRooms.Items.Add(item);
                }

                reader.Close();
                connection.Close();
            }
        }

        private void lvOccupiedRooms_DoubleClick(object sender, EventArgs e)
        {
            if (lvOccupiedRooms.SelectedItems.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
