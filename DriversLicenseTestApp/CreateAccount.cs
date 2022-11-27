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
using DriversLicenseTestApp.Models;

namespace DriversLicenseTestApp
{
    public partial class CreateAccount : Form
    {
        string connStr = Properties.Settings.Default.UsersConnectionString;
        MySqlConnection connection;
        MySqlCommand command;

        public CreateAccount()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbRepeatPassword.PasswordChar = '*';
        }

        private void bCreateAccount_Click(object sender, EventArgs e)
        {
            using (connection = new MySqlConnection(connStr))
            {
                connection.Open();

                if (tbEmail.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || tbRepeatPassword.Text == "")
                {
                    MessageBox.Show("Please, fill all fields!");
                }
                else if (tbPassword.Text == tbRepeatPassword.Text)
                {
                    insertUser(new User(tbUsername.Text, tbPassword.Text, tbEmail.Text));
                }
                else
                {
                    MessageBox.Show("Passwords don't match! Try again.");
                }
            }
        }

         public void insertUser(User user)
        {
            string queryCreateUser = "INSERT INTO users(username, password, email)" + " VALUES(@username, @password, @email)";
            if(connection.State == ConnectionState.Open)
            {
                command = new MySqlCommand(queryCreateUser, connection);
                command.Parameters.AddWithValue("@username", tbUsername.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);
                command.Parameters.AddWithValue("@email", tbEmail.Text);
            }

            try
            {
                command.ExecuteNonQuery();

                MessageBox.Show("You created a new account!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void bBack_Click(object sender, EventArgs e)
         {
             this.Hide();

             UserLogin ul = new UserLogin();
             ul.ShowDialog();

             this.Close();
         }
    }
}
