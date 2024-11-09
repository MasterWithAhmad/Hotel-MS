using Guna.UI2.WinForms;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace HotelEase
{
    public partial class Reports : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public Reports()
        {
            InitializeComponent();
            LoadPaymentsPieChart();
            LoadRoomsPieChart();
            //LoadRoomsCartesianChart();
            LoadPaymentsDataGridView();
            LoadTablesCountCartesianChart();

        }

        private void LoadTablesCountCartesianChart()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Prepare queries to get the total count for each table
                string queryBookingsCount = "SELECT COUNT(*) AS TotalBookings FROM Bookings";
                string queryGuestsCount = "SELECT COUNT(*) AS TotalGuests FROM Guests";
                string queryPaymentsCount = "SELECT COUNT(*) AS TotalPayments FROM Payments";
                string queryRoomsCount = "SELECT COUNT(*) AS TotalRooms FROM Rooms";

                // Initialize chart values
                var values = new ChartValues<int>();

                // Execute queries and add the results to the chart
                values.Add(GetTableCount(conn, queryBookingsCount, "TotalBookings"));
                values.Add(GetTableCount(conn, queryGuestsCount, "TotalGuests"));
                values.Add(GetTableCount(conn, queryPaymentsCount, "TotalPayments"));
                values.Add(GetTableCount(conn, queryRoomsCount, "TotalRooms"));

                cartesianChart.Series.Clear();
                cartesianChart.Series.Add(new ColumnSeries
                {
                    Title = "Total Records",
                    Values = values
                });

                cartesianChart.AxisX.Add(new Axis
                {
                    Title = "Tables",
                    Labels = new[] { "Bookings", "Guests", "Payments", "Rooms" }
                });

                cartesianChart.AxisY.Add(new Axis
                {
                    Title = "Count",
                    LabelFormatter = value => value.ToString("N0")
                });
            }
        }

        // Helper method to execute a query and return the count
        private int GetTableCount(SqlConnection conn, string query, string columnName)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            return (int)cmd.ExecuteScalar();
        }

        private void LoadPaymentsPieChart()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PaymentMethod, COUNT(*) AS PaymentCount FROM Payments GROUP BY PaymentMethod";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    paymentsPieChart.Series.Add(new PieSeries
                    {
                        Title = reader["PaymentMethod"].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(reader["PaymentCount"]) }
                    });
                }
            }
        }

        private void LoadRoomsPieChart()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Status, COUNT(*) AS RoomCount FROM Rooms GROUP BY Status";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    roomsPieChart.Series.Add(new PieSeries
                    {
                        Title = reader["Status"].ToString(),
                        Values = new ChartValues<int> { Convert.ToInt32(reader["RoomCount"]) }
                    });
                }
            }
        }

        private void LoadRoomsCartesianChart()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Type, AVG(Rate) AS AverageRate FROM Rooms GROUP BY Type";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cartesianChart.Series.Add(new ColumnSeries
                    {
                        Title = reader["Type"].ToString(),
                        Values = new ChartValues<decimal> { Convert.ToDecimal(reader["AverageRate"]) }
                    });
                }
            }
        }

        private void LoadPaymentsDataGridView()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT g.FirstName + ' ' + g.LastName AS GuestName, p.PaymentDate, p.Amount, p.PaymentMethod, p.Status FROM Payments p INNER JOIN Bookings b ON p.BookingID = b.BookingID INNER JOIN Guests g ON b.GuestID = g.GuestID";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPayments.DataSource = dt;
            }
        }
     
        private void dgvPayments_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvPayments.Columns[e.ColumnIndex].Name == "Status") // Ensure this matches the actual column name
            {
                string status = e.Value.ToString();

                if (status == "Failed")
                {
                    e.CellStyle.ForeColor = Color.Red;
                    //e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "Pending")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                   // e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "Completed")
                {
                    e.CellStyle.ForeColor = Color.Green;
                    //e.CellStyle.ForeColor = Color.White;
                }
            }
            // Format the Amount column with a dollar sign
            if (dgvPayments.Columns[e.ColumnIndex].Name == "Amount" && e.Value != null)
            {
                e.CellStyle.Format = "C2"; // "C2" formats the number as currency with 2 decimal places
            }
        }
    }
}
