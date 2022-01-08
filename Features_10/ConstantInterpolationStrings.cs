using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_10
{
    internal class ConstantInterpolationStrings
    {
        const string Interpolation1 = "https://";
        const string Interpolation2 = "www.";
        const string Interpolation3 = "Test";
        public ConstantInterpolationStrings()
        {
            //c#9
            //it was not possible 
            //const string url = $"{Interpolation1}{Interpolation2}";
            //but you can do that -> const string url = Interpolation1 + Interpolation2;

            //c# 10
            //it is possible on constant variables
            const string url = $"{Interpolation1}{Interpolation2}";

            //in addition to that you can use this way on attributes 
            //for example 
            
        }

        [Obsolete($"Use this {Interpolation3} method ")]
        void SomeMethod()
        { 
        }
    }
}
