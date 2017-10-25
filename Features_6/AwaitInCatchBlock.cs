using System;
using System.IO;
using System.Threading.Tasks;

namespace Features_6
{
    public class AwaitInCatchBlock
    {
        //public class awaitincatchandfinally
        //{
        //    public static void Main(string[] args)
        //    {
        //        FileRead fr = new FileRead();
        //        Console.WriteLine(" Class Object Created Successfully!\n");
        //        fr.filreadoperation();
        //        Console.ReadKey();
        //    }
        //}
        public class FileRead
        {
            public async void filreadoperation()
            {
                try
                {
                    StreamReader sr = File.OpenText("D:\\data.txt");
                    Console.WriteLine(" The first line of the file is:");
                    sr.Close();
                }
                catch { await FileNotFound(); }
                finally { await ExitProgram(); }
            }
            private async Task FileNotFound()
            {
                Console.WriteLine(" File not found. Please check the file name and file location.");
            }
            private async Task ExitProgram()
            {
                Console.WriteLine("\n Press any key to exit");
            }
        }
    }

}
