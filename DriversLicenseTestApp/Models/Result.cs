using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriversLicenseTestApp.Models
{
    public class Result
    {
        private string name = "";
        private int score = 0;
        private User user = new User();

        public Result() { }

        public Result(string name, int score, User user)
        {
            name = this.name;
            score = this.score;
            user = this.user;
        }

        public void setName(string name)
        {
            name = this.name;
        }

        public void setScore(int score)
        {
            score = this.score;
        }

        public void setUser(User user)
        {
            user = this.user;
        }

        public string getName()
        {
            return this.name;
        }

        public int getScore()
        {
            return this.score;
        }

        public User getUser()
        {
            return this.user;
        }
    }
}
