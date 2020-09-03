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
    public partial class DataAbsensi : Form
    {
        public DataAbsensi()
        {
            InitializeComponent();

        }

        private void DataAbsensi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.PresentData' table. You can move, or remove it, as needed.
            this.presentDataTableAdapter.Fill(this.databaseDataSet.PresentData);

        }
    }
}
