namespace PR_Project.Forms
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox_LoginLogo = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_logoText = new System.Windows.Forms.Label();
            this.lbl_LogoName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_LoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_LogoName);
            this.panel1.Controls.Add(this.lbl_logoText);
            this.panel1.Controls.Add(this.iconPictureBox_LoginLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 387);
            this.panel1.TabIndex = 0;
            // 
            // iconPictureBox_LoginLogo
            // 
            this.iconPictureBox_LoginLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox_LoginLogo.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox_LoginLogo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox_LoginLogo.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.iconPictureBox_LoginLogo.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox_LoginLogo.IconSize = 104;
            this.iconPictureBox_LoginLogo.Location = new System.Drawing.Point(62, 49);
            this.iconPictureBox_LoginLogo.Name = "iconPictureBox_LoginLogo";
            this.iconPictureBox_LoginLogo.Size = new System.Drawing.Size(104, 152);
            this.iconPictureBox_LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox_LoginLogo.TabIndex = 0;
            this.iconPictureBox_LoginLogo.TabStop = false;
            // 
            // lbl_logoText
            // 
            this.lbl_logoText.AutoSize = true;
            this.lbl_logoText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logoText.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logoText.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_logoText.Location = new System.Drawing.Point(24, 270);
            this.lbl_logoText.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbl_logoText.Name = "lbl_logoText";
            this.lbl_logoText.Size = new System.Drawing.Size(200, 29);
            this.lbl_logoText.TabIndex = 1;
            this.lbl_logoText.Text = "Nama Perusahaan";
            this.lbl_logoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LogoName
            // 
            this.lbl_LogoName.AutoSize = true;
            this.lbl_LogoName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LogoName.Font = new System.Drawing.Font("Corbel", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogoName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_LogoName.Location = new System.Drawing.Point(39, 224);
            this.lbl_LogoName.MinimumSize = new System.Drawing.Size(150, 0);
            this.lbl_LogoName.Name = "lbl_LogoName";
            this.lbl_LogoName.Size = new System.Drawing.Size(174, 27);
            this.lbl_LogoName.TabIndex = 2;
            this.lbl_LogoName.Text = "Logo Perusahaan";
            this.lbl_LogoName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(24, 307);
            this.label1.MinimumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Deskripsi/Alamat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(334, 22);
            this.label2.MinimumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOGIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(310, 79);
            this.label3.MinimumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Software Payroll Dan Absensi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(270, 139);
            this.textBox1.MinimumSize = new System.Drawing.Size(0, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Corbel", 14F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(270, 194);
            this.textBox2.MinimumSize = new System.Drawing.Size(0, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 23);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Password";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Lime;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Corbel", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Pushed;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(270, 255);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(333, 54);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Masuk";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(678, 387);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape1.BorderColor = System.Drawing.SystemColors.Window;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 269;
            this.lineShape1.X2 = 605;
            this.lineShape1.Y1 = 166;
            this.lineShape1.Y2 = 166;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape2.BorderColor = System.Drawing.SystemColors.Window;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 267;
            this.lineShape2.X2 = 603;
            this.lineShape2.Y1 = 224;
            this.lineShape2.Y2 = 224;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(678, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox_LoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_LogoName;
        private System.Windows.Forms.Label lbl_logoText;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox_LoginLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}