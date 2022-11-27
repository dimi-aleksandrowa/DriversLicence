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
    public partial class AdministratorOptions : Form
    {
        public AdministratorOptions()
        {
            InitializeComponent();
        }

        private void btn_AddQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();

            AddQuestion add = new AddQuestion();
            add.ShowDialog();

            this.Close();
        }

        private void btn_CorrectQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();

            CorrectQuestion correct = new CorrectQuestion();
            correct.ShowDialog();

            this.Close();
        }

        private void btn_DeleteQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();

            DeleteQuestion del = new DeleteQuestion();
            del.ShowDialog();

            this.Close();
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