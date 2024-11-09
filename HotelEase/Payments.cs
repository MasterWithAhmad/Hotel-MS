using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelEase
{
    public partial class Payments : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        public Payments()
        {
            InitializeComponent();
            InitializeListView();
            LoadPayments();
        }

        private void InitializeListView()
        {
            lvPayments.View = View.Details;
            lvPayments.Columns.Add("Payment ID", 100, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Booking ID", 100, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Guest Name", 150, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Email", 200, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Room Number", 100, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Room Rate", 100, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Amount", 100, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Payment Date", 150, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Payment Method", 150, HorizontalAlignment.Left);
            lvPayments.Columns.Add("Status", 100, HorizontalAlignment.Left);
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

        private string GetGuestAddress(int guestId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Address FROM Guests WHERE GuestID = @GuestID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GuestID", guestId);

                connection.Open();
                string address = command.ExecuteScalar().ToString();
                connection.Close();

                return address;
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

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 10f;
            float leftMargin = e.MarginBounds.Top;
            Font printFont = new Font("Arial", 10);

            e.Graphics.DrawString("Invoice", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, leftMargin, yPos);
            yPos += 40;

            //e.Graphics.DrawString("Payment ID: " + txtPaymentID.Text, printFont, Brushes.Black, leftMargin, yPos);
            //yPos += 20;
            //e.Graphics.DrawString("Booking ID: " + txtBookingID.Text, printFont, Brushes.Black, leftMargin, yPos);
            //yPos += 20;
            e.Graphics.DrawString("Guest Name: " + txtGuestName.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Email: " + txtEmail.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Address: " + txtAddress.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Room Number: " + txtRoomNumber.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Room Rate: " + txtRoomRate.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Payment Date: " + dtpPaymentDate.Value.ToString("d"), printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Payment Method: " + cmbPaymentMethod.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Status: " + cmbStatus.Text, printFont, Brushes.Black, leftMargin, yPos);
            yPos += 20;
            e.Graphics.DrawString("Amount: " + txtAmount.Text, printFont, Brushes.Black, leftMargin, yPos);
        }
        
        private void ResetFields()
        {
            txtPaymentID.Clear();
            txtBookingID.Clear();
            txtGuestID.Clear();
            txtRoomID.Clear();
            txtRoomNumber.Clear();
            txtRoomRate.Clear();
            txtGuestName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtAmount.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
            cmbPaymentMethod.SelectedIndex = -1;
        }

        private void SaveNewPayment()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Payments (BookingID, Amount, PaymentDate, PaymentMethod, Status) VALUES (@BookingID, @Amount, @PaymentDate, @PaymentMethod, @Status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookingID", int.Parse(txtBookingID.Text));
                command.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text.Trim('$')));
                command.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value);
                command.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                command.Parameters.AddWithValue("@Status", cmbStatus.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void UpdatePayment()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Payments SET BookingID = @BookingID, Amount = @Amount, PaymentDate = @PaymentDate, PaymentMethod = @PaymentMethod, Status = @Status WHERE PaymentID = @PaymentID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookingID", int.Parse(txtBookingID.Text));
                command.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text.Trim('$')));
                command.Parameters.AddWithValue("@PaymentDate", dtpPaymentDate.Value);
                command.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.Text);
                command.Parameters.AddWithValue("@Status", cmbStatus.Text);
                command.Parameters.AddWithValue("@PaymentID", int.Parse(txtPaymentID.Text));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void lvPayments_DoubleClick(object sender, EventArgs e)
        {

        }             

       private void LoadPayments(string search = "", string sortBy = "")
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        string query = @"
            SELECT 
                Payments.PaymentID,
                Payments.BookingID,
                Payments.Amount,
                Payments.PaymentDate,
                Payments.PaymentMethod,
                Payments.Status,
                Guests.FirstName + ' ' + Guests.LastName AS GuestName,
                Guests.Email,
                Guests.Address,
                Rooms.RoomNumber,
                Rooms.Rate
            FROM Payments
            INNER JOIN Bookings ON Payments.BookingID = Bookings.BookingID
            INNER JOIN Guests ON Bookings.GuestID = Guests.GuestID
            INNER JOIN Rooms ON Bookings.RoomID = Rooms.RoomID";

        SqlCommand command = new SqlCommand(query, connection);

        connection.Open();
        SqlDataReader reader = command.ExecuteReader();

        lvPayments.Items.Clear();

        while (reader.Read())
        {
            ListViewItem item = new ListViewItem(reader["PaymentID"].ToString());
            item.SubItems.Add(reader["BookingID"].ToString());
            item.SubItems.Add(reader["GuestName"].ToString());
            item.SubItems.Add(reader["Email"].ToString());
            item.SubItems.Add(reader["RoomNumber"].ToString());
            item.SubItems.Add("$" + reader["Rate"].ToString());
            item.SubItems.Add("$" + reader["Amount"].ToString());
            item.SubItems.Add(Convert.ToDateTime(reader["PaymentDate"]).ToString("MM/dd/yyyy HH:mm"));
            item.SubItems.Add(reader["PaymentMethod"].ToString());
            item.SubItems.Add(reader["Status"].ToString());

            lvPayments.Items.Add(item);
        }

        reader.Close();
        connection.Close();
    }
}

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaymentID.Text))
            {
                SaveNewPayment();
            }
            else
            {
                UpdatePayment();
            }

            LoadPayments();
            ResetFields();
        }

        private void btnGetGuest_Click(object sender, EventArgs e)
        {
            GuestPayments guestPaymentsForm = new GuestPayments();
            if (guestPaymentsForm.ShowDialog() == DialogResult.OK)
            {
                ListViewItem selectedItem = guestPaymentsForm.lvCheckOuts.SelectedItems[0];
                txtBookingID.Text = selectedItem.SubItems[0].Text;
                txtGuestID.Text = selectedItem.SubItems[1].Text;
                txtRoomID.Text = selectedItem.SubItems[2].Text;
                dtpPaymentDate.Value = DateTime.Now;
                txtAmount.Text = selectedItem.SubItems[4].Text;

                txtGuestName.Text = GetGuestName(int.Parse(txtGuestID.Text));
                txtEmail.Text = GetGuestEmail(int.Parse(txtGuestID.Text));
                txtAddress.Text = GetGuestAddress(int.Parse(txtGuestID.Text));
                txtRoomNumber.Text = GetRoomNumber(int.Parse(txtRoomID.Text));
                txtRoomRate.Text = "$" + GetRoomRate(int.Parse(txtRoomID.Text));
                cmbStatus.Text = "Paid";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text);
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPayments(txtSearch.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
