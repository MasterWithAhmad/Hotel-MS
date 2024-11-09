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
    public partial class GuestPayments : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public GuestPayments()
        {
            InitializeComponent();
            LoadCheckOuts();
            InitializeListView();
        }

        private void InitializeListView()
        {
            lvCheckOuts.View = View.Details;
            lvCheckOuts.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Guest ID", 150, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Room ID", 150, HorizontalAlignment.Left);
            //lvCheckOuts.Columns.Add("Check In Date", 250, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Check Out Date", 250, HorizontalAlignment.Left);
            lvCheckOuts.Columns.Add("Total Amount", 200, HorizontalAlignment.Left);
            //lvCheckOuts.Columns.Add("Status", 150, HorizontalAlignment.Left);
        }

        private void LoadCheckOuts()
        {
            lvCheckOuts.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookingID, GuestID, RoomID, CheckOutDate, TotalAmount FROM Bookings WHERE Status = 'Checked Out'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["BookingID"].ToString());
                    item.SubItems.Add(reader["GuestID"].ToString());
                    item.SubItems.Add(reader["RoomID"].ToString());
                    item.SubItems.Add(reader["CheckOutDate"].ToString());
                    item.SubItems.Add("$" + reader["TotalAmount"].ToString());
                    lvCheckOuts.Items.Add(item);
                }

                reader.Close();
                connection.Close();
            }
        }


        private void lvCheckOuts_DoubleClick(object sender, EventArgs e)
        {
            if (lvCheckOuts.SelectedItems.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
