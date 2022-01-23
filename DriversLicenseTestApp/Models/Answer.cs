using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DriversLicenseTestApp.Models
{
    public class Answer
    {
        private string answerString = "";
        private string isCorrect = "";
        private string picture = "";

        public List<Question> Questions { get; set; }
        public Answer() { }

        public Answer(string answerString, string isCorrect) 
        {
            this.answerString = answerString;
            this.isCorrect = isCorrect;
        }
        public Answer(string answerString, string isCorrect, string picture)
        {
            this.answerString = answerString;
            this.isCorrect = isCorrect;
            this.picture = picture;
        }

        public void setAnswer(string answerString)
        {
            answerString = this.answerString;
        }
        public void setIsCorrect(string isCorrect)
        {
            isCorrect = this.isCorrect;
        }
        
        public void setPicture(string picture)
        {
            picture = this.picture;
        }

        public string getAnswer() 
        {
            return this.answerString;
        }
        public string getIsCorrect()
        {
            return this.isCorrect;
        }
    
        public string getPicture()
        {
            return this.picture;
        }
    }
}
