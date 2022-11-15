using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Features_11
{
    public class Student
    {
        public required string Name { get; init; }
        public string MiddleName { get; init; }
        public required string LastName { get; init; }

    }

    public class StudentFactory
    {
        public static Student GenerateStudent()
        {
            //without LastName property, you will get this message : Required member 'Student.LastName' must be set in the object initializer or attribute constructor

            return new Student() { Name = "Michael", LastName="" };
        }
    }
}
