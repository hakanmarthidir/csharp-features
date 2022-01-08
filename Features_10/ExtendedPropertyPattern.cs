using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    internal class ExtendedPropertyPattern
    {
        class Player
        {
            public string Name { get; set; }
            public Team Team { get; set; }
        }

        class Team
        {
            public string TeamName { get; set; }
        }

        class PatternTest
        {
            public PatternTest()
            {
                Player player = new Player()
                {
                    Name = "PlayerName",
                    Team = new Team() { TeamName = "Team1" }
                };

                //For Nested Properties

                //Before C# 10
                if (player is Player { Team : { TeamName : "Team2" } })
                {

                }

                //with C# 10
                if (player is Player { Team.TeamName: "Team2" })
                {

                }
            }
        }


    }
}
