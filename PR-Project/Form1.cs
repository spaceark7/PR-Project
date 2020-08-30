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
    public partial class Form1 : Form
    {

        // This Field as Instance For Left Border HIghlight when button active or inactive
        private IconButton currentButton;
        private Panel leftBorderPanel;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(10, 50);
            panelMenu.Controls.Add(leftBorderPanel);

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
            currentButton.BackColor = Color.FromArgb(255, 18, 140, 126);
            currentButton.ForeColor = Color.White;
            currentButton.TextAlign = ContentAlignment.MiddleCenter;
            currentButton.IconColor = Color.White;
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

            //leftborderbutton
            leftBorderPanel.BackColor = Color.Cornsilk;
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
                currentButton.BackColor = Color.FromArgb(255, 7, 94, 84);
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        // When the button clicked it will show the transition and the form
        private void btn_overview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            OpenChildForm(new OverviewForm());

        }

        private void btn_dtAbsensi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            OpenChildForm(new DataAbsensi());
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            OpenChildForm(new Laporan());
        }

        private void btn_dtKaryawan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            OpenChildForm(new DataKaryawan());
        }

        private void btn_setelan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 18, 140, 126));
            OpenChildForm(new Setting());
        }
        #endregion 
    }
}
