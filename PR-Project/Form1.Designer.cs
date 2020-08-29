using System.Drawing;

namespace PR_Project
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconStatusPanel = new FontAwesome.Sharp.IconPictureBox();
            this.lblTextStatus = new System.Windows.Forms.Label();
            this.btn_setelan = new FontAwesome.Sharp.IconButton();
            this.btn_dtKaryawan = new FontAwesome.Sharp.IconButton();
            this.btn_laporan = new FontAwesome.Sharp.IconButton();
            this.btn_dtAbsensi = new FontAwesome.Sharp.IconButton();
            this.btn_overview = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelChildFormHead = new System.Windows.Forms.Panel();
            this.lblChildFormDefault = new System.Windows.Forms.Label();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.iconCurrentchildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelChildShadow = new System.Windows.Forms.Panel();
            this.panelChildFormContainer = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatusPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelChildFormHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentchildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btn_setelan);
            this.panelMenu.Controls.Add(this.btn_dtKaryawan);
            this.panelMenu.Controls.Add(this.btn_laporan);
            this.panelMenu.Controls.Add(this.btn_dtAbsensi);
            this.panelMenu.Controls.Add(this.btn_overview);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 596);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconStatusPanel);
            this.panel1.Controls.Add(this.lblTextStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 114);
            this.panel1.TabIndex = 1;
            // 
            // iconStatusPanel
            // 
            this.iconStatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.iconStatusPanel.ForeColor = System.Drawing.Color.Crimson;
            this.iconStatusPanel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconStatusPanel.IconColor = System.Drawing.Color.Crimson;
            this.iconStatusPanel.IconSize = 50;
            this.iconStatusPanel.Location = new System.Drawing.Point(78, 6);
            this.iconStatusPanel.Name = "iconStatusPanel";
            this.iconStatusPanel.Size = new System.Drawing.Size(50, 67);
            this.iconStatusPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconStatusPanel.TabIndex = 4;
            this.iconStatusPanel.TabStop = false;
            // 
            // lblTextStatus
            // 
            this.lblTextStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextStatus.AutoSize = true;
            this.lblTextStatus.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextStatus.Location = new System.Drawing.Point(40, 76);
            this.lblTextStatus.Name = "lblTextStatus";
            this.lblTextStatus.Size = new System.Drawing.Size(132, 19);
            this.lblTextStatus.TabIndex = 3;
            this.lblTextStatus.Text = "Belum Terhubung";
            // 
            // btn_setelan
            // 
            this.btn_setelan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btn_setelan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_setelan.FlatAppearance.BorderSize = 0;
            this.btn_setelan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setelan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_setelan.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setelan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_setelan.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_setelan.IconColor = System.Drawing.Color.White;
            this.btn_setelan.IconSize = 30;
            this.btn_setelan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setelan.Location = new System.Drawing.Point(0, 280);
            this.btn_setelan.Name = "btn_setelan";
            this.btn_setelan.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_setelan.Rotation = 0D;
            this.btn_setelan.Size = new System.Drawing.Size(220, 50);
            this.btn_setelan.TabIndex = 6;
            this.btn_setelan.Text = "Setelan";
            this.btn_setelan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setelan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setelan.UseVisualStyleBackColor = false;
            this.btn_setelan.Click += new System.EventHandler(this.btn_setelan_Click);
            // 
            // btn_dtKaryawan
            // 
            this.btn_dtKaryawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btn_dtKaryawan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dtKaryawan.FlatAppearance.BorderSize = 0;
            this.btn_dtKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dtKaryawan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_dtKaryawan.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtKaryawan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dtKaryawan.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btn_dtKaryawan.IconColor = System.Drawing.Color.White;
            this.btn_dtKaryawan.IconSize = 30;
            this.btn_dtKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtKaryawan.Location = new System.Drawing.Point(0, 230);
            this.btn_dtKaryawan.Name = "btn_dtKaryawan";
            this.btn_dtKaryawan.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_dtKaryawan.Rotation = 0D;
            this.btn_dtKaryawan.Size = new System.Drawing.Size(220, 50);
            this.btn_dtKaryawan.TabIndex = 5;
            this.btn_dtKaryawan.Text = "Data Karyawan";
            this.btn_dtKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dtKaryawan.UseVisualStyleBackColor = false;
            this.btn_dtKaryawan.Click += new System.EventHandler(this.btn_dtKaryawan_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btn_laporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_laporan.FlatAppearance.BorderSize = 0;
            this.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laporan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_laporan.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laporan.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_laporan.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btn_laporan.IconColor = System.Drawing.Color.White;
            this.btn_laporan.IconSize = 30;
            this.btn_laporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laporan.Location = new System.Drawing.Point(0, 180);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_laporan.Rotation = 0D;
            this.btn_laporan.Size = new System.Drawing.Size(220, 50);
            this.btn_laporan.TabIndex = 4;
            this.btn_laporan.Text = "Laporan";
            this.btn_laporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_laporan.UseVisualStyleBackColor = false;
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // btn_dtAbsensi
            // 
            this.btn_dtAbsensi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btn_dtAbsensi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dtAbsensi.FlatAppearance.BorderSize = 0;
            this.btn_dtAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dtAbsensi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_dtAbsensi.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtAbsensi.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dtAbsensi.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btn_dtAbsensi.IconColor = System.Drawing.Color.White;
            this.btn_dtAbsensi.IconSize = 30;
            this.btn_dtAbsensi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtAbsensi.Location = new System.Drawing.Point(0, 130);
            this.btn_dtAbsensi.Name = "btn_dtAbsensi";
            this.btn_dtAbsensi.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_dtAbsensi.Rotation = 0D;
            this.btn_dtAbsensi.Size = new System.Drawing.Size(220, 50);
            this.btn_dtAbsensi.TabIndex = 3;
            this.btn_dtAbsensi.Text = "Data Absensi";
            this.btn_dtAbsensi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtAbsensi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dtAbsensi.UseVisualStyleBackColor = false;
            this.btn_dtAbsensi.Click += new System.EventHandler(this.btn_dtAbsensi_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.btn_overview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_overview.FlatAppearance.BorderSize = 0;
            this.btn_overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overview.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_overview.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_overview.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_overview.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btn_overview.IconColor = System.Drawing.Color.White;
            this.btn_overview.IconSize = 30;
            this.btn_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_overview.Location = new System.Drawing.Point(0, 80);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_overview.Rotation = 0D;
            this.btn_overview.Size = new System.Drawing.Size(220, 50);
            this.btn_overview.TabIndex = 2;
            this.btn_overview.Text = "Overview";
            this.btn_overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_overview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_overview.UseVisualStyleBackColor = false;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PR_Project.Properties.Resources.lg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelChildFormHead
            // 
            this.PanelChildFormHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.PanelChildFormHead.Controls.Add(this.lblChildFormDefault);
            this.PanelChildFormHead.Controls.Add(this.lblChildForm);
            this.PanelChildFormHead.Controls.Add(this.iconCurrentchildForm);
            this.PanelChildFormHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelChildFormHead.Location = new System.Drawing.Point(220, 0);
            this.PanelChildFormHead.Name = "PanelChildFormHead";
            this.PanelChildFormHead.Size = new System.Drawing.Size(571, 80);
            this.PanelChildFormHead.TabIndex = 1;
            // 
            // lblChildFormDefault
            // 
            this.lblChildFormDefault.AutoSize = true;
            this.lblChildFormDefault.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildFormDefault.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChildFormDefault.Location = new System.Drawing.Point(6, 27);
            this.lblChildFormDefault.Name = "lblChildFormDefault";
            this.lblChildFormDefault.Size = new System.Drawing.Size(175, 23);
            this.lblChildFormDefault.TabIndex = 2;
            this.lblChildFormDefault.Text = "Silahkan Pilih Menu";
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChildForm.Location = new System.Drawing.Point(44, 27);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(60, 23);
            this.lblChildForm.TabIndex = 1;
            this.lblChildForm.Text = "Name";
            this.lblChildForm.Visible = false;
            // 
            // iconCurrentchildForm
            // 
            this.iconCurrentchildForm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconCurrentchildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(94)))), ((int)(((byte)(84)))));
            this.iconCurrentchildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconCurrentchildForm.ForeColor = System.Drawing.Color.LightGreen;
            this.iconCurrentchildForm.IconChar = FontAwesome.Sharp.IconChar.HourglassStart;
            this.iconCurrentchildForm.IconColor = System.Drawing.Color.LightGreen;
            this.iconCurrentchildForm.Location = new System.Drawing.Point(6, 12);
            this.iconCurrentchildForm.Name = "iconCurrentchildForm";
            this.iconCurrentchildForm.Size = new System.Drawing.Size(32, 52);
            this.iconCurrentchildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrentchildForm.TabIndex = 0;
            this.iconCurrentchildForm.TabStop = false;
            this.iconCurrentchildForm.Visible = false;
            // 
            // panelChildShadow
            // 
            this.panelChildShadow.BackColor = System.Drawing.Color.LightGreen;
            this.panelChildShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildShadow.Location = new System.Drawing.Point(220, 80);
            this.panelChildShadow.Name = "panelChildShadow";
            this.panelChildShadow.Size = new System.Drawing.Size(571, 3);
            this.panelChildShadow.TabIndex = 2;
            // 
            // panelChildFormContainer
            // 
            this.panelChildFormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.panelChildFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormContainer.Location = new System.Drawing.Point(220, 83);
            this.panelChildFormContainer.Name = "panelChildFormContainer";
            this.panelChildFormContainer.Size = new System.Drawing.Size(571, 513);
            this.panelChildFormContainer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 596);
            this.Controls.Add(this.panelChildFormContainer);
            this.Controls.Add(this.panelChildShadow);
            this.Controls.Add(this.PanelChildFormHead);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatusPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelChildFormHead.ResumeLayout(false);
            this.PanelChildFormHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentchildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_overview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_setelan;
        private FontAwesome.Sharp.IconButton btn_dtKaryawan;
        private FontAwesome.Sharp.IconButton btn_laporan;
        private FontAwesome.Sharp.IconButton btn_dtAbsensi;
        private System.Windows.Forms.Panel PanelChildFormHead;
        private System.Windows.Forms.Label lblChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentchildForm;
        private System.Windows.Forms.Label lblChildFormDefault;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconStatusPanel;
        private System.Windows.Forms.Label lblTextStatus;
        private System.Windows.Forms.Panel panelChildShadow;
        private System.Windows.Forms.Panel panelChildFormContainer;
    }
}

