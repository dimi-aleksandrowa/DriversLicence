using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace DriversLicenseTestApp.Models
{
    public class Picture
    {
        private string filePath = "";

        public Picture() { }

        public Picture(string filePath)
        {
            filePath = this.filePath;
        }

        public void setFilePath(string filePath)
        {
            filePath = this.filePath;
        }

        public string getFilePath()
        {
            return this.filePath;
        }

        public void uploadPicture(MySqlConnection connection)
        {
            
        }
    }
}
