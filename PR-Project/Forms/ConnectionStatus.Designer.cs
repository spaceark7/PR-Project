namespace PR_Project.Forms
{
    partial class ConnectionStatus
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
            this.btn_connect = new FontAwesome.Sharp.IconButton();
            this.lbl_statusText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictbox_AlertIcon = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_AlertIcon)).BeginInit();
            this.SuspendLayout();
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
            this.btn_connect.Location = new System.Drawing.Point(328, 382);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Rotation = 0D;
            this.btn_connect.Size = new System.Drawing.Size(163, 63);
            this.btn_connect.TabIndex = 11;
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
            this.lbl_statusText.Location = new System.Drawing.Point(289, 264);
            this.lbl_statusText.Name = "lbl_statusText";
            this.lbl_statusText.Size = new System.Drawing.Size(259, 35);
            this.lbl_statusText.TabIndex = 8;
            this.lbl_statusText.Text = "Belum Terhubung";
            this.lbl_statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(199, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Silahkan hubungkan Perangkat Fingerprint";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictbox_AlertIcon
            // 
            this.pictbox_AlertIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictbox_AlertIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictbox_AlertIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pictbox_AlertIcon.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.pictbox_AlertIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pictbox_AlertIcon.IconSize = 194;
            this.pictbox_AlertIcon.Location = new System.Drawing.Point(286, 17);
            this.pictbox_AlertIcon.Name = "pictbox_AlertIcon";
            this.pictbox_AlertIcon.Size = new System.Drawing.Size(194, 320);
            this.pictbox_AlertIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictbox_AlertIcon.TabIndex = 9;
            this.pictbox_AlertIcon.TabStop = false;
            // 
            // ConnectionStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lbl_statusText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictbox_AlertIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ConnectionStatus";
            this.Text = "ConnectionStatus";
            ((System.ComponentModel.ISupportInitialize)(this.pictbox_AlertIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public FontAwesome.Sharp.IconButton btn_connect;
        public System.Windows.Forms.Label label3;
        public FontAwesome.Sharp.IconPictureBox pictbox_AlertIcon;
        public System.Windows.Forms.Label lbl_statusText;
    }
}