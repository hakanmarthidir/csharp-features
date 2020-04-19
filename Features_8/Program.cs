using System;

namespace Features_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadOnlyMembers
            var readStruct = new ReadOnlyMembers();
            readStruct.Name = "Michael";
            readStruct.Surname = "Jordan";

            Console.WriteLine(readStruct.GiveFullName());

            // Default Interface Methods
            var mockStudents = new System.Collections.Generic.List<string>() { "a", "b", "c" };

            IStudentRecorder defInterface = new DefaultInterfaceMethods();
            defInterface.RecordAllStudents(mockStudents);
            defInterface.RecordStudents(mockStudents);
            defInterface.RecordStudent("c");

            //

            Console.Read();
        }
    }
}
