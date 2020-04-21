using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public class TuplePattern
    {
        public static string GiveMyState(string city1, string city2, string city3) => (city1, city2, city3) switch
        {
            ("x", "y", "z") => "Hesse",
            ("x", "z", "y") => "Brandenburg",
            ("y", "z", "x") => "Baden-Württemberg",
            ("y", "x", "z") => "Bavaria",
            ("z", "y", "x") => "Bremen",
            ("z", "x", "y") => "Hamburg",            
            (_, _, _) => "Germany"
        };
        
    }
}
