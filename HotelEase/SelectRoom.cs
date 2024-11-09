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
    public partial class SelectRoom : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public SelectRoom()
        {
            InitializeComponent();
            LoadRooms();
            InitializeListView();
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

        private void LoadRooms()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Rooms";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                lvRooms.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["RoomID"].ToString());
                    item.SubItems.Add(row["RoomNumber"].ToString());
                    item.SubItems.Add(row["Type"].ToString());
                    item.SubItems.Add(row["Rate"].ToString());
                    item.SubItems.Add(row["Status"].ToString());
                    item.SubItems.Add(row["Description"].ToString());
                    lvRooms.Items.Add(item);
                }
            }
        }

        private void lvRooms_DoubleClick(object sender, EventArgs e)
        {
            if (lvRooms.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvRooms.SelectedItems[0];
                string roomId = selectedItem.Text;
                string roomNumber = selectedItem.SubItems[1].Text;
                string roomRate = selectedItem.SubItems[3].Text;

                // Pass data back to Reservations form
                Reservations reservationsForm = (Reservations)this.Owner;
                reservationsForm.SetRoomDetails(roomId, roomNumber, roomRate);

                this.Close();
            }
        }
    }
}
