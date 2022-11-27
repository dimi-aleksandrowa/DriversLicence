using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using DriversLicenseTestApp.Models;

namespace DriversLicenseTestApp
{
    public partial class AdministratorLogin : Form
    {
        string connStr = Properties.Settings.Default.UsersConnectionString;

        public AdministratorLogin()
        {
            InitializeComponent();
            tbAdminPassword.PasswordChar = '*';
        }

        MySqlConnection connection;
        MySqlCommand command;

        //login button clicked
        private void bAdminLog_Click(object sender, EventArgs e)
        {
           using(connection = new MySqlConnection(connStr))
           {
                connection.Open();

                if (tbAdminUsername.Text == "" || tbAdminPassword.Text == "")
                {
                    MessageBox.Show("Please, fill all fields!");
                }
                else if (logIn(new Admin(tbAdminUsername.Text, tbAdminPassword.Text)))
                {
                    this.Hide();

                    AdministratorOptions ao = new AdministratorOptions();
                    ao.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
        }

        private bool logIn(Admin admin)
        {
            // check if log in is successful
            string queryLogIn = @"SELECT * FROM admins WHERE username = '" + tbAdminUsername.Text + "' AND password  = '" + tbAdminPassword.Text + "'";

            if (connection.State == ConnectionState.Open)
            {
                command = new MySqlCommand(queryLogIn, connection);
            }
            try
            {
                MySqlDataReader row;
                row = command.ExecuteReader();

                if (row.HasRows)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // submit form with Enter key
        private void onEnterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bAdminLog_Click(sender, e);
            }
        }

        public void CreateAdmin()
        {
                // insert admin info
                string queryCreateAdmin = @"INSERT INTO admins(username, password) VALUES('admin', 'admin')";

                if (connection.State == ConnectionState.Open)
                {
                    command = new MySqlCommand(queryCreateAdmin, connection);
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
        private void bGenerateAccount_Click(object sender, EventArgs e)
        {
            using (connection = new MySqlConnection(connStr))
            {
                connection.Open();
                CreateAdmin();
            }
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            Login log = new Login();
            log.ShowDialog();

            this.Close();
        }
    }
}
