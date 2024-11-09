namespace HotelEase
{
    partial class GuestPayments
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
            this.lvCheckOuts = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.lvCheckOuts.Location = new System.Drawing.Point(0, 78);
            this.lvCheckOuts.MultiSelect = false;
            this.lvCheckOuts.Name = "lvCheckOuts";
            this.lvCheckOuts.Size = new System.Drawing.Size(933, 409);
            this.lvCheckOuts.TabIndex = 13;
            this.lvCheckOuts.UseCompatibleStateImageBehavior = false;
            this.lvCheckOuts.View = System.Windows.Forms.View.Details;
            this.lvCheckOuts.DoubleClick += new System.EventHandler(this.lvCheckOuts_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.Location = new System.Drawing.Point(294, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(318, 21);
            this.txtSearch.TabIndex = 16;
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
            this.cmbSort.Location = new System.Drawing.Point(764, 51);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(157, 21);
            this.cmbSort.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sort by";
            // 
            // label2
            // 
            this.label2.Image = global::HotelEase.Properties.Resources.search_32;
            this.label2.Location = new System.Drawing.Point(256, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 30);
            this.label2.TabIndex = 15;
            // 
            // GuestPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvCheckOuts);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuestPayments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView lvCheckOuts;
    }
}