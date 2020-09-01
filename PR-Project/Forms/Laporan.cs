using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_Project.Forms
{
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salarySumDataSet.SalarySum' table. You can move, or remove it, as needed.
            this.salarySumTableAdapter.Fill(this.salarySumDataSet.SalarySum);

        }
    }
}
