using System;
using System.Collections.Generic;
using System.Text;

namespace Features_14
{
    internal class SimpleLambdaParametersWithModifiers
    {
        //You can add parameter modifiers, such as scoped, ref, in, out, or ref readonly to lambda expression parameters without specifying the parameter type:

        //C#13 and before        
        delegate bool TryParse<T>(string text, out T result);
        TryParse<int> parseOld = (string text, out int result) => int.TryParse(text, out result);

        //C#14 (modifiers + identifier)
        //you can write ref, in, out, scoped, ref readonly without identifing the type
        TryParse<int> parse = (text, out result) => int.TryParse(text, out result);


        //sample with REF
        public delegate void Mutator(ref int value);        
        Mutator doubleIt = (ref v) => v *= 2;

        public void SampleWithRef()
        {
            int x = 5;
            doubleIt(ref x);   // x = 10
        }


        //IN 
        public delegate int Measure(in ReadOnlySpan<byte> data);
        Measure sum = (in data) => data.IsEmpty ? 0 : data[0];


        //Scoped REF
        public delegate void Capture(scoped ref int p);
        Capture log = (scoped ref p) => Console.WriteLine(p);


        //OUT
        //delegate bool TryParseOut<T>(string text, out T result);
        //TryParse<int> parseOut = (text, out result) => int.TryParse(text, out result);


    }
}
