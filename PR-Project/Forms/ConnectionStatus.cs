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
    public partial class ConnectionStatus : Form
    {
        public bool connStatus = false;

       
        public ConnectionStatus()
        {
            InitializeComponent();
        }

        public bool GetStatus()
        {
            return connStatus;
        }
        public void btn_connect_Click(object sender, EventArgs e)
        {
            connStatus = true;
            if (connStatus == true)
            {
                lbl_statusText.Text = "Terhubung";
                pictbox_AlertIcon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                btn_connect.Visible = false;
                Form status = MainMenu.ActiveForm;
                
                MessageBox.Show("conn status: " + connStatus.ToString());
                
              
            }
        }
    }
}
