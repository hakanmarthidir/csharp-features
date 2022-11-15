using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_11
{
    internal class NewLinesStringInterpolation
    {
        public static string SampleInterpolatedString1()
        {

            string name = "Hakan";
            string email = "ahsgdasda@asdasd.com";
            int playerLevel = 1;

            //string message = $"you can reach to {name} by using this email {email} to change the gamelevel data, current is {playerLevel}";

            string message = $"you can reach to {name} by using this email {email} to change the gamelevel data, current  level is {playerLevel switch { 
                > 5 => "Master Player",
                > 4 => "Good Player",
                > 3 => "Player",
                _ => "Not PLayer",
            } }";

            return message;

        }

        public static string SampleInterpolatedString2()
        {

            string name = "Hakan";
            string email = "ahsgdasda@asdasd.com";
            string level = "Master Player";

            string message = $"you can reach to {name} by using this email {email} to change the gamelevel data, current  level is { 
                level
                .Split(" ")
                [0]
                .ToUpper()
                }";           
         

            return message;

        }
    }
}
