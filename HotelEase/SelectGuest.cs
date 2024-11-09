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
    public partial class SelectGuest : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public SelectGuest()
        {
            InitializeComponent();
            LoadGuests();
            InitializeListView();
        }

        // Initialize the ListView columns
        private void InitializeListView()
        {
            lvGuests.Columns.Clear();
            lvGuests.Columns.Add("Guest ID", 100);
            lvGuests.Columns.Add("Guest Name", 250);            
            lvGuests.Columns.Add("Email", 300);            
            lvGuests.Columns.Add("Address", 255);            

            // Optionally set ListView view
            lvGuests.View = View.Details;
        }

        private void LoadGuests()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Guests";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                lvGuests.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["GuestID"].ToString());
                    item.SubItems.Add($"{row["FirstName"]} {row["LastName"]}");
                    item.SubItems.Add(row["Email"].ToString());
                    item.SubItems.Add(row["Address"].ToString());
                    lvGuests.Items.Add(item);
                }
            }
        }

        private void lvGuests_DoubleClick(object sender, EventArgs e)
        {
            if (lvGuests.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvGuests.SelectedItems[0];
                string guestId = selectedItem.Text;
                string guestName = selectedItem.SubItems[1].Text;
                string email = selectedItem.SubItems[2].Text;
                string address = selectedItem.SubItems[3].Text;

                // Pass data back to Reservations form
                Reservations reservationsForm = (Reservations)this.Owner;
                reservationsForm.SetGuestDetails(guestId, guestName, email, address);

                this.Close();
            }
        }
    }
}
