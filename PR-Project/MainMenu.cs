using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PR_Project.Forms;

namespace PR_Project
{
    public partial class MainMenu : Form
    {

        // This Field as Instance For Left Border HIghlight when button active or inactive
        private IconButton currentButton;
        private Panel leftBorderPanel;
        private Form currentChildForm;
        public bool isDeviceConnected = false;
        public string connection
        {
            get { return this.lblTextStatus.Text; } set { this.lblTextStatus.Text = value; }
        }
        public bool DeviceStatus { get { return isDeviceConnected; } set { isDeviceConnected = value; } }
        public MainMenu()
        {
            InitializeComponent();
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(10, 50);
            panelMenu.Controls.Add(leftBorderPanel);
            

        }

        private void ConnectMachine()
        {

        } 

        private void OpenChildForm(Form ChildForm)
        {
            if(currentChildForm != null)
            {
                Console.WriteLine("This Code Executed");
                currentChildForm.Close();
            }


            currentChildForm = ChildForm;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            panelChildFormContainer.Controls.Add(ChildForm);
            panelChildFormContainer.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();


        }
        #region ButtonMethods
        // Methods When Button Activated Or Not

        private void ActivateButton (Object senderBtn, Color color)
        {
            if(senderBtn != null) {
                DeactivatedButton();
            currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(255, 66, 103, 178);
            currentButton.ForeColor = Color.White;
            currentButton.TextAlign = ContentAlignment.MiddleCenter;
            currentButton.IconColor = Color.White;
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

            //leftborderbutton
            leftBorderPanel.BackColor = Color.DodgerBlue;
            leftBorderPanel.Location = new Point(0, currentButton.Location.Y);
            leftBorderPanel.Visible = true;
            leftBorderPanel.BringToFront();
                this.lblChildFormDefault.Visible = false;
                this.lblChildForm.Visible = true;
                this.lblChildForm.Text = currentButton.Text;
                this.iconCurrentchildForm.IconChar = currentButton.IconChar;
                this.iconCurrentchildForm.Visible = true;
            }
        }

        private void DeactivatedButton ()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.White;
                currentButton.ForeColor = Color.FromArgb(225,66, 103, 178);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(255, 66, 103, 178);
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        // When the button clicked it will show the transition and the form
        private void btn_overview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            
           

            if (isDeviceConnected)
            {
                OpenChildForm(new OverviewForm());
            }


        }

        private void btn_dtAbsensi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            if (isDeviceConnected) {
                OpenChildForm(new DataAbsensi());
            }
            
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            if (isDeviceConnected)
            { OpenChildForm(new Laporan()); }
                
        }

        private void btn_dtKaryawan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            if (isDeviceConnected)
            { OpenChildForm(new DataKaryawan()); }
            
        }

        private void btn_setelan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            if (isDeviceConnected)
            { OpenChildForm(new Setting()); }
            
        }


        #endregion

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            isDeviceConnected = true;
            if(isDeviceConnected)
            {
                this.lbl_statusText.Text = "Terhubung";
                this.lblTextStatus.Text = "Terhubung";
                this.pictbox_AlertIcon.IconChar = IconChar.CheckCircle;
                this.pictbox_AlertIcon.IconColor = Color.Green;
                this.iconStatusPanel.IconChar = IconChar.CheckCircle;
                this.iconStatusPanel.IconColor = Color.LawnGreen;
                btn_connect.Visible = false;
                this.lbl_tellmenu.Text = "Silahkan Pilih Menu DIsamping Kiri";
            }
            else
            {
                MessageBox.Show("Terjadi Kesalahan!");
            }
        }
    }
}
