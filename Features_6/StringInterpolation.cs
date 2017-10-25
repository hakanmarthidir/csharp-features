using System;

namespace Features_6
{   

    class StringInterpolation
    {
        public string Name { get; set; }
        public string Hour { get; set; }

        public StringInterpolation()
        {
            Console.WriteLine("Name = {0}, hours = {1:hh}", Name, Hour);
            Console.WriteLine($"Name = {Name}, hours = {Hour:hh}");

            var name = "Horace";
            var age = 34;
            var s1 = $"He asked, \"Is your name {name}?\", but didn't wait for a reply.";
            Console.WriteLine(s1);

            var name2 = "Bartholomew";
            FormattableString s3 = $"Hello, {name2}!";
            Console.WriteLine($"String: {s3.Format}");
            Console.WriteLine($"Arguments: {s3.ArgumentCount}");
            Console.WriteLine($"Result string: {s3}");
        }
    }

}
