using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace DriversLicenseTestApp.Models
{
    public class Question
    {
        private string questionString = "";
        private string type = "";
        private string picture = "";
        public List<Answer> Answers { get; set; }

        public Question() { }

        public Question(string questionString, string type, string picture) 
        {
            this.questionString = questionString;
            this.type = type;
            this.picture = picture;
        }

        public void setQuestion(string questionString)
        {
            questionString = this.questionString;
        }
        public void setType(string type)
        {
            type = this.type;
        }
        public void setPicture(string picture) 
        {
            picture = this.picture;
        }

        public string getQuestion()
        {
            return this.questionString;
        }
        public string getType()
        {
            return this.type;
        }
        public string getPicture()
        {
            return this.picture;
        }
    }
}
