using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet4Question
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a List for Team Names
            List<Team> teams = new List<Team>();

            //Setting the Team Names
            Team SligoRovers = new Team("Sligo Rovers");
            Team FinnHarps = new Team("Finn Harps");
            Team GalwayUnited = new Team("Galway United");
            Team DerryCity = new Team("Derry City");
            Team Dundalk = new Team("Dundalk");

            //Adding Team Names to the List
            teams.Add(SligoRovers);
            teams.Add(FinnHarps);
            teams.Add(GalwayUnited);
            teams.Add(DerryCity);
            teams.Add(Dundalk);

            //Calling the Display method
            //Display with no results
            Display(teams);

            //Using Add Result method to give teams results
            SligoRovers.AddResult(Result.Win);
            FinnHarps.AddResult(Result.Loss);
            GalwayUnited.AddResult(Result.Draw);
            DerryCity.AddResult(Result.Win);
            Dundalk.AddResult(Result.Loss);

            //Display with results
            Display(teams);

            teams.Sort();
            teams.Reverse();

            //Display with points sorted from highest to lowest
            Display(teams);

            //Adding player information 
            SligoRovers.Players.Add(new Player() { Name = "Ed McGinty", Position = "Goalkeeper" });
            SligoRovers.Players.Add(new Player() { Name = "John Mahon", Position = "Defender" });
            SligoRovers.Players.Add(new Player() { Name = "Ronan Coughlan", Position = "Forward" });

            //Display Sligo Rovers Player information
            Console.WriteLine("\nSligo Rovers Teamsheet");
            foreach (Player player in SligoRovers.Players)
            {
                Console.WriteLine($"{player.Name} - {player.Position}");
                Console.WriteLine(player);
            }



        }

        //Mathod to display Team Details and calling the Team Display Table
        static void Display(List<Team> teams)
        {
            Console.WriteLine("\n{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

            //Loop through each of the teams in Team List and display them in the table
            foreach (Team team in teams)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }
        }
    }
}
