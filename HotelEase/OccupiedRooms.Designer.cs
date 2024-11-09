namespace HotelEase
{
    partial class OccupiedRooms
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvOccupiedRooms = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Image = global::HotelEase.Properties.Resources.search_32;
            this.label2.Location = new System.Drawing.Point(261, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 30);
            this.label2.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(306, 50);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(370, 21);
            this.txtSearch.TabIndex = 15;
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "CheckInDate",
            "Status"});
            this.cmbSort.Location = new System.Drawing.Point(848, 70);
            this.cmbSort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(182, 21);
            this.cmbSort.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(845, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sort by";
            // 
            // lvOccupiedRooms
            // 
            this.lvOccupiedRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOccupiedRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvOccupiedRooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvOccupiedRooms.FullRowSelect = true;
            this.lvOccupiedRooms.GridLines = true;
            this.lvOccupiedRooms.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOccupiedRooms.HideSelection = false;
            this.lvOccupiedRooms.Location = new System.Drawing.Point(0, 97);
            this.lvOccupiedRooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvOccupiedRooms.MultiSelect = false;
            this.lvOccupiedRooms.Name = "lvOccupiedRooms";
            this.lvOccupiedRooms.Size = new System.Drawing.Size(1045, 390);
            this.lvOccupiedRooms.TabIndex = 17;
            this.lvOccupiedRooms.UseCompatibleStateImageBehavior = false;
            this.lvOccupiedRooms.View = System.Windows.Forms.View.Details;
            this.lvOccupiedRooms.DoubleClick += new System.EventHandler(this.lvOccupiedRooms_DoubleClick);
            // 
            // OccupiedRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvOccupiedRooms);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OccupiedRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Occupied Rooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView lvOccupiedRooms;
    }
}