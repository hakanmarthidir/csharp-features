using static System.Console;

namespace Features_7
{
    class PatternMatching
    {
        public PatternMatching()
        {
            //When anahtar kelimesi ile pattern uygulanabilir. 
            //switch (shape)
            //{
            //    case Circle c:
            //        WriteLine($"circle with radius {c.Radius}");
            //        break;
            //    case Rectangle s when (s.Length == s.Height):
            //        WriteLine($"{s.Length} x {s.Height} square");
            //        break;
            //    case Rectangle r:
            //        WriteLine($"{r.Length} x {r.Height} rectangle");
            //        break;
            //    default:
            //        WriteLine("<unknown shape>");
            //        break;
            //    case null:
            //        throw new ArgumentNullException(nameof(shape));
            //}

        }
        //Sample 1 : o is int i patterni
        public void PrintStars1(object o)
        {
            if (o is null) return;     // constant pattern "null"
            if (!(o is int i)) return; // type pattern "int i"
            WriteLine(new string('*', i));
        }

        //Sample 2 : o is int i patterni
        public void PrintStars2(object o)
        {
            if (o is int i || (o is string s && int.TryParse(s, out i)))
            {
                WriteLine(i);
            }

        }
    }
}
