namespace DriversLicenseTestApp
{
    partial class AdministratorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdminUsername = new System.Windows.Forms.TextBox();
            this.tbAdminPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAdminLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bGenerateAccount = new System.Windows.Forms.Button();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(243, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Потребителско име:";
            // 
            // tbAdminUsername
            // 
            this.tbAdminUsername.Location = new System.Drawing.Point(392, 71);
            this.tbAdminUsername.Name = "tbAdminUsername";
            this.tbAdminUsername.Size = new System.Drawing.Size(173, 22);
            this.tbAdminUsername.TabIndex = 3;
            // 
            // tbAdminPassword
            // 
            this.tbAdminPassword.Location = new System.Drawing.Point(392, 113);
            this.tbAdminPassword.Name = "tbAdminPassword";
            this.tbAdminPassword.Size = new System.Drawing.Size(173, 22);
            this.tbAdminPassword.TabIndex = 4;
            this.tbAdminPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onEnterDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Парола:";
            // 
            // bAdminLog
            // 
            this.bAdminLog.BackColor = System.Drawing.Color.Black;
            this.bAdminLog.ForeColor = System.Drawing.Color.Snow;
            this.bAdminLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAdminLog.Location = new System.Drawing.Point(392, 163);
            this.bAdminLog.Name = "bAdminLog";
            this.bAdminLog.Size = new System.Drawing.Size(173, 32);
            this.bAdminLog.TabIndex = 6;
            this.bAdminLog.Text = "Вход";
            this.bAdminLog.UseVisualStyleBackColor = false;
            this.bAdminLog.Click += new System.EventHandler(this.bAdminLog_Click);
            this.bAdminLog.Enter += new System.EventHandler(this.bAdminLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bGenerateAccount
            // 
            this.bGenerateAccount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bGenerateAccount.Location = new System.Drawing.Point(472, 12);
            this.bGenerateAccount.Name = "bGenerateAccount";
            this.bGenerateAccount.Size = new System.Drawing.Size(134, 27);
            this.bGenerateAccount.TabIndex = 8;
            this.bGenerateAccount.Text = "Добави акаунт";
            this.bGenerateAccount.UseVisualStyleBackColor = false;
            this.bGenerateAccount.Click += new System.EventHandler(this.bGenerateAccount_Click);
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.LinkColor = System.Drawing.Color.Black;
            this.linkBack.Location = new System.Drawing.Point(13, 210);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(49, 17);
            this.linkBack.TabIndex = 9;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Назад";
            this.linkBack.VisitedLinkColor = System.Drawing.Color.Purple;
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // AdministratorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(618, 239);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.bGenerateAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bAdminLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAdminPassword);
            this.Controls.Add(this.tbAdminUsername);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AdministratorLogin";
            this.Text = "Влизане като администратор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdminUsername;
        private System.Windows.Forms.TextBox tbAdminPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAdminLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bGenerateAccount;
        private System.Windows.Forms.LinkLabel linkBack;
    }
}