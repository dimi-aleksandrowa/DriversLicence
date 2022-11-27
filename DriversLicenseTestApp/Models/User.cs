using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriversLicenseTestApp.Models
{
    public class User
    {
        private string username = "";
        private string password = "";
        private string email = "";

        public User() { }

        public User(string username, string password)
        {
            username = this.username;
            password = this.password;
        }
        public User(string username, string password, string email)
        {
            username = this.username;
            password = this.password;
            email = this.email;
        }

        public void setUsername(string username)
        {
            username = this.username;
        }

        public void setPassword(string password)
        {
            password = this.password;
        }

        public void setEmail(string email)
        {
            email = this.email;
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public string getEmail()
        {
            return this.email;
        }

    }
}
