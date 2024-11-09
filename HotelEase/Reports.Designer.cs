namespace HotelEase
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.roomsPieChart = new LiveCharts.WinForms.PieChart();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.paymentsPieChart = new LiveCharts.WinForms.PieChart();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.dgvPayments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsPieChart
            // 
            this.roomsPieChart.Location = new System.Drawing.Point(3, 43);
            this.roomsPieChart.Name = "roomsPieChart";
            this.roomsPieChart.Size = new System.Drawing.Size(403, 248);
            this.roomsPieChart.TabIndex = 0;
            this.roomsPieChart.Text = "pieChart1";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.roomsPieChart);
            this.guna2GroupBox1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(409, 307);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Rooms Reports";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.Controls.Add(this.dgvPayments);
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 322);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1326, 395);
            this.guna2GroupBox2.TabIndex = 2;
            this.guna2GroupBox2.Text = "List Representation";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 20;
            this.guna2GroupBox3.Controls.Add(this.paymentsPieChart);
            this.guna2GroupBox3.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(427, 12);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(433, 304);
            this.guna2GroupBox3.TabIndex = 3;
            this.guna2GroupBox3.Text = "Payments Report";
            // 
            // paymentsPieChart
            // 
            this.paymentsPieChart.Location = new System.Drawing.Point(3, 43);
            this.paymentsPieChart.Name = "paymentsPieChart";
            this.paymentsPieChart.Size = new System.Drawing.Size(418, 248);
            this.paymentsPieChart.TabIndex = 0;
            this.paymentsPieChart.Text = "pieChart1";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderRadius = 20;
            this.guna2GroupBox4.Controls.Add(this.cartesianChart);
            this.guna2GroupBox4.FillColor = System.Drawing.SystemColors.Control;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox4.Location = new System.Drawing.Point(866, 12);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(472, 304);
            this.guna2GroupBox4.TabIndex = 3;
            this.guna2GroupBox4.Text = "Cartesian Chart";
            // 
            // cartesianChart
            // 
            this.cartesianChart.Location = new System.Drawing.Point(3, 43);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(466, 248);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.Text = "cartesianChart1";
            // 
            // dgvPayments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayments.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayments.Location = new System.Drawing.Point(0, 40);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.Size = new System.Drawing.Size(1326, 355);
            this.dgvPayments.TabIndex = 0;
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPayments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPayments.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvPayments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPayments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPayments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPayments.ThemeStyle.ReadOnly = false;
            this.dgvPayments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvPayments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvPayments.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPayments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPayments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPayments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPayments_CellFormatting_1);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.guna2GroupBox4);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart roomsPieChart;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private LiveCharts.WinForms.PieChart paymentsPieChart;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayments;
    }
}