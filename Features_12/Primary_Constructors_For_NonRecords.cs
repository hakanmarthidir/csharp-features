namespace Features_12
{
    class Person(string name, int age)
    {
        public void Print() => Console.WriteLine($"{name} is {age} years old.");
    }

    class Product(string name, decimal price)
    {
        public string Name => name;
        public decimal Price => price;

        public void PrintInfo()
        {
            Console.WriteLine($"{name} costs {price:C}");
        }
    }

    //With Init
    class User(string username, string email)
    {
        public string Username { get; init; } = username;
        public string Email { get; init; } = email;
    }

    //With Inheritance
    class Animal(string name)
    {
        public void Speak() => Console.WriteLine($"{name} is making a sound.");
    }

    class Dog(string name, string breed) : Animal(name)
    {
        public void Bark() => Console.WriteLine($"{name} the {breed} is barking.");
    }

    //Primary Constructor + Normal
    class Counter(int start)
    {
        private int _count = start;

        public void Increment() => Console.WriteLine(++_count);
    }


}
