using System;

namespace Features_3
{

    public static class StringExtension
    {
        public static string GetFirstThreeAndLower(this String str)
        {
            return str.Substring(0, 3).ToLower();
        }
    }

    class ExtensionMethods
    {
        public ExtensionMethods()
        {
            string s = "sjkfhkjsdfh ksljdfkjlsd hkljhsdlfkj hsdkhf";
            //Normal kosullarda boyle bir string methodu yok. Yukarıdaki yazım sekline gore istenilen sekilde gelistirilebilir. 
            string i = s.GetFirstThreeAndLower();
            System.Console.WriteLine(i);
        }
    }


}
