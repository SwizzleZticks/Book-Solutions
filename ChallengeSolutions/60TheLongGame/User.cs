using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60TheLongGame
{
    public record User
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public User(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
