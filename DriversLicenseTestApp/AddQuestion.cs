using DriversLicenseTestApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DriversLicenseTestApp
{
    public partial class AddQuestion : Form
    {
        private string connStr = Properties.Settings.Default.UsersConnectionString;
        MySqlConnection conn;
        MySqlCommand command;

        public AddQuestion()
        {
            InitializeComponent();
        }

        // button + clicked
        private void addAnswer_Click(object sender, EventArgs e)
        {
            // create textbox for answer
            TextBox textbox = new TextBox();
            int count = panelAnswers.Controls.OfType<TextBox>().ToList().Count;
            textbox.Location = new System.Drawing.Point(10, 25 * count);
            textbox.Size = new System.Drawing.Size(200, 20);
            textbox.Name = "tb_" + (count + 1);
            panelAnswers.Controls.Add(textbox);

            // create checkbox to check if answer is right 
            CheckBox checkbox = new CheckBox();
            checkbox.Location = new System.Drawing.Point(220, 25 * count);
            checkbox.AutoSize = true;
            checkbox.Text = "верен";
            checkbox.Name = "chb_" + (count + 1);
            panelAnswers.Controls.Add(checkbox);

            // create button for uploading photo
            Button upload = new Button();
            upload.Location = new System.Drawing.Point(290, 25 * count);
            upload.Size = new System.Drawing.Size(24, 25);
            upload.Image = uploadImageQuestion.Image;
            upload.Name = "btnUpload_" + (count + 1);
            upload.Font = new Font(upload.Font, FontStyle.Bold);
            upload.Click += new System.EventHandler(this.btnUploadAnswerPic_Click);
            panelAnswers.Controls.Add(upload);

            // create button delete
            Button button = new Button();
            button.Location = new System.Drawing.Point(320, 25 * count);
            button.Size = new System.Drawing.Size(50, 25);
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
            button.Name = "btnDelete_" + (count + 1);
            button.Text = "Del";
            button.Font = new Font(upload.Font, FontStyle.Bold);
            button.Click += new System.EventHandler(this.btnDelete_Click);
            panelAnswers.Controls.Add(button);
        }

        // dynamic button Delete(deletes the row of dynamic controls) clicked
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btn_del = (sender as Button);

            int i = int.Parse(btn_del.Name.Split('_')[1]); // find button index
           
            TextBox txt = (TextBox)panelAnswers.Controls.Find("tb_" + i, true)[0];
            CheckBox chb = (CheckBox)panelAnswers.Controls.Find("chb_" + i, true)[0];
            Button upl = (Button)panelAnswers.Controls.Find("btnUpload_" + i, true)[0];

            panelAnswers.Controls.Remove(txt); // delete tb
            panelAnswers.Controls.Remove(chb); // del chb
            panelAnswers.Controls.Remove(upl); // delete btnUpload
            panelAnswers.Controls.Remove(btn_del); // delete btn_del

            int index = int.Parse(txt.Name.Split('_')[1]);

            // rearrange locations
            foreach (TextBox tb in panelAnswers.Controls.OfType<TextBox>())
            {
                int controlIndex = int.Parse(tb.Name.Split('_')[1]);

                CheckBox ch = (CheckBox)panelAnswers.Controls.Find("chb_" + controlIndex, true)[0];
                Button up = (Button)panelAnswers.Controls.Find("btnUpload_" + controlIndex, true)[0];
                Button del = (Button)panelAnswers.Controls.Find("btnDelete_" + controlIndex, true)[0];


                if (controlIndex > index)
                {
                    up.Top = up.Top - 25;
                    del.Top = del.Top - 25;
                    tb.Top = tb.Top - 25;
                    ch.Top = ch.Top - 25;
                }
            }
            // dispose dynamic objects
            txt.Dispose();
            chb.Dispose();
            upl.Dispose();
            btn_del.Dispose();
        }

        List<string> imagePaths = new List<string>(); // holds value of image path on a dynamic row

        // dynamic button Upload(uploads picture to an answer) clicked
        private void btnUploadAnswerPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePaths.Add(open.FileName); 
            }  
        }

        // insert question into database 
        public void insertQuestion()
        {
            if (conn.State == ConnectionState.Open) 
            {
                string queryQuestion = @"INSERT INTO questions(question) VALUES(@question)";
                string queryType = @"INSERT INTO question_type(type) VALUES(@type)";
                string queryAnswers = @"INSERT INTO answers(answer, isCorrect) VALUES(@answer, @isCorrect)";

                // insert question into database
                command = new MySqlCommand(queryQuestion, conn);
                command.Parameters.AddWithValue("@question", tbQuestion.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                // insert question type into database
                command = new MySqlCommand(queryType, conn);
                command.Parameters.AddWithValue("@type", cbType.Text);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //insert answers 
                int count = panelAnswers.Controls.OfType<TextBox>().ToList().Count;
                for (int i = 1; i <= count; i++)
                {
                    TextBox tb;
                    CheckBox chb;
                    tb = (TextBox)panelAnswers.Controls.Find("tb_" + i, true)[0];
                    chb = (CheckBox)panelAnswers.Controls.Find("chb_" + i, true)[0];
                    command = new MySqlCommand(queryAnswers, conn);
                    command.Parameters.AddWithValue("@answer", tb.Text);
                        if (chb.Checked)
                        {
                            command.Parameters.AddWithValue("@isCorrect", chb.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@isCorrect", "грешен");
                        }
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    //  TO DO  .... if() picture is uploaded add it to database as well
                }
         }
        // button "добави" click event
        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            using (conn = new MySqlConnection(connStr)) 
            {
                conn.Open();
                insertQuestion();
            }
            DialogResult result = MessageBox.Show("Добавихте въпрос успешно! Искате ли да се върнете назад?", "Съобщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                AdministratorOptions ao = new AdministratorOptions();
                ao.ShowDialog();
                this.Close();
            }  
        }
        // go back 
        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdministratorOptions ao = new AdministratorOptions();
            ao.ShowDialog();
            this.Close();
        }
        // upload image to question
        private void uploadImageQuestion_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePaths.Add(open.FileName);
            }  
        }
    }
}
