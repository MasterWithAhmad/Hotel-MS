namespace HotelEase
{
    partial class Check_Ins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Ins));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.reservationsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.reseravtionListTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lvCheckIns = new System.Windows.Forms.ListView();
            this.txtBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGuestID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGuestName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpCheckInDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabControl.SuspendLayout();
            this.reservationsTabPage.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.reseravtionListTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.reservationsTabPage);
            this.tabControl.Controls.Add(this.reseravtionListTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(933, 504);
            this.tabControl.TabIndex = 2;
            // 
            // reservationsTabPage
            // 
            this.reservationsTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reservationsTabPage.Controls.Add(this.groupBox);
            this.reservationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.reservationsTabPage.Name = "reservationsTabPage";
            this.reservationsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reservationsTabPage.Size = new System.Drawing.Size(925, 478);
            this.reservationsTabPage.TabIndex = 0;
            this.reservationsTabPage.Text = "Manage Check-Ins";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.dtpCheckInDate);
            this.groupBox.Controls.Add(this.guna2HtmlLabel9);
            this.groupBox.Controls.Add(this.guna2HtmlLabel8);
            this.groupBox.Controls.Add(this.guna2HtmlLabel7);
            this.groupBox.Controls.Add(this.guna2HtmlLabel6);
            this.groupBox.Controls.Add(this.guna2HtmlLabel5);
            this.groupBox.Controls.Add(this.guna2HtmlLabel12);
            this.groupBox.Controls.Add(this.guna2HtmlLabel11);
            this.groupBox.Controls.Add(this.guna2HtmlLabel10);
            this.groupBox.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox.Controls.Add(this.guna2Button1);
            this.groupBox.Controls.Add(this.txtRoomRate);
            this.groupBox.Controls.Add(this.txtRoomNumber);
            this.groupBox.Controls.Add(this.txtRoomID);
            this.groupBox.Controls.Add(this.txtEmail);
            this.groupBox.Controls.Add(this.txtGuestName);
            this.groupBox.Controls.Add(this.txtGuestID);
            this.groupBox.Controls.Add(this.txtBookingID);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.lblTotalAmount);
            this.groupBox.Location = new System.Drawing.Point(24, 26);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(877, 435);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Check-In Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2Button3);
            this.groupBox1.Controls.Add(this.guna2Button2);
            this.groupBox1.Location = new System.Drawing.Point(466, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(468, 263);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(344, 41);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reseravtionListTabPage
            // 
            this.reseravtionListTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reseravtionListTabPage.Controls.Add(this.guna2HtmlLabel2);
            this.reseravtionListTabPage.Controls.Add(this.cmbSort);
            this.reseravtionListTabPage.Controls.Add(this.txtSearch);
            this.reseravtionListTabPage.Controls.Add(this.label2);
            this.reseravtionListTabPage.Controls.Add(this.lvCheckIns);
            this.reseravtionListTabPage.Location = new System.Drawing.Point(4, 22);
            this.reseravtionListTabPage.Name = "reseravtionListTabPage";
            this.reseravtionListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reseravtionListTabPage.Size = new System.Drawing.Size(925, 478);
            this.reseravtionListTabPage.TabIndex = 1;
            this.reseravtionListTabPage.Text = "Check-In List";
            // 
            // label2
            // 
            this.label2.Image = global::HotelEase.Properties.Resources.search_32;
            this.label2.Location = new System.Drawing.Point(283, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 30);
            this.label2.TabIndex = 4;
            // 
            // lvCheckIns
            // 
            this.lvCheckIns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCheckIns.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCheckIns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCheckIns.FullRowSelect = true;
            this.lvCheckIns.GridLines = true;
            this.lvCheckIns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCheckIns.HideSelection = false;
            this.lvCheckIns.Location = new System.Drawing.Point(3, 85);
            this.lvCheckIns.MultiSelect = false;
            this.lvCheckIns.Name = "lvCheckIns";
            this.lvCheckIns.Size = new System.Drawing.Size(919, 390);
            this.lvCheckIns.TabIndex = 12;
            this.lvCheckIns.UseCompatibleStateImageBehavior = false;
            this.lvCheckIns.View = System.Windows.Forms.View.Details;
            this.lvCheckIns.DoubleClick += new System.EventHandler(this.lvCheckIns_DoubleClick);
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
            this.txtBookingID.Location = new System.Drawing.Point(41, 56);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.PlaceholderText = "Filled Automatically";
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(332, 36);
            this.txtBookingID.TabIndex = 13;
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
            this.txtGuestID.Location = new System.Drawing.Point(41, 121);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.PasswordChar = '\0';
            this.txtGuestID.PlaceholderText = "Filled Automatically";
            this.txtGuestID.SelectedText = "";
            this.txtGuestID.Size = new System.Drawing.Size(332, 36);
            this.txtGuestID.TabIndex = 13;
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
            this.txtRoomID.Location = new System.Drawing.Point(41, 187);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.PasswordChar = '\0';
            this.txtRoomID.PlaceholderText = "Filled Automatically";
            this.txtRoomID.SelectedText = "";
            this.txtRoomID.Size = new System.Drawing.Size(332, 36);
            this.txtRoomID.TabIndex = 13;
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
            this.txtRoomNumber.Location = new System.Drawing.Point(41, 256);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.PasswordChar = '\0';
            this.txtRoomNumber.PlaceholderText = "Upload The Room Number";
            this.txtRoomNumber.SelectedText = "";
            this.txtRoomNumber.Size = new System.Drawing.Size(332, 38);
            this.txtRoomNumber.TabIndex = 13;
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
            this.txtRoomRate.Location = new System.Drawing.Point(41, 327);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.PasswordChar = '\0';
            this.txtRoomRate.PlaceholderText = "Filled Automatically";
            this.txtRoomRate.SelectedText = "";
            this.txtRoomRate.Size = new System.Drawing.Size(332, 36);
            this.txtRoomRate.TabIndex = 13;
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
            this.txtGuestName.Location = new System.Drawing.Point(466, 124);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.PasswordChar = '\0';
            this.txtGuestName.PlaceholderText = "Filled Automatically";
            this.txtGuestName.SelectedText = "";
            this.txtGuestName.Size = new System.Drawing.Size(344, 36);
            this.txtGuestName.TabIndex = 13;
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
            this.txtEmail.Location = new System.Drawing.Point(466, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Filled Automatically";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(344, 36);
            this.txtEmail.TabIndex = 13;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(379, 263);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(43, 25);
            this.guna2Button1.TabIndex = 14;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.DefaultAutoSize = true;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.IndicateFocus = true;
            this.guna2Button2.Location = new System.Drawing.Point(141, 20);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(69, 27);
            this.guna2Button2.TabIndex = 14;
            this.guna2Button2.Text = "&Reset";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 8;
            this.guna2Button3.DefaultAutoSize = true;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.IndicateFocus = true;
            this.guna2Button3.Location = new System.Drawing.Point(15, 18);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(88, 27);
            this.guna2Button3.TabIndex = 14;
            this.guna2Button3.Text = "&Check-In";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(41, 35);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 15);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "Booking ID:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(43, 306);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(71, 15);
            this.guna2HtmlLabel5.TabIndex = 15;
            this.guna2HtmlLabel5.Text = "Room Rate:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(468, 35);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(91, 15);
            this.guna2HtmlLabel6.TabIndex = 15;
            this.guna2HtmlLabel6.Text = "Check In Date:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(466, 103);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(78, 15);
            this.guna2HtmlLabel7.TabIndex = 15;
            this.guna2HtmlLabel7.Text = "Guest Name:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(466, 169);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(39, 15);
            this.guna2HtmlLabel8.TabIndex = 15;
            this.guna2HtmlLabel8.Text = "Email:";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(468, 239);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(84, 15);
            this.guna2HtmlLabel9.TabIndex = 15;
            this.guna2HtmlLabel9.Text = "Total Amount:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(41, 100);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel10.TabIndex = 15;
            this.guna2HtmlLabel10.Text = "Guest ID:";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(41, 166);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(48, 15);
            this.guna2HtmlLabel11.TabIndex = 15;
            this.guna2HtmlLabel11.Text = "Room ID:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(43, 235);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(81, 15);
            this.guna2HtmlLabel12.TabIndex = 15;
            this.guna2HtmlLabel12.Text = "Room Number: *";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.BorderRadius = 10;
            this.dtpCheckInDate.Checked = true;
            this.dtpCheckInDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckInDate.Location = new System.Drawing.Point(468, 56);
            this.dtpCheckInDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckInDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(332, 36);
            this.dtpCheckInDate.TabIndex = 16;
            this.dtpCheckInDate.Value = new System.DateTime(2024, 8, 26, 21, 56, 23, 241);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(321, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search by date or name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(313, 36);
            this.txtSearch.TabIndex = 13;
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.Color.Transparent;
            this.cmbSort.BorderRadius = 10;
            this.cmbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSort.ItemHeight = 30;
            this.cmbSort.Location = new System.Drawing.Point(760, 36);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(140, 36);
            this.cmbSort.TabIndex = 14;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(760, 15);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(45, 15);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Sort by";
            // 
            // Check_Ins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 504);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check_Ins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-Ins Window";
            this.tabControl.ResumeLayout(false);
            this.reservationsTabPage.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.reseravtionListTabPage.ResumeLayout(false);
            this.reseravtionListTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage reservationsTabPage;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TabPage reseravtionListTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvCheckIns;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingID;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomRate;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomID;
        private Guna.UI2.WinForms.Guna2TextBox txtGuestID;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtGuestName;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckInDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}