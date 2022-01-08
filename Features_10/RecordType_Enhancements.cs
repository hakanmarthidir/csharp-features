
namespace Features_10
{
    //C# 9 
    //record with class (as reference type stores in heap) same definition MyRecord1 and MyRecord2
    public record class MyRecord1(string Name);
    public record MyRecord2(string Name);


    //C# 10
    //A. record with struct (as value type stores in stack) normally it is not valid on C# 9 but now possible with C# 10
    //if you have performance issues you can check this usage out.
    public record struct MyRecord3(string Name);
    public readonly record struct MyRecord4
    {
        public int Id { get; init; } = default!;
        public string Name { get; init; }
    }

    public class MyTestClassForRecord
    {
        public MyTestClassForRecord()
        {
            var record4 = new MyRecord4() { Id = 1, Name = "first assigned name" };
            //B. we made first assignment on Name and Id. 
            //Compiler Error : we will have compiler error if we call code below. 
            //record4.Name = "second assigment";

            //C. a record struct with "with" keyword
            var record5 = record4 with { Id = 2 };

            //D. struct Equals Comparation
            var record6 = new MyRecord4() { Id = 1, Name = "first assigned name" };
            Console.WriteLine(record4.Equals(record6));
            //E. ToString method on struct record : built in formatting for display
            Console.WriteLine(record4);
            
        }
    }

    //F. SEALED TOSTRING METHOD
    //in c#9 defining sealed toString() is not allowed. however in c#10 you can define. 
    // in c# 9 just this allowed -> public override string ToString()
    public record SealedString
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public sealed override string ToString()
        {
            return $"{Name}__{Id}";
        }
    }
}
