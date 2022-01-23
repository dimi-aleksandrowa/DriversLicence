namespace DriversLicenseTestApp
{
    partial class CorrectQuestion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bCorrect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIsCorrect = new System.Windows.Forms.TextBox();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bCorrect
            // 
            this.bCorrect.Location = new System.Drawing.Point(1090, 568);
            this.bCorrect.Name = "bCorrect";
            this.bCorrect.Size = new System.Drawing.Size(128, 67);
            this.bCorrect.TabIndex = 1;
            this.bCorrect.Text = "Коригирай";
            this.bCorrect.UseVisualStyleBackColor = true;
            this.bCorrect.Click += new System.EventHandler(this.bCorrect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Въпрос:";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(135, 456);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(831, 48);
            this.tbQuestion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 513);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
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
            this.cbType.Location = new System.Drawing.Point(135, 513);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(332, 24);
            this.cbType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Отговор:";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(135, 551);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(831, 22);
            this.tbAnswer.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Верен/грешен:";
            // 
            // tbIsCorrect
            // 
            this.tbIsCorrect.Location = new System.Drawing.Point(135, 593);
            this.tbIsCorrect.Name = "tbIsCorrect";
            this.tbIsCorrect.Size = new System.Drawing.Size(153, 22);
            this.tbIsCorrect.TabIndex = 13;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.LinkColor = System.Drawing.Color.Black;
            this.linkBack.Location = new System.Drawing.Point(1035, 618);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(49, 17);
            this.linkBack.TabIndex = 14;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Назад";
            this.linkBack.VisitedLinkColor = System.Drawing.Color.Purple;
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // CorrectQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 649);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.tbIsCorrect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCorrect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CorrectQuestion";
            this.Text = "Корекция на въпрос";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIsCorrect;
        private System.Windows.Forms.LinkLabel linkBack;
    }
}