using System.Drawing;

namespace PR_Project
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_connect = new FontAwesome.Sharp.IconButton();
            this.lbl_statusText = new System.Windows.Forms.Label();
            this.lbl_tellmenu = new System.Windows.Forms.Label();
            this.pictbox_AlertIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel_DeviceInfo = new System.Windows.Forms.Panel();
            this.lbl_deviceNameText = new System.Windows.Forms.Label();
            this.lbl_deviceNameVal = new System.Windows.Forms.Label();
            this.lbl_deviceVersion = new System.Windows.Forms.Label();
            this.lbl_deviceVersionVal = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatusPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelChildFormHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentchildForm)).BeginInit();
            this.panelChildFormContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_AlertIcon)).BeginInit();
            this.panel_DeviceInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.panel_DeviceInfo);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btn_setelan);
            this.panelMenu.Controls.Add(this.btn_dtKaryawan);
            this.panelMenu.Controls.Add(this.btn_laporan);
            this.panelMenu.Controls.Add(this.btn_dtAbsensi);
            this.panelMenu.Controls.Add(this.btn_overview);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 761);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Logo Perusahaan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.iconStatusPanel);
            this.panel1.Controls.Add(this.lblTextStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 114);
            this.panel1.TabIndex = 1;
            // 
            // iconStatusPanel
            // 
            this.iconStatusPanel.BackColor = System.Drawing.Color.Transparent;
            this.iconStatusPanel.ForeColor = System.Drawing.Color.AliceBlue;
            this.iconStatusPanel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconStatusPanel.IconColor = System.Drawing.Color.AliceBlue;
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
            this.lblTextStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblTextStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextStatus.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTextStatus.Location = new System.Drawing.Point(11, 76);
            this.lblTextStatus.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblTextStatus.Name = "lblTextStatus";
            this.lblTextStatus.Size = new System.Drawing.Size(200, 19);
            this.lblTextStatus.TabIndex = 3;
            this.lblTextStatus.Text = "Belum Terhubung";
            this.lblTextStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_setelan
            // 
            this.btn_setelan.BackColor = System.Drawing.Color.White;
            this.btn_setelan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_setelan.FlatAppearance.BorderSize = 0;
            this.btn_setelan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setelan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_setelan.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_setelan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_setelan.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btn_setelan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_setelan.IconSize = 30;
            this.btn_setelan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setelan.Location = new System.Drawing.Point(0, 280);
            this.btn_setelan.Name = "btn_setelan";
            this.btn_setelan.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_setelan.Rotation = 0D;
            this.btn_setelan.Size = new System.Drawing.Size(218, 50);
            this.btn_setelan.TabIndex = 6;
            this.btn_setelan.Text = "Setelan";
            this.btn_setelan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setelan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_setelan.UseVisualStyleBackColor = false;
            this.btn_setelan.Click += new System.EventHandler(this.btn_setelan_Click);
            // 
            // btn_dtKaryawan
            // 
            this.btn_dtKaryawan.BackColor = System.Drawing.Color.White;
            this.btn_dtKaryawan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dtKaryawan.FlatAppearance.BorderSize = 0;
            this.btn_dtKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dtKaryawan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_dtKaryawan.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtKaryawan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_dtKaryawan.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btn_dtKaryawan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_dtKaryawan.IconSize = 30;
            this.btn_dtKaryawan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtKaryawan.Location = new System.Drawing.Point(0, 230);
            this.btn_dtKaryawan.Name = "btn_dtKaryawan";
            this.btn_dtKaryawan.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_dtKaryawan.Rotation = 0D;
            this.btn_dtKaryawan.Size = new System.Drawing.Size(218, 50);
            this.btn_dtKaryawan.TabIndex = 5;
            this.btn_dtKaryawan.Text = "Data Karyawan";
            this.btn_dtKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dtKaryawan.UseVisualStyleBackColor = false;
            this.btn_dtKaryawan.Click += new System.EventHandler(this.btn_dtKaryawan_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.BackColor = System.Drawing.Color.White;
            this.btn_laporan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_laporan.FlatAppearance.BorderSize = 0;
            this.btn_laporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_laporan.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_laporan.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laporan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_laporan.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.btn_laporan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_laporan.IconSize = 30;
            this.btn_laporan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laporan.Location = new System.Drawing.Point(0, 180);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_laporan.Rotation = 0D;
            this.btn_laporan.Size = new System.Drawing.Size(218, 50);
            this.btn_laporan.TabIndex = 4;
            this.btn_laporan.Text = "Laporan";
            this.btn_laporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_laporan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_laporan.UseVisualStyleBackColor = false;
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // btn_dtAbsensi
            // 
            this.btn_dtAbsensi.BackColor = System.Drawing.Color.White;
            this.btn_dtAbsensi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dtAbsensi.FlatAppearance.BorderSize = 0;
            this.btn_dtAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dtAbsensi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_dtAbsensi.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtAbsensi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_dtAbsensi.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btn_dtAbsensi.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_dtAbsensi.IconSize = 30;
            this.btn_dtAbsensi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtAbsensi.Location = new System.Drawing.Point(0, 130);
            this.btn_dtAbsensi.Name = "btn_dtAbsensi";
            this.btn_dtAbsensi.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_dtAbsensi.Rotation = 0D;
            this.btn_dtAbsensi.Size = new System.Drawing.Size(218, 50);
            this.btn_dtAbsensi.TabIndex = 3;
            this.btn_dtAbsensi.Text = "Data Absensi";
            this.btn_dtAbsensi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dtAbsensi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dtAbsensi.UseVisualStyleBackColor = false;
            this.btn_dtAbsensi.Click += new System.EventHandler(this.btn_dtAbsensi_Click);
            // 
            // btn_overview
            // 
            this.btn_overview.BackColor = System.Drawing.Color.White;
            this.btn_overview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_overview.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_overview.FlatAppearance.BorderSize = 0;
            this.btn_overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overview.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_overview.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_overview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_overview.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btn_overview.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btn_overview.IconSize = 30;
            this.btn_overview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_overview.Location = new System.Drawing.Point(0, 80);
            this.btn_overview.Name = "btn_overview";
            this.btn_overview.Padding = new System.Windows.Forms.Padding(20, 0, 30, 0);
            this.btn_overview.Rotation = 0D;
            this.btn_overview.Size = new System.Drawing.Size(218, 50);
            this.btn_overview.TabIndex = 2;
            this.btn_overview.Text = "Overview";
            this.btn_overview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_overview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_overview.UseVisualStyleBackColor = false;
            this.btn_overview.Click += new System.EventHandler(this.btn_overview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::PR_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelChildFormHead
            // 
            this.PanelChildFormHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.PanelChildFormHead.Controls.Add(this.lblChildFormDefault);
            this.PanelChildFormHead.Controls.Add(this.lblChildForm);
            this.PanelChildFormHead.Controls.Add(this.iconCurrentchildForm);
            this.PanelChildFormHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelChildFormHead.Location = new System.Drawing.Point(220, 0);
            this.PanelChildFormHead.Name = "PanelChildFormHead";
            this.PanelChildFormHead.Size = new System.Drawing.Size(805, 80);
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
            this.iconCurrentchildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentchildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconCurrentchildForm.ForeColor = System.Drawing.Color.LightCyan;
            this.iconCurrentchildForm.IconChar = FontAwesome.Sharp.IconChar.HourglassStart;
            this.iconCurrentchildForm.IconColor = System.Drawing.Color.LightCyan;
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
            this.panelChildShadow.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelChildShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChildShadow.Location = new System.Drawing.Point(220, 80);
            this.panelChildShadow.Name = "panelChildShadow";
            this.panelChildShadow.Size = new System.Drawing.Size(805, 3);
            this.panelChildShadow.TabIndex = 2;
            // 
            // panelChildFormContainer
            // 
            this.panelChildFormContainer.BackColor = System.Drawing.Color.White;
            this.panelChildFormContainer.Controls.Add(this.panel2);
            this.panelChildFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormContainer.Location = new System.Drawing.Point(220, 83);
            this.panelChildFormContainer.Name = "panelChildFormContainer";
            this.panelChildFormContainer.Size = new System.Drawing.Size(805, 678);
            this.panelChildFormContainer.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_connect);
            this.panel2.Controls.Add(this.lbl_statusText);
            this.panel2.Controls.Add(this.lbl_tellmenu);
            this.panel2.Controls.Add(this.pictbox_AlertIcon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 678);
            this.panel2.TabIndex = 6;
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_connect.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_connect.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_connect.IconColor = System.Drawing.Color.Black;
            this.btn_connect.IconSize = 16;
            this.btn_connect.Location = new System.Drawing.Point(313, 413);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Rotation = 0D;
            this.btn_connect.Size = new System.Drawing.Size(163, 63);
            this.btn_connect.TabIndex = 15;
            this.btn_connect.Text = "Hubungkan";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_statusText
            // 
            this.lbl_statusText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_statusText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_statusText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_statusText.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lbl_statusText.Location = new System.Drawing.Point(274, 295);
            this.lbl_statusText.Name = "lbl_statusText";
            this.lbl_statusText.Size = new System.Drawing.Size(259, 35);
            this.lbl_statusText.TabIndex = 12;
            this.lbl_statusText.Text = "Belum Terhubung";
            this.lbl_statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tellmenu
            // 
            this.lbl_tellmenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tellmenu.AutoSize = true;
            this.lbl_tellmenu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tellmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_tellmenu.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tellmenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.lbl_tellmenu.Location = new System.Drawing.Point(184, 341);
            this.lbl_tellmenu.Name = "lbl_tellmenu";
            this.lbl_tellmenu.Size = new System.Drawing.Size(443, 29);
            this.lbl_tellmenu.TabIndex = 14;
            this.lbl_tellmenu.Text = "Silahkan hubungkan Perangkat Fingerprint";
            this.lbl_tellmenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictbox_AlertIcon
            // 
            this.pictbox_AlertIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictbox_AlertIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictbox_AlertIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pictbox_AlertIcon.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.pictbox_AlertIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pictbox_AlertIcon.IconSize = 194;
            this.pictbox_AlertIcon.Location = new System.Drawing.Point(271, 48);
            this.pictbox_AlertIcon.Name = "pictbox_AlertIcon";
            this.pictbox_AlertIcon.Size = new System.Drawing.Size(194, 320);
            this.pictbox_AlertIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictbox_AlertIcon.TabIndex = 13;
            this.pictbox_AlertIcon.TabStop = false;
            // 
            // panel_DeviceInfo
            // 
            this.panel_DeviceInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_DeviceInfo.Controls.Add(this.lbl_deviceVersionVal);
            this.panel_DeviceInfo.Controls.Add(this.lbl_deviceVersion);
            this.panel_DeviceInfo.Controls.Add(this.lbl_deviceNameVal);
            this.panel_DeviceInfo.Controls.Add(this.lbl_deviceNameText);
            this.panel_DeviceInfo.Location = new System.Drawing.Point(11, 423);
            this.panel_DeviceInfo.Name = "panel_DeviceInfo";
            this.panel_DeviceInfo.Size = new System.Drawing.Size(192, 196);
            this.panel_DeviceInfo.TabIndex = 8;
            this.panel_DeviceInfo.Visible = false;
            // 
            // lbl_deviceNameText
            // 
            this.lbl_deviceNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_deviceNameText.AutoSize = true;
            this.lbl_deviceNameText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deviceNameText.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deviceNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.lbl_deviceNameText.Location = new System.Drawing.Point(39, 9);
            this.lbl_deviceNameText.Name = "lbl_deviceNameText";
            this.lbl_deviceNameText.Size = new System.Drawing.Size(108, 27);
            this.lbl_deviceNameText.TabIndex = 0;
            this.lbl_deviceNameText.Text = "Perangkat";
            // 
            // lbl_deviceNameVal
            // 
            this.lbl_deviceNameVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_deviceNameVal.AutoSize = true;
            this.lbl_deviceNameVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deviceNameVal.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deviceNameVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.lbl_deviceNameVal.Location = new System.Drawing.Point(40, 45);
            this.lbl_deviceNameVal.Name = "lbl_deviceNameVal";
            this.lbl_deviceNameVal.Size = new System.Drawing.Size(16, 23);
            this.lbl_deviceNameVal.TabIndex = 1;
            this.lbl_deviceNameVal.Text = "-";
            this.lbl_deviceNameVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_deviceVersion
            // 
            this.lbl_deviceVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_deviceVersion.AutoSize = true;
            this.lbl_deviceVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deviceVersion.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deviceVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.lbl_deviceVersion.Location = new System.Drawing.Point(62, 100);
            this.lbl_deviceVersion.Name = "lbl_deviceVersion";
            this.lbl_deviceVersion.Size = new System.Drawing.Size(58, 27);
            this.lbl_deviceVersion.TabIndex = 2;
            this.lbl_deviceVersion.Text = "Versi";
            // 
            // lbl_deviceVersionVal
            // 
            this.lbl_deviceVersionVal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_deviceVersionVal.AutoSize = true;
            this.lbl_deviceVersionVal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deviceVersionVal.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deviceVersionVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.lbl_deviceVersionVal.Location = new System.Drawing.Point(40, 143);
            this.lbl_deviceVersionVal.Name = "lbl_deviceVersionVal";
            this.lbl_deviceVersionVal.Size = new System.Drawing.Size(16, 23);
            this.lbl_deviceVersionVal.TabIndex = 3;
            this.lbl_deviceVersionVal.Text = "-";
            this.lbl_deviceVersionVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1025, 761);
            this.Controls.Add(this.panelChildFormContainer);
            this.Controls.Add(this.panelChildShadow);
            this.Controls.Add(this.PanelChildFormHead);
            this.Controls.Add(this.panelMenu);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 800);
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconStatusPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelChildFormHead.ResumeLayout(false);
            this.PanelChildFormHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentchildForm)).EndInit();
            this.panelChildFormContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_AlertIcon)).EndInit();
            this.panel_DeviceInfo.ResumeLayout(false);
            this.panel_DeviceInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelChildFormHead;
        private System.Windows.Forms.Label lblChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentchildForm;
        private System.Windows.Forms.Label lblChildFormDefault;
        private System.Windows.Forms.Panel panelChildShadow;
        private System.Windows.Forms.Panel panelChildFormContainer;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton btn_overview;
        public FontAwesome.Sharp.IconButton btn_setelan;
        public FontAwesome.Sharp.IconButton btn_dtKaryawan;
        public FontAwesome.Sharp.IconButton btn_laporan;
        public FontAwesome.Sharp.IconButton btn_dtAbsensi;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lblTextStatus;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconPictureBox iconStatusPanel;
        public FontAwesome.Sharp.IconButton btn_connect;
        public FontAwesome.Sharp.IconPictureBox pictbox_AlertIcon;
        public System.Windows.Forms.Label lbl_statusText;
        public System.Windows.Forms.Label lbl_tellmenu;
        private System.Windows.Forms.Label lbl_deviceVersionVal;
        private System.Windows.Forms.Label lbl_deviceVersion;
        private System.Windows.Forms.Label lbl_deviceNameVal;
        private System.Windows.Forms.Label lbl_deviceNameText;
        public System.Windows.Forms.Panel panel_DeviceInfo;
    }
}

