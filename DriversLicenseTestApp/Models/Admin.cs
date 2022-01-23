using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriversLicenseTestApp.Models
{
    public class Admin
    {
        private string username = "";
        private string password = "";

        public Admin() { }

        public Admin(string username, string password)
        {
            username = this.username;
            password = this.password;
        }

        public void setUsername(string username) 
        {
            username = this.username;
        }
        public void setPassword(string password)
        {
            password = this.password;
        }

        public string getUsername() 
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
    }
}
