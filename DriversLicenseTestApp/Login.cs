using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriversLicenseTestApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        // login as user
        private void buttonLoginAsUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLogin ul = new UserLogin();
            ul.ShowDialog();
            this.Close();
        }
        //login as administrator
        private void buttonLoginAsAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministratorLogin al = new AdministratorLogin();
            al.ShowDialog();
            this.Close();
        }

    }
}
