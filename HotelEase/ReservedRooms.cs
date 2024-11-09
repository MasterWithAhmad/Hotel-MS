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
    public partial class ReservedRooms : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";        
        public ReservedRooms()
        {
            InitializeComponent();
            LoadReservations();
            InitializeListView();
        }


        private void InitializeListView()
        {
            lvReservations.View = View.Details;
            lvReservations.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Guest ID", 150, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Room ID", 150, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Check In Date", 200, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Check Out Date", 200, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Total Amount", 150, HorizontalAlignment.Left);
            lvReservations.Columns.Add("Status", 200, HorizontalAlignment.Left);
        }

        private void LoadReservations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID, GuestID, RoomID, CheckInDate, CheckOutDate, Status, TotalAmount FROM Bookings";
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
                    item.SubItems.Add(Convert.ToDecimal(reader["TotalAmount"]).ToString("C2"));
                    item.SubItems.Add(reader["Status"].ToString());
                    lvReservations.Items.Add(item);
                }

                reader.Close();
                connection.Close();
            }
        }


        private void ReservedRooms_Load(object sender, EventArgs e)
        {

        }

        private void lvReservations_DoubleClick(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
