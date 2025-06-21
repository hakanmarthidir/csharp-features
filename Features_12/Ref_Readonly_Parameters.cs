using System.Drawing;

namespace Features_12
{

    readonly struct MyPoint(int X, int Y)
    {
        public override string ToString() => $"({X}, {Y})";
    }

    internal class RefReadonlyParameters
    {

        void Print(in MyPoint p) { } // C# 7.2+

        //USAGE
        void PrintPoint(ref readonly MyPoint p) // C# 12
        {
            Console.WriteLine(p);
        }

        //you can use it with big structs and you can read without creating a copy. It creates a performance.
        //for example use with matrix

        public RefReadonlyParameters()
        {
            //Performant and secure way
            var pt = new MyPoint(10, 20);
            //call with ref
            PrintPoint(ref pt);


            //instead of in samples 
            var pt1 = new MyPoint(5, 6);
            PrintWithIn(pt1);                       // if you define with "in", no need to call with "ref"
            PrintWithRefReadonly(ref pt1);         // you should call with "ref"
        }

        //USAGE : Instead of In, use ref readonly 
        void PrintWithIn(in MyPoint p) => Console.WriteLine(p);
        void PrintWithRefReadonly(ref readonly MyPoint p) => Console.WriteLine(p);


        //USAGE : using with Switch 
        void PrintPointKind(ref readonly Point p)
        {
            Console.WriteLine(p switch
            {
                { X: 0, Y: 0 } => "Origin",
                { X: > 0, Y: > 0 } => "First quadrant",
                _ => "Somewhere else"
            });
        }


    }
}
