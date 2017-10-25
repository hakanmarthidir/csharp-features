using System.IO;
using System.Threading.Tasks;

namespace Features_7_1
{
    public class AsyncMainMethods
    {
        //7.1 de  
        //Instead of Task.Result or .Task.Wait(), use await

        //Console Applicationlarda Main method async olabilir. 
        static async Task Main(string[] args)
        {
            using (StreamWriter writer = File.CreateText(@"c:\temp\newfile.txt"))
            {
                await writer.WriteLineAsync("Hello World");
            }
        }

        //-----------------------------------------------------------------------
        //Old way
        //static void Main(string[] args)
        //{
        //    MainAsync().GetAwaiter().GetResult();
        //}

        //private static async Task MainAsync()
        //{
        //    using (StreamWriter writer = File.CreateText(@"c:\temp\anewfile.txt"))
        //    {
        //        await writer.WriteLineAsync("Hello");
        //    }
        //}

    }
}
