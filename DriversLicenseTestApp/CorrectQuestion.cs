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
    public partial class CorrectQuestion : Form
    {
        string connStr = Properties.Settings.Default.UsersConnectionString;
        MySqlConnection conn; 
        MySqlCommand command;
        MySqlDataAdapter ad;
        int ID = 0;
        public CorrectQuestion()
        {
            InitializeComponent();
            string query = @"SELECT questions.question_id, questions.question, question_type.type, answers.answer, answers.isCorrect
                             FROM questions 
                             JOIN question_type 
                             ON questions.question_id=type_id
                             JOIN answers
                             ON questions.question_id=answers.question_id";
            try
            {

                displayData(query);
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }

        public void displayData(string query)
        {
            using (conn = new MySqlConnection(connStr))
            {
                conn.Open();
                DataTable dt = new DataTable();
                ad = new MySqlDataAdapter(query, conn);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void bCorrect_Click(object sender, EventArgs e)
        {
            if (tbAnswer.Text != "" && tbQuestion.Text != "" && tbIsCorrect.Text != "" && cbType.Text != "")
            {
                using (conn = new MySqlConnection(connStr))
                {
                    command = new MySqlCommand(@"UPDATE questions SET question=@question WHERE question_id =@id 
                                                UPDATE question_type SET type=@type WHERE type_id=@id
                                                UPDATE answers SET answer=@answer WHERE answer_id=@id
                                                UPDATE answers SET isCorrect=@isCorrect WHERE answer_id=@id", conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@question", tbQuestion.Text);
                    command.Parameters.AddWithValue("@type", cbType.Text);
                    command.Parameters.AddWithValue("@answer", tbAnswer.Text);
                    command.Parameters.AddWithValue("@isCorrect", tbIsCorrect.Text);
                    try
                    {
                    command.ExecuteNonQuery();
                    DialogResult result = MessageBox.Show("Коригирахте този въпрос успешно! Искате ли да се върнете назад?", "Съобщение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        AdministratorOptions ao = new AdministratorOptions();
                        ao.ShowDialog();
                        this.Close();
                    }  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }  
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbQuestion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAnswer.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbIsCorrect.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdministratorOptions ao = new AdministratorOptions();
            ao.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbQuestion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAnswer.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbIsCorrect.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }  
    }
}
