namespace HotelEase
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnReception = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReservation = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCheckin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCheckout = new System.Windows.Forms.ToolStripButton();
            this.btnPayments = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRooms = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnStaff = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReports = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.hotel_management_dbDataSet1 = new HotelEase.Hotel_management_dbDataSet();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_management_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReception,
            this.toolStripSeparator1,
            this.btnReservation,
            this.toolStripSeparator2,
            this.btnCheckin,
            this.toolStripSeparator9,
            this.btnCheckout,
            this.btnPayments,
            this.toolStripSeparator3,
            this.btnRooms,
            this.toolStripSeparator4,
            this.btnStaff,
            this.toolStripSeparator5,
            this.btnReports,
            this.btnLogout,
            this.toolStripSeparator6,
            this.btnSettings,
            this.btnHelp});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1366, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip";
            // 
            // btnReception
            // 
            this.btnReception.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReception.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReception.Image = global::HotelEase.Properties.Resources.icons8_reception_32;
            this.btnReception.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReception.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReception.Name = "btnReception";
            this.btnReception.Size = new System.Drawing.Size(105, 36);
            this.btnReception.Text = "Reception";
            this.btnReception.Click += new System.EventHandler(this.btnReception_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnReservation
            // 
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = global::HotelEase.Properties.Resources.icons8_booking_32;
            this.btnReservation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(118, 36);
            this.btnReservation.Text = "Reservations";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnCheckin
            // 
            this.btnCheckin.ForeColor = System.Drawing.Color.White;
            this.btnCheckin.Image = global::HotelEase.Properties.Resources.icons8_traveler_32;
            this.btnCheckin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCheckin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(99, 36);
            this.btnCheckin.Text = "Check-Ins";
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 39);
            // 
            // btnCheckout
            // 
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::HotelEase.Properties.Resources.icons8_hotel_check_out_321;
            this.btnCheckout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCheckout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(110, 36);
            this.btnCheckout.Text = "Check-Outs";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Image = global::HotelEase.Properties.Resources.icons8_payroll_32;
            this.btnPayments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPayments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(99, 36);
            this.btnPayments.Text = "Payments";
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // btnRooms
            // 
            this.btnRooms.ForeColor = System.Drawing.Color.White;
            this.btnRooms.Image = global::HotelEase.Properties.Resources.icons8_room_32;
            this.btnRooms.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRooms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(85, 36);
            this.btnRooms.Text = "Rooms";
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // btnStaff
            // 
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::HotelEase.Properties.Resources.icons8_staff_32;
            this.btnStaff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStaff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(70, 36);
            this.btnStaff.Text = "Staff";
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // btnReports
            // 
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(90, 36);
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::HotelEase.Properties.Resources.icons8_logout_rounded_left_32;
            this.btnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 36);
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // btnSettings
            // 
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::HotelEase.Properties.Resources.icons8_settings_322;
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(90, 36);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::HotelEase.Properties.Resources.icons8_help_32;
            this.btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(71, 36);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(1233, 39);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(133, 10);
            this.lblWelcome.TabIndex = 0;
            // 
            // hotel_management_dbDataSet1
            // 
            this.hotel_management_dbDataSet1.DataSetName = "Hotel_management_dbDataSet";
            this.hotel_management_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_management_dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnReception;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReservation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPayments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRooms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnStaff;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnCheckin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btnCheckout;
        private Hotel_management_dbDataSet hotel_management_dbDataSet1;
        private System.Windows.Forms.ToolStripButton btnReports;
    }
}