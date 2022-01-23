namespace DriversLicenseTestApp
{
    partial class AddQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuestion));
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.addAnswer = new System.Windows.Forms.Button();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.uploadImageQuestion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(49, 88);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(770, 80);
            this.tbQuestion.TabIndex = 2;
            // 
            // addAnswer
            // 
            this.addAnswer.BackColor = System.Drawing.Color.White;
            this.addAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnswer.ForeColor = System.Drawing.Color.White;
            this.addAnswer.Image = ((System.Drawing.Image)(resources.GetObject("addAnswer.Image")));
            this.addAnswer.Location = new System.Drawing.Point(126, 251);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(25, 25);
            this.addAnswer.TabIndex = 3;
            this.addAnswer.UseVisualStyleBackColor = false;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.BackColor = System.Drawing.Color.Black;
            this.buttonAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonAddQuestion.Location = new System.Drawing.Point(742, 517);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(128, 38);
            this.buttonAddQuestion.TabIndex = 4;
            this.buttonAddQuestion.Text = "Добави";
            this.buttonAddQuestion.UseVisualStyleBackColor = false;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // panelAnswers
            // 
            this.panelAnswers.Location = new System.Drawing.Point(49, 279);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(770, 232);
            this.panelAnswers.TabIndex = 5;
            // 
            // uploadImageQuestion
            // 
            this.uploadImageQuestion.BackColor = System.Drawing.Color.Transparent;
            this.uploadImageQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImageQuestion.ForeColor = System.Drawing.Color.White;
            this.uploadImageQuestion.Image = ((System.Drawing.Image)(resources.GetObject("uploadImageQuestion.Image")));
            this.uploadImageQuestion.Location = new System.Drawing.Point(796, 56);
            this.uploadImageQuestion.Name = "uploadImageQuestion";
            this.uploadImageQuestion.Size = new System.Drawing.Size(25, 25);
            this.uploadImageQuestion.TabIndex = 6;
            this.uploadImageQuestion.UseVisualStyleBackColor = false;
            this.uploadImageQuestion.Click += new System.EventHandler(this.uploadImageQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отговори:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въпрос:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Категория:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Регулиране на движението",
            "Общо устройство на МПС",
            "Основни понятия",
            "Скорост, дистанция, намаляване на скоростта",
            "Задължения на водача"});
            this.cbType.Location = new System.Drawing.Point(49, 210);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(332, 24);
            this.cbType.TabIndex = 8;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.LinkColor = System.Drawing.Color.Black;
            this.linkBack.Location = new System.Drawing.Point(12, 541);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(49, 17);
            this.linkBack.TabIndex = 10;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Назад";
            this.linkBack.VisitedLinkColor = System.Drawing.Color.Purple;
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(882, 567);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uploadImageQuestion);
            this.Controls.Add(this.panelAnswers);
            this.Controls.Add(this.buttonAddQuestion);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddQuestion";
            this.Text = "1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button addAnswer;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.Button uploadImageQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.LinkLabel linkBack;
    }
}