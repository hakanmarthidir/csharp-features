namespace Features_12
{
    internal class ParamsSpan
    {
        //Preview Feature : <LangVersion>preview</LangVersion> was added into csproj
        //the aim is using the ReadOnlySpan<T> and Span<T> with params keyword.         
        void PrintNames(params ReadOnlySpan<string> names)
        {
            foreach (var name in names)
                Console.WriteLine($"{name}");
        }

        int Sum(params ReadOnlySpan<int> numbers)
        {
            int total = 0;
            foreach (var n in numbers)
                total += n;
            return total;
        }


        void ReportErrors(params ReadOnlySpan<string> messages)
        {
            foreach (var msg in messages)
                Console.WriteLine($"[ERROR]: {msg}");
        }


        // Scenarios for When----
        // Performance is critical
        // decrease the GC loads
        // Mobile and Embedded systems
        // big string arrays and slicing too much


        public ParamsSpan()
        {
            PrintNames("A", "B", "C");

            Console.WriteLine(Sum(1, 2, 3, 4, 5)); // 15


            string[] logs = ["File not found", "Access denied", "Network timeout"];
            ReportErrors(logs[..2]);  // only first 2 messages
        }


    }
}
