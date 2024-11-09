namespace HotelEase
{
    partial class Check_Outs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Outs));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.checkOutsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnGetRoomNumber = new System.Windows.Forms.Button();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRoomRate = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRoomID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.reseravtionListTabPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvCheckOuts = new System.Windows.Forms.ListView();
            this.tabControl.SuspendLayout();
            this.checkOutsTabPage.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.reseravtionListTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.checkOutsTabPage);
            this.tabControl.Controls.Add(this.reseravtionListTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(933, 490);
            this.tabControl.TabIndex = 3;
            // 
            // checkOutsTabPage
            // 
            this.checkOutsTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkOutsTabPage.Controls.Add(this.groupBox);
            this.checkOutsTabPage.Location = new System.Drawing.Point(4, 22);
            this.checkOutsTabPage.Name = "checkOutsTabPage";
            this.checkOutsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkOutsTabPage.Size = new System.Drawing.Size(925, 464);
            this.checkOutsTabPage.TabIndex = 0;
            this.checkOutsTabPage.Text = "Manage Check-Outs";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.cmbStatus);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.groupBox1);
            this.groupBox.Controls.Add(this.lblTotalAmount);
            this.groupBox.Controls.Add(this.btnGetRoomNumber);
            this.groupBox.Controls.Add(this.dtpCheckOutDate);
            this.groupBox.Controls.Add(this.txtEmail);
            this.groupBox.Controls.Add(this.txtRoomRate);
            this.groupBox.Controls.Add(this.txtRoomNumber);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.txtRoomID);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtBookingID);
            this.groupBox.Controls.Add(this.txtGuestID);
            this.groupBox.Controls.Add(this.txtGuestName);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Location = new System.Drawing.Point(24, 26);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(877, 419);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Check-Out Information";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(466, 160);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(344, 21);
            this.cmbStatus.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCheckOut);
            this.groupBox1.Location = new System.Drawing.Point(466, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Image = global::HotelEase.Properties.Resources.icons8_reset_16;
            this.btnReset.Location = new System.Drawing.Point(150, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 27);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "&Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Location = new System.Drawing.Point(25, 20);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(94, 27);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "&Check-Out";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(466, 233);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(344, 41);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGetRoomNumber
            // 
            this.btnGetRoomNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetRoomNumber.Location = new System.Drawing.Point(391, 213);
            this.btnGetRoomNumber.Name = "btnGetRoomNumber";
            this.btnGetRoomNumber.Size = new System.Drawing.Size(28, 21);
            this.btnGetRoomNumber.TabIndex = 6;
            this.btnGetRoomNumber.Text = "...";
            this.btnGetRoomNumber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetRoomNumber.UseVisualStyleBackColor = true;
            this.btnGetRoomNumber.Click += new System.EventHandler(this.btnGetRoomNumber_Click);
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Enabled = false;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(41, 319);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(344, 21);
            this.dtpCheckOutDate.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(466, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 21);
            this.txtEmail.TabIndex = 2;
            // 
            // txtRoomRate
            // 
            this.txtRoomRate.Enabled = false;
            this.txtRoomRate.Location = new System.Drawing.Point(41, 263);
            this.txtRoomRate.Name = "txtRoomRate";
            this.txtRoomRate.Size = new System.Drawing.Size(344, 21);
            this.txtRoomRate.TabIndex = 1;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.Location = new System.Drawing.Point(41, 213);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(344, 21);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(38, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Check Out Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Room Rate";
            // 
            // txtRoomID
            // 
            this.txtRoomID.Enabled = false;
            this.txtRoomID.Location = new System.Drawing.Point(41, 160);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(344, 21);
            this.txtRoomID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Id";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Location = new System.Drawing.Point(41, 56);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(344, 21);
            this.txtBookingID.TabIndex = 8;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Enabled = false;
            this.txtGuestID.Location = new System.Drawing.Point(41, 102);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(344, 21);
            this.txtGuestID.TabIndex = 8;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Enabled = false;
            this.txtGuestName.Location = new System.Drawing.Point(466, 56);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(344, 21);
            this.txtGuestName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(463, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Guest Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Booking ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Guest ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(463, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Total Amount";
            // 
            // reseravtionListTabPage
            // 
            this.reseravtionListTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reseravtionListTabPage.Controls.Add(this.label2);
            this.reseravtionListTabPage.Controls.Add(this.txtSearch);
            this.reseravtionListTabPage.Controls.Add(this.cmbSort);
            this.reseravtionListTabPage.Controls.Add(this.label1);
            this.reseravtionListTabPage.Controls.Add(this.lvCheckOuts);
            this.reseravtionListTabPage.Location = new System.Drawing.Point(4, 22);
            this.reseravtionListTabPage.Name = "reseravtionListTabPage";
            this.reseravtionListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reseravtionListTabPage.Size = new System.Drawing.Size(925, 464);
            this.reseravtionListTabPage.TabIndex = 1;
            this.reseravtionListTabPage.Text = "Check-Out List";
            // 
            // label2
            // 
            this.label2.Image = global::HotelEase.Properties.Resources.search_32;
            this.label2.Location = new System.Drawing.Point(283, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 30);
            this.label2.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(321, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(318, 21);
            this.txtSearch.TabIndex = 10;
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "CheckInDate",
            "CheckOutDate",
            "Status"});
            this.cmbSort.Location = new System.Drawing.Point(760, 37);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(157, 21);
            this.cmbSort.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(757, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort by";
            // 
            // lvCheckOuts
            // 
            this.lvCheckOuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCheckOuts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvCheckOuts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvCheckOuts.FullRowSelect = true;
            this.lvCheckOuts.GridLines = true;
            this.lvCheckOuts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCheckOuts.HideSelection = false;
            this.lvCheckOuts.Location = new System.Drawing.Point(3, 71);
            this.lvCheckOuts.MultiSelect = false;
            this.lvCheckOuts.Name = "lvCheckOuts";
            this.lvCheckOuts.Size = new System.Drawing.Size(919, 390);
            this.lvCheckOuts.TabIndex = 12;
            this.lvCheckOuts.UseCompatibleStateImageBehavior = false;
            this.lvCheckOuts.View = System.Windows.Forms.View.Details;
            // 
            // Check_Outs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 490);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Check_Outs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-Outs Window";
            this.tabControl.ResumeLayout(false);
            this.checkOutsTabPage.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.reseravtionListTabPage.ResumeLayout(false);
            this.reseravtionListTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage checkOutsTabPage;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnGetRoomNumber;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRoomRate;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRoomID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage reseravtionListTabPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvCheckOuts;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
    }
}