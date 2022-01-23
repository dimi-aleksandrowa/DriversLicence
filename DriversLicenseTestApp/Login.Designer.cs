namespace DriversLicenseTestApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonLoginAsUser = new System.Windows.Forms.Button();
            this.buttonLoginAsAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoginAsUser
            // 
            this.buttonLoginAsUser.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLoginAsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsUser.Location = new System.Drawing.Point(466, 358);
            this.buttonLoginAsUser.Name = "buttonLoginAsUser";
            this.buttonLoginAsUser.Size = new System.Drawing.Size(218, 45);
            this.buttonLoginAsUser.TabIndex = 0;
            this.buttonLoginAsUser.Text = "Потребител";
            this.buttonLoginAsUser.UseVisualStyleBackColor = false;
            this.buttonLoginAsUser.Click += new System.EventHandler(this.buttonLoginAsUser_Click);
            // 
            // buttonLoginAsAdmin
            // 
            this.buttonLoginAsAdmin.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonLoginAsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginAsAdmin.Location = new System.Drawing.Point(761, 358);
            this.buttonLoginAsAdmin.Name = "buttonLoginAsAdmin";
            this.buttonLoginAsAdmin.Size = new System.Drawing.Size(218, 46);
            this.buttonLoginAsAdmin.TabIndex = 1;
            this.buttonLoginAsAdmin.Text = "Администратор";
            this.buttonLoginAsAdmin.UseVisualStyleBackColor = false;
            this.buttonLoginAsAdmin.Click += new System.EventHandler(this.buttonLoginAsAdmin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 498);
            this.Controls.Add(this.buttonLoginAsAdmin);
            this.Controls.Add(this.buttonLoginAsUser);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Вход в системата";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginAsUser;
        private System.Windows.Forms.Button buttonLoginAsAdmin;
    }
}

