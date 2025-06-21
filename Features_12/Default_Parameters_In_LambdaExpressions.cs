namespace Features_12
{
    public class DefaultParameterInLambda
    {
        Func<string, string> Greet = (string name = "Hakan") => $"Hello, {name}!";
        Func<int, int, int> Multiply = (int x = 1, int y = 1) => x * y;

        Action<string, string> Log = (string message = "Unknown error", string level = "INFO") =>
        {
            Console.WriteLine($"[{level}] {message}");
        };

        public DefaultParameterInLambda()
        {
            Console.WriteLine(Multiply(1, 3));
            Console.WriteLine(Greet("M"));
            Log("An error occurred", "DEBUG");
            
        }
    }
}
