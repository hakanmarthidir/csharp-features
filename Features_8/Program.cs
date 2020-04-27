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

            //SwitchExpressions

            var switchObject = new SwitchExpressions();
            Console.WriteLine(switchObject.GiveRate(CustomerType.ShoppingCenter, 10));

            //PropertyPattern
            var student1 = new Student() { Name = "aaa", BahnRegion = BahnRegions.Region2 };
            var student2 = new Student() { Name = "bbb", BahnRegion = BahnRegions.Region3 };

            Console.WriteLine(PropertyPattern.Calculate(student1, 40));
            Console.WriteLine(PropertyPattern.Calculate(student2, 40));

            //Tuple Pattern
            Console.WriteLine(TuplePattern.GiveMyState("y", "z", "x"));

            //Positional Pattern
            Console.WriteLine(PositionalPattern.WhichTriangleIsMine(new MyTriangle(1, 1, 1)));
            Console.WriteLine(PositionalPattern.WhichTriangleIsMine(new MyTriangle(1, 2, 2)));
            Console.WriteLine(PositionalPattern.WhichTriangleIsMine(new MyTriangle(1, 2, 3)));

            //StaticLocalFunc
            StaticLocalFunctions.TriangleFindC(3, 4);

            //Indices and ranges 
            IndicesAndRanges myrange = new IndicesAndRanges();

            //Null assignment operator
            NullAssignmentOperator nullAssigner = new NullAssignmentOperator();

            //String Interpolation
            StringInterpolation.OldStyleStringComposition();
            StringInterpolation.WithStringInterpolation("Hakan", 23);

            //StackAlloc Nested
            StackallocInNestedExpressions.UseStackAllocate(5);

            Console.Read();
        }
    }
}
