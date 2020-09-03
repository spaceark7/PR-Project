namespace PR_Project.Forms
{
    partial class Laporan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salarySumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salarySumDataSet = new PR_Project.SalarySumDataSet();
            this.salarySumTableAdapter = new PR_Project.SalarySumDataSetTableAdapters.SalarySumTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gajiPokokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insentifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hariKerjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGajiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySumDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.namaKaryawanDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn,
            this.gajiPokokDataGridViewTextBoxColumn,
            this.insentifDataGridViewTextBoxColumn,
            this.potonganDataGridViewTextBoxColumn,
            this.hariKerjaDataGridViewTextBoxColumn,
            this.totalGajiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salarySumBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(826, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // salarySumBindingSource
            // 
            this.salarySumBindingSource.DataMember = "SalarySum";
            this.salarySumBindingSource.DataSource = this.salarySumDataSet;
            // 
            // salarySumDataSet
            // 
            this.salarySumDataSet.DataSetName = "SalarySumDataSet";
            this.salarySumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salarySumTableAdapter
            // 
            this.salarySumTableAdapter.ClearBeforeFill = true;
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
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            // 
            // gajiPokokDataGridViewTextBoxColumn
            // 
            this.gajiPokokDataGridViewTextBoxColumn.DataPropertyName = "Gaji Pokok";
            this.gajiPokokDataGridViewTextBoxColumn.HeaderText = "Gaji Pokok";
            this.gajiPokokDataGridViewTextBoxColumn.Name = "gajiPokokDataGridViewTextBoxColumn";
            // 
            // insentifDataGridViewTextBoxColumn
            // 
            this.insentifDataGridViewTextBoxColumn.DataPropertyName = "Insentif";
            this.insentifDataGridViewTextBoxColumn.HeaderText = "Insentif";
            this.insentifDataGridViewTextBoxColumn.Name = "insentifDataGridViewTextBoxColumn";
            // 
            // potonganDataGridViewTextBoxColumn
            // 
            this.potonganDataGridViewTextBoxColumn.DataPropertyName = "Potongan";
            this.potonganDataGridViewTextBoxColumn.HeaderText = "Potongan";
            this.potonganDataGridViewTextBoxColumn.Name = "potonganDataGridViewTextBoxColumn";
            // 
            // hariKerjaDataGridViewTextBoxColumn
            // 
            this.hariKerjaDataGridViewTextBoxColumn.DataPropertyName = "Hari Kerja";
            this.hariKerjaDataGridViewTextBoxColumn.HeaderText = "Hari Kerja";
            this.hariKerjaDataGridViewTextBoxColumn.Name = "hariKerjaDataGridViewTextBoxColumn";
            // 
            // totalGajiDataGridViewTextBoxColumn
            // 
            this.totalGajiDataGridViewTextBoxColumn.DataPropertyName = "Total Gaji";
            this.totalGajiDataGridViewTextBoxColumn.HeaderText = "Total Gaji";
            this.totalGajiDataGridViewTextBoxColumn.Name = "totalGajiDataGridViewTextBoxColumn";
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(850, 566);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "Laporan";
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySumDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalarySumDataSet salarySumDataSet;
        private System.Windows.Forms.BindingSource salarySumBindingSource;
        private SalarySumDataSetTableAdapters.SalarySumTableAdapter salarySumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gajiPokokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insentifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn potonganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariKerjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGajiDataGridViewTextBoxColumn;
    }
}