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
    public partial class DeleteQuestion : Form
    {
        string connStr = Properties.Settings.Default.UsersConnectionString;
        MySqlConnection conn;
        MySqlCommand command;
        MySqlDataAdapter ad;
        int ID = 0;

        public DeleteQuestion()
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

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                using (conn = new MySqlConnection(connStr))
                {
                    command = new MySqlCommand(@"DELETE questions WHERE question_id =@id 
                                                DELETE question_type WHERE type_id=@id
                                                DELETE answers WHERE answer_id=@id", conn);
                    conn.Open();
                    command.Parameters.AddWithValue("@id", ID);
                    try
                    {

                        command.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Record Deleted Successfully");
                }
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }  
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
        }
    }
}
