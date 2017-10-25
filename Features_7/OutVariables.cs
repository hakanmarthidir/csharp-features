using System;

namespace Features_7
{
    public class SetOut
    {
        public void AssignVal(out string strName)
        {
            strName = "I am from OUT";
        }
    }

    public class OutVariables
    {
        public OutVariables()
        {
            //Old Way
            var myClass = new SetOut();
            string strOut;
            myClass.AssignVal(out strOut);

            //New Way
            myClass.AssignVal(out string testVal);
            //or
            myClass.AssignVal(out var testVal2);
            Console.Write(testVal);
        }


    }
}
