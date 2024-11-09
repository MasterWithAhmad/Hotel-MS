using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using LiveCharts;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using LiveCharts.Wpf;
using SeriesCollection = LiveCharts.SeriesCollection;
using Axis = LiveCharts.Wpf.Axis;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelEase
{
    public partial class Dashboard : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Hotel_management_db;Integrated Security=True;Encrypt=False";
        private string userRole;
        private TabPage tabPagePieChart;
        private TabPage tabPageCartesianChart;
        public Dashboard(string firstName, string lastName, string role)
        {
            InitializeComponent();          
            this.IsMdiContainer = true;

            lblWelcome.Text = $"Welcome, {firstName} {lastName}";
            userRole = role;

            RestrictAccessBasedOnRole();


        }       
        private void OpenNewForm(Form newForm)
        {
        
            // Open the new form
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the TabControl when the new form is closed
           
        }

    

        private void RestrictAccessBasedOnRole()
        {
            if (userRole == "Manager")
            {
                // Allow access to all features
            }
            else if (userRole == "Receptionist")
            {
                btnStaff.Enabled = false;
                btnSettings.Enabled = false;
                btnPayments.Enabled = false;
            }
            else if (userRole == "Cleaner")
            {
                btnStaff.Enabled = false;
                btnSettings.Enabled = false;
                btnPayments.Enabled = false;
                btnReservation.Enabled = false;
                btnReception.Enabled = false;
            }
            // Add more roles and restrictions as necessary
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.MdiParent = this;
            OpenNewForm(rooms);
        }

        private void btnReception_Click_1(object sender, EventArgs e)
        {
            Guests guest = new Guests();
            guest.MdiParent = this;
            OpenNewForm(guest);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            Reservations reservations = new Reservations();
            reservations.MdiParent = this;
            OpenNewForm(reservations);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Check_Ins check_in = new Check_Ins();
            check_in.MdiParent = this;
            OpenNewForm(check_in);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Check_Outs check_out = new Check_Outs();
            check_out.MdiParent = this;
            OpenNewForm(check_out);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.MdiParent = this;
            OpenNewForm(payments);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staffs staffs = new Staffs();
            staffs.MdiParent = this;
            OpenNewForm(staffs);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            //reports.MdiParent = this;

            //OpenNewForm(reports);
            reports.Show();
        }
    }
}


