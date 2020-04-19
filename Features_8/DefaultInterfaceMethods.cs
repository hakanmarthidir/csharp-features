using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{  

    public interface IStudentRecorder 
    {
        void RecordStudent(string name);
        void RecordStudents(List<string> studentNames)
        {
            foreach (var item in studentNames)
            {
                Console.WriteLine(item);
            }            
        }

        void RecordAllStudents(List<string> studentNames)
        {
            foreach (var item in studentNames)
            {
                RecordStudent(item);
            }            
        }    
    }



    public class DefaultInterfaceMethods : IStudentRecorder
    {
        public void RecordStudent(string name)
        {
            Console.WriteLine(name);
        }
    }
}
