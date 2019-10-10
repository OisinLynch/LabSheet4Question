using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet4Question
{
    public enum Result { Win, Draw, Loss}
    public class Team : IComparable
    {
        //Set Team Names Property
        public string TeamNames { get; private set; }

        //Set number of Wins Property
        public int Wins { get; private set; }

        //Set number of Draws Property
        public int Draws { get; private set; }

        //Set number of Losses Property
        public int Losses { get; private set; }

        //Set number of Games Played Property
        public int Games { get; private set; }

        public List<Player> Players { get; set; }

        //Longhand property because there is a calculation in the get
        private int points;
        public int Points
        {
            get
            {
                points = (Wins * 3) + (Draws * 1);
                return points;
            }
        }

        //Team Constructor
        public Team(string name)
        {
            TeamNames = name;
            Players = new List<Player>();
        }

        //Method to add result
        public void AddResult(Result result)
        {
            Games++;

            //Switch to determine the results 
            switch (result)
            {
                case Result.Win:
                    Wins++;
                    break;

                case Result.Draw:
                    Draws++;
                    break;

                case Result.Loss:
                    Losses++;
                    break;

            }
        }

        //Creating a method to Display Team Table
        public string DisplayTeamTable()
        {
            return string.Format($"{TeamNames,-15}{Points,-7}{Wins,-7}{Draws,-7}{Losses,-7}{Games,-7}");
        }

        //Compare to method using IComparable
        public int CompareTo(object obj)
        {
            Team that = (Team)obj;

            //Compare one temas points to another 
            return this.Points.CompareTo(that.Points);
        }

    }
}
