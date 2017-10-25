using System;

namespace Features_6
{
    public class ExpressionBodiedMethods
    {

        public string MyPropertyNew => "fkjjdshhfjsdf";
        public string MyPropertyOld { get { return "sdkfhkjsdf"; } }

        //Old way
        public void OldLog(string str)
        {
            Console.WriteLine(str);
        }

        //New Way => tek satır bir kod varsa
        public void NewLog(string str) => Console.WriteLine(str);


    }

}
