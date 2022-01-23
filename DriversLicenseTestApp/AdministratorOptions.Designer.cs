namespace DriversLicenseTestApp
{
    partial class AdministratorOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorOptions));
            this.btn_AddQuestion = new System.Windows.Forms.Button();
            this.btn_CorrectQuestion = new System.Windows.Forms.Button();
            this.btn_DeleteQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_AddQuestion
            // 
            this.btn_AddQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_AddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_AddQuestion.Location = new System.Drawing.Point(126, 81);
            this.btn_AddQuestion.Name = "btn_AddQuestion";
            this.btn_AddQuestion.Size = new System.Drawing.Size(221, 81);
            this.btn_AddQuestion.TabIndex = 1;
            this.btn_AddQuestion.Text = "Добавяне на въпрос";
            this.btn_AddQuestion.UseVisualStyleBackColor = false;
            this.btn_AddQuestion.Click += new System.EventHandler(this.btn_AddQuestion_Click);
            // 
            // btn_CorrectQuestion
            // 
            this.btn_CorrectQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_CorrectQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CorrectQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_CorrectQuestion.Location = new System.Drawing.Point(224, 168);
            this.btn_CorrectQuestion.Name = "btn_CorrectQuestion";
            this.btn_CorrectQuestion.Size = new System.Drawing.Size(221, 79);
            this.btn_CorrectQuestion.TabIndex = 2;
            this.btn_CorrectQuestion.Text = "Коригиране на въпрос";
            this.btn_CorrectQuestion.UseVisualStyleBackColor = false;
            this.btn_CorrectQuestion.Click += new System.EventHandler(this.btn_CorrectQuestion_Click);
            // 
            // btn_DeleteQuestion
            // 
            this.btn_DeleteQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_DeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteQuestion.Location = new System.Drawing.Point(317, 253);
            this.btn_DeleteQuestion.Name = "btn_DeleteQuestion";
            this.btn_DeleteQuestion.Size = new System.Drawing.Size(220, 77);
            this.btn_DeleteQuestion.TabIndex = 3;
            this.btn_DeleteQuestion.Text = "Изтриване на въпрос";
            this.btn_DeleteQuestion.UseVisualStyleBackColor = false;
            this.btn_DeleteQuestion.Click += new System.EventHandler(this.btn_DeleteQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Моля, изберете:";
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.BackColor = System.Drawing.Color.Transparent;
            this.linkBack.Location = new System.Drawing.Point(369, 387);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(51, 17);
            this.linkBack.TabIndex = 5;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Изход ";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // AdministratorOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 413);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteQuestion);
            this.Controls.Add(this.btn_CorrectQuestion);
            this.Controls.Add(this.btn_AddQuestion);
            this.Name = "AdministratorOptions";
            this.Text = "Администраторски права";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddQuestion;
        private System.Windows.Forms.Button btn_CorrectQuestion;
        private System.Windows.Forms.Button btn_DeleteQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkBack;
    }
}