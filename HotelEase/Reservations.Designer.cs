namespace HotelEase
{
    partial class Reservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.reservationsTabPage = new System.Windows.Forms.TabPage();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveReservation = new Guna.UI2.WinForms.Guna2Button();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpCheckOutDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnGetGuest = new Guna.UI2.WinForms.Guna2Button();
            this.btnGetRoomNumber = new Guna.UI2.WinForms.Guna2Button();
            this.txtBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGuestID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGuestName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.resevationListTabPage = new System.Windows.Forms.TabPage();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvReservations = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.reservationsTabPage.SuspendLayout();
            this.resevationListTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.reservationsTabPage);
            this.tabControl.Controls.Add(this.resevationListTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(955, 552);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl.TabIndex = 3;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // reservationsTabPage
            // 
            this.reservationsTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reservationsTabPage.Controls.Add(this.btnClose);
            this.reservationsTabPage.Controls.Add(this.btnReset);
            this.reservationsTabPage.Controls.Add(this.btnDeleteReservation);
            this.reservationsTabPage.Controls.Add(this.btnSaveReservation);
            this.reservationsTabPage.Controls.Add(this.cmbStatus);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel9);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel6);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel5);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel13);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel12);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel11);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel10);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel2);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel3);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel8);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel7);
            this.reservationsTabPage.Controls.Add(this.guna2HtmlLabel1);
            this.reservationsTabPage.Controls.Add(this.dtpCheckOutDate);
            this.reservationsTabPage.Controls.Add(this.dtpCheckInDate);
            this.reservationsTabPage.Controls.Add(this.btnGetGuest);
            this.reservationsTabPage.Controls.Add(this.btnGetRoomNumber);
            this.reservationsTabPage.Controls.Add(this.txtBookingID);
            this.reservationsTabPage.Controls.Add(this.txtRoomRate);
            this.reservationsTabPage.Controls.Add(this.txtRoomID);
            this.reservationsTabPage.Controls.Add(this.txtGuestID);
            this.reservationsTabPage.Controls.Add(this.txtTotalAmount);
            this.reservationsTabPage.Controls.Add(this.txtAddress);
            this.reservationsTabPage.Controls.Add(this.txtEmail);
            this.reservationsTabPage.Controls.Add(this.txtGuestName);
            this.reservationsTabPage.Controls.Add(this.txtRoomNumber);
            this.reservationsTabPage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsTabPage.Location = new System.Drawing.Point(184, 4);
            this.reservationsTabPage.Name = "reservationsTabPage";
            this.reservationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationsTabPage.Size = new System.Drawing.Size(767, 544);
            this.reservationsTabPage.TabIndex = 0;
            this.reservationsTabPage.Text = "Manage Reservations";
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(5, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(41, 45);
            this.btnClose.TabIndex = 17;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.BorderRadius = 8;
            this.btnReset.DefaultAutoSize = true;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.IndicateFocus = true;
            this.btnReset.Location = new System.Drawing.Point(645, 500);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 27);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "&Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnDeleteReservation
            // 
            this.btnDeleteReservation.Animated = true;
            this.btnDeleteReservation.BorderRadius = 8;
            this.btnDeleteReservation.DefaultAutoSize = true;
            this.btnDeleteReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnDeleteReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteReservation.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReservation.IndicateFocus = true;
            this.btnDeleteReservation.Location = new System.Drawing.Point(551, 500);
            this.btnDeleteReservation.Name = "btnDeleteReservation";
            this.btnDeleteReservation.Size = new System.Drawing.Size(75, 27);
            this.btnDeleteReservation.TabIndex = 16;
            this.btnDeleteReservation.Text = "&Cancel";
            this.btnDeleteReservation.Click += new System.EventHandler(this.btnDeleteReservation_Click);
            // 
            // btnSaveReservation
            // 
            this.btnSaveReservation.Animated = true;
            this.btnSaveReservation.BorderRadius = 8;
            this.btnSaveReservation.DefaultAutoSize = true;
            this.btnSaveReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(64)))));
            this.btnSaveReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveReservation.ForeColor = System.Drawing.Color.White;
            this.btnSaveReservation.IndicateFocus = true;
            this.btnSaveReservation.Location = new System.Drawing.Point(471, 500);
            this.btnSaveReservation.Name = "btnSaveReservation";
            this.btnSaveReservation.Size = new System.Drawing.Size(65, 27);
            this.btnSaveReservation.TabIndex = 16;
            this.btnSaveReservation.Text = "&Save";
            this.btnSaveReservation.Click += new System.EventHandler(this.btnSaveReservation_Click_1);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 10;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Location = new System.Drawing.Point(428, 444);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(295, 36);
            this.cmbStatus.TabIndex = 15;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(64, 187);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(50, 15);
            this.guna2HtmlLabel9.TabIndex = 14;
            this.guna2HtmlLabel9.Text = "Room Id:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(64, 115);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel6.TabIndex = 14;
            this.guna2HtmlLabel6.Text = "Guest Id:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(64, 51);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(62, 15);
            this.guna2HtmlLabel5.TabIndex = 14;
            this.guna2HtmlLabel5.Text = "Booking Id:";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(435, 345);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel13.TabIndex = 14;
            this.guna2HtmlLabel13.Text = "Total Amount:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(435, 265);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(47, 15);
            this.guna2HtmlLabel12.TabIndex = 14;
            this.guna2HtmlLabel12.Text = "Address:";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(435, 187);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(34, 15);
            this.guna2HtmlLabel11.TabIndex = 14;
            this.guna2HtmlLabel11.Text = "Email:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(435, 115);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(76, 15);
            this.guna2HtmlLabel10.TabIndex = 14;
            this.guna2HtmlLabel10.Text = "Guest Name: *";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(435, 51);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(84, 15);
            this.guna2HtmlLabel2.TabIndex = 14;
            this.guna2HtmlLabel2.Text = "Check Out Date:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(435, 427);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(37, 15);
            this.guna2HtmlLabel3.TabIndex = 14;
            this.guna2HtmlLabel3.Text = "Status:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(64, 265);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(81, 15);
            this.guna2HtmlLabel8.TabIndex = 14;
            this.guna2HtmlLabel8.Text = "Room Number:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(65, 345);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(63, 15);
            this.guna2HtmlLabel7.TabIndex = 14;
            this.guna2HtmlLabel7.Text = "Room Rate:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(65, 427);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(75, 15);
            this.guna2HtmlLabel1.TabIndex = 14;
            this.guna2HtmlLabel1.Text = "Check In Date:";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Animated = true;
            this.dtpCheckOutDate.BorderRadius = 10;
            this.dtpCheckOutDate.Checked = true;
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(425, 73);
            this.dtpCheckOutDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckOutDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(295, 36);
            this.dtpCheckOutDate.TabIndex = 13;
            this.dtpCheckOutDate.Value = new System.DateTime(2024, 8, 5, 16, 5, 27, 88);
            this.dtpCheckOutDate.ValueChanged += new System.EventHandler(this.dtpCheckOutDate_ValueChanged);
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Animated = true;
            this.dtpCheckInDate.BorderRadius = 10;
            this.dtpCheckInDate.Checked = true;
            this.dtpCheckInDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckInDate.Location = new System.Drawing.Point(59, 448);
            this.dtpCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(295, 36);
            this.dtpCheckInDate.TabIndex = 13;
            this.dtpCheckInDate.Value = new System.DateTime(2024, 8, 5, 16, 5, 27, 88);
            this.dtpCheckInDate.ValueChanged += new System.EventHandler(this.dtpCheckInDate_ValueChanged);
            // 
            // btnGetGuest
            // 
            this.btnGetGuest.Animated = true;
            this.btnGetGuest.BackColor = System.Drawing.Color.Transparent;
            this.btnGetGuest.BorderRadius = 5;
            this.btnGetGuest.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetGuest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetGuest.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGetGuest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetGuest.ForeColor = System.Drawing.Color.White;
            this.btnGetGuest.Image = global::HotelEase.Properties.Resources.upload_16;
            this.btnGetGuest.IndicateFocus = true;
            this.btnGetGuest.Location = new System.Drawing.Point(725, 142);
            this.btnGetGuest.Name = "btnGetGuest";
            this.btnGetGuest.Size = new System.Drawing.Size(33, 21);
            this.btnGetGuest.TabIndex = 11;
            this.btnGetGuest.Click += new System.EventHandler(this.btnGetGuest_Click_1);
            // 
            // btnGetRoomNumber
            // 
            this.btnGetRoomNumber.Animated = true;
            this.btnGetRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.btnGetRoomNumber.BorderRadius = 5;
            this.btnGetRoomNumber.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGetRoomNumber.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGetRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGetRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGetRoomNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGetRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGetRoomNumber.ForeColor = System.Drawing.Color.White;
            this.btnGetRoomNumber.Image = global::HotelEase.Properties.Resources.upload_16;
            this.btnGetRoomNumber.IndicateFocus = true;
            this.btnGetRoomNumber.Location = new System.Drawing.Point(357, 295);
            this.btnGetRoomNumber.Name = "btnGetRoomNumber";
            this.btnGetRoomNumber.Size = new System.Drawing.Size(33, 21);
            this.btnGetRoomNumber.TabIndex = 11;
            this.btnGetRoomNumber.Click += new System.EventHandler(this.btnGetRoom_Click);
            // 
            // txtBookingID
            // 
            this.txtBookingID.Animated = true;
            this.txtBookingID.BorderRadius = 10;
            this.txtBookingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingID.DefaultText = "";
            this.txtBookingID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingID.Enabled = false;
            this.txtBookingID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookingID.ForeColor = System.Drawing.Color.Black;
            this.txtBookingID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.Location = new System.Drawing.Point(57, 73);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.PlaceholderText = "Auto-generated";
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(295, 36);
            this.txtBookingID.TabIndex = 12;
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Animated = true;
            this.txtRoomRate.BorderRadius = 10;
            this.txtRoomRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomRate.DefaultText = "";
            this.txtRoomRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomRate.Enabled = false;
            this.txtRoomRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomRate.ForeColor = System.Drawing.Color.Black;
            this.txtRoomRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomRate.Location = new System.Drawing.Point(59, 366);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.PasswordChar = '\0';
            this.txtRoomRate.PlaceholderText = "Filled Automatically";
            this.txtRoomRate.SelectedText = "";
            this.txtRoomRate.Size = new System.Drawing.Size(295, 36);
            this.txtRoomRate.TabIndex = 12;
            // 
            // txtRoomID
            // 
            this.txtRoomID.Animated = true;
            this.txtRoomID.BorderRadius = 10;
            this.txtRoomID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomID.DefaultText = "";
            this.txtRoomID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomID.Enabled = false;
            this.txtRoomID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomID.ForeColor = System.Drawing.Color.Black;
            this.txtRoomID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomID.Location = new System.Drawing.Point(57, 208);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.PasswordChar = '\0';
            this.txtRoomID.PlaceholderText = "Filled Automatically";
            this.txtRoomID.SelectedText = "";
            this.txtRoomID.Size = new System.Drawing.Size(295, 36);
            this.txtRoomID.TabIndex = 12;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Animated = true;
            this.txtGuestID.BorderRadius = 10;
            this.txtGuestID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuestID.DefaultText = "";
            this.txtGuestID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGuestID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuestID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestID.Enabled = false;
            this.txtGuestID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuestID.ForeColor = System.Drawing.Color.Black;
            this.txtGuestID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestID.Location = new System.Drawing.Point(57, 136);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.PasswordChar = '\0';
            this.txtGuestID.PlaceholderText = "Filled Automatically";
            this.txtGuestID.SelectedText = "";
            this.txtGuestID.Size = new System.Drawing.Size(295, 36);
            this.txtGuestID.TabIndex = 12;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Animated = true;
            this.txtTotalAmount.BorderRadius = 10;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.DefaultText = "";
            this.txtTotalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalAmount.Enabled = false;
            this.txtTotalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.txtTotalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(428, 366);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.PlaceholderText = "Automatically Calculated ";
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(295, 36);
            this.txtTotalAmount.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.Enabled = false;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(428, 286);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Filled Automatically";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(295, 36);
            this.txtAddress.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.Enabled = false;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(428, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Filled Automatically";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(295, 36);
            this.txtEmail.TabIndex = 12;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Animated = true;
            this.txtGuestName.BorderRadius = 10;
            this.txtGuestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuestName.DefaultText = "";
            this.txtGuestName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGuestName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGuestName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGuestName.Enabled = false;
            this.txtGuestName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuestName.ForeColor = System.Drawing.Color.Black;
            this.txtGuestName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGuestName.Location = new System.Drawing.Point(425, 136);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.PasswordChar = '\0';
            this.txtGuestName.PlaceholderText = "Upload Guest Name";
            this.txtGuestName.SelectedText = "";
            this.txtGuestName.Size = new System.Drawing.Size(295, 36);
            this.txtGuestName.TabIndex = 12;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Animated = true;
            this.txtRoomNumber.BorderRadius = 10;
            this.txtRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNumber.DefaultText = "";
            this.txtRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Black;
            this.txtRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNumber.Location = new System.Drawing.Point(57, 286);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.PasswordChar = '\0';
            this.txtRoomNumber.PlaceholderText = "Upload Room Number";
            this.txtRoomNumber.SelectedText = "";
            this.txtRoomNumber.Size = new System.Drawing.Size(295, 36);
            this.txtRoomNumber.TabIndex = 12;
            // 
            // resevationListTabPage
            // 
            this.resevationListTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resevationListTabPage.Controls.Add(this.guna2HtmlLabel4);
            this.resevationListTabPage.Controls.Add(this.cmbSort);
            this.resevationListTabPage.Controls.Add(this.txtSearch);
            this.resevationListTabPage.Controls.Add(this.label2);
            this.resevationListTabPage.Controls.Add(this.lvReservations);
            this.resevationListTabPage.Location = new System.Drawing.Point(184, 4);
            this.resevationListTabPage.Name = "resevationListTabPage";
            this.resevationListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resevationListTabPage.Size = new System.Drawing.Size(748, 544);
            this.resevationListTabPage.TabIndex = 1;
            this.resevationListTabPage.Text = "Reservation List";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(627, 19);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(36, 15);
            this.guna2HtmlLabel4.TabIndex = 25;
            this.guna2HtmlLabel4.Text = "Sort by";
            // 
            // cmbSort
            // 
            this.cmbSort.AutoRoundedCorners = true;
            this.cmbSort.BackColor = System.Drawing.Color.Transparent;
            this.cmbSort.BorderRadius = 17;
            this.cmbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSort.ItemHeight = 30;
            this.cmbSort.Location = new System.Drawing.Point(627, 40);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(141, 36);
            this.cmbSort.TabIndex = 24;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 17;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(236, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Reservation";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(295, 36);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // label2
            // 
            this.label2.Image = global::HotelEase.Properties.Resources.search_32;
            this.label2.Location = new System.Drawing.Point(203, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 30);
            this.label2.TabIndex = 19;
            // 
            // lvReservations
            // 
            this.lvReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvReservations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvReservations.FullRowSelect = true;
            this.lvReservations.GridLines = true;
            this.lvReservations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(3, 103);
            this.lvReservations.MultiSelect = false;
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(742, 438);
            this.lvReservations.TabIndex = 22;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            this.lvReservations.View = System.Windows.Forms.View.Details;
            this.lvReservations.DoubleClick += new System.EventHandler(this.lvReservations_DoubleClick_1);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 552);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation Window";
            this.tabControl.ResumeLayout(false);
            this.reservationsTabPage.ResumeLayout(false);
            this.reservationsTabPage.PerformLayout();
            this.resevationListTabPage.ResumeLayout(false);
            this.resevationListTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage reservationsTabPage;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnDeleteReservation;
        private Guna.UI2.WinForms.Guna2Button btnSaveReservation;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckOutDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckInDate;
        private Guna.UI2.WinForms.Guna2Button btnGetGuest;
        private Guna.UI2.WinForms.Guna2Button btnGetRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingID;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomRate;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomID;
        private Guna.UI2.WinForms.Guna2TextBox txtGuestID;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtGuestName;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNumber;
        private System.Windows.Forms.TabPage resevationListTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvReservations;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
    }
}