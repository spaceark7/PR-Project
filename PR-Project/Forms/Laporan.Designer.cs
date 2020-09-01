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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salarySumDataSet = new PR_Project.SalarySumDataSet();
            this.salarySumBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.salarySumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // salarySumDataSet
            // 
            this.salarySumDataSet.DataSetName = "SalarySumDataSet";
            this.salarySumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salarySumBindingSource
            // 
            this.salarySumBindingSource.DataMember = "SalarySum";
            this.salarySumBindingSource.DataSource = this.salarySumDataSet;
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
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 0);
            this.Name = "Laporan";
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarySumBindingSource)).EndInit();
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