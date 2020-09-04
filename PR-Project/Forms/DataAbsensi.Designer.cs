namespace PR_Project.Forms
{
    partial class DataAbsensi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataAbsensi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new PR_Project.DatabaseDataSet();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.panelSearchMonth = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.dtp_toDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromText = new System.Windows.Forms.Label();
            this.labelTextPeriod = new System.Windows.Forms.Label();
            this.presentDataTableAdapter = new PR_Project.DatabaseDataSetTableAdapters.PresentDataTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.panelSearchMonth.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 110);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 480);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.namaKaryawanDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.presentDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(773, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // namaKaryawanDataGridViewTextBoxColumn
            // 
            this.namaKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Nama Karyawan";
            this.namaKaryawanDataGridViewTextBoxColumn.HeaderText = "Nama Karyawan";
            this.namaKaryawanDataGridViewTextBoxColumn.Name = "namaKaryawanDataGridViewTextBoxColumn";
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            // 
            // presentDataBindingSource
            // 
            this.presentDataBindingSource.DataMember = "PresentData";
            this.presentDataBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPrint.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.White;
            this.btnPrint.IconSize = 25;
            this.btnPrint.Location = new System.Drawing.Point(637, 42);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Rotation = 0D;
            this.btnPrint.Size = new System.Drawing.Size(148, 50);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Cetak Rekapan";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // panelSearchMonth
            // 
            this.panelSearchMonth.Controls.Add(this.panel4);
            this.panelSearchMonth.Controls.Add(this.dtp_toDate);
            this.panelSearchMonth.Controls.Add(this.dtp_fromDate);
            this.panelSearchMonth.Controls.Add(this.lblToDate);
            this.panelSearchMonth.Controls.Add(this.lblFromText);
            this.panelSearchMonth.Controls.Add(this.labelTextPeriod);
            this.panelSearchMonth.Location = new System.Drawing.Point(12, 4);
            this.panelSearchMonth.Name = "panelSearchMonth";
            this.panelSearchMonth.Size = new System.Drawing.Size(435, 100);
            this.panelSearchMonth.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_Search);
            this.panel4.Location = new System.Drawing.Point(350, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(77, 54);
            this.panel4.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Search.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Search.IconColor = System.Drawing.Color.White;
            this.btn_Search.IconSize = 25;
            this.btn_Search.Location = new System.Drawing.Point(0, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Rotation = 0D;
            this.btn_Search.Size = new System.Drawing.Size(77, 54);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Cari";
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // dtp_toDate
            // 
            this.dtp_toDate.CalendarFont = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_toDate.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtp_toDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp_toDate.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtp_toDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dtp_toDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtp_toDate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_toDate.Location = new System.Drawing.Point(176, 68);
            this.dtp_toDate.Name = "dtp_toDate";
            this.dtp_toDate.Size = new System.Drawing.Size(162, 27);
            this.dtp_toDate.TabIndex = 4;
            // 
            // dtp_fromDate
            // 
            this.dtp_fromDate.CalendarFont = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromDate.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtp_fromDate.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtp_fromDate.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtp_fromDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dtp_fromDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtp_fromDate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromDate.Location = new System.Drawing.Point(8, 68);
            this.dtp_fromDate.Name = "dtp_fromDate";
            this.dtp_fromDate.Size = new System.Drawing.Size(162, 27);
            this.dtp_fromDate.TabIndex = 3;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToDate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblToDate.Location = new System.Drawing.Point(172, 46);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(116, 19);
            this.lblToDate.TabIndex = 2;
            this.lblToDate.Text = "Sampai Tanggal";
            // 
            // lblFromText
            // 
            this.lblFromText.AutoSize = true;
            this.lblFromText.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFromText.Location = new System.Drawing.Point(4, 46);
            this.lblFromText.Name = "lblFromText";
            this.lblFromText.Size = new System.Drawing.Size(93, 19);
            this.lblFromText.TabIndex = 1;
            this.lblFromText.Text = "Dari Tanggal";
            // 
            // labelTextPeriod
            // 
            this.labelTextPeriod.AutoSize = true;
            this.labelTextPeriod.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTextPeriod.Location = new System.Drawing.Point(110, 5);
            this.labelTextPeriod.Name = "labelTextPeriod";
            this.labelTextPeriod.Size = new System.Drawing.Size(129, 27);
            this.labelTextPeriod.TabIndex = 0;
            this.labelTextPeriod.Text = "Pilih Periode";
            // 
            // presentDataTableAdapter
            // 
            this.presentDataTableAdapter.ClearBeforeFill = true;
            // 
            // DataAbsensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(797, 660);
            this.Controls.Add(this.panelSearchMonth);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataAbsensi";
            this.Text = "DataAbsensi";
            this.Load += new System.EventHandler(this.DataAbsensi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.panelSearchMonth.ResumeLayout(false);
            this.panelSearchMonth.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private FontAwesome.Sharp.IconButton btnPrint;
        private System.Windows.Forms.Panel panelSearchMonth;
        private System.Windows.Forms.DateTimePicker dtp_fromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromText;
        private System.Windows.Forms.Label labelTextPeriod;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_toDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource presentDataBindingSource;
        private DatabaseDataSetTableAdapters.PresentDataTableAdapter presentDataTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
    }
}