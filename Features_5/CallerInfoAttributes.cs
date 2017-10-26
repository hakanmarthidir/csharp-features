using System;
using System.Runtime.CompilerServices;

namespace Features_5
{
    public class CallerInfoAttributes
    {
        //Loglama için kullanılır. 
        //System.Runtime.CompilerServices namespace i altındadir. 
        //[CallerFilePath] :   Kim Cagirdi ? dosyanın pathi.
        //[CallerLineNumber] : Hangi Satırdan Cagrildi?
        //[CallerMemberName] : Cagiranin Adi

        //Method parametrelerine bu attributeleri uygulayabilirsiniz. 

        static void Foo(
    [CallerMemberName] string memberName = null,
    [CallerFilePath] string filePath = null,
    [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(memberName);
            Console.WriteLine(filePath);
            Console.WriteLine(lineNumber);
        }
    }





}
