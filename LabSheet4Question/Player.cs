using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet4Question
{
    public class Player
    {
        //Property to get and set player name
        public string Name { get; set; }

        //Property to get and set player position
        public string Position { get; set; }

        //To String method to display Player information
        public override string ToString()
        {
            return string.Format($"{Name} - {Position}");
        }
    }
}
