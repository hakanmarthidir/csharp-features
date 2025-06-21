namespace Features_12
{
    internal class CollectionExpressions
    {
        public string[] Hobbies { get; set; } = ["Reading", "Coding", "Biking"];
        List<string> GetDefaultTags() => ["dev", "csharp", "dotnet"];



        public CollectionExpressions()
        {
            //more simplified definition of collection
            int[] numbers = [1, 2, 3];
            List<string> names = ["Hakan", "Test1"];

            //spread
            int[] part1 = [1, 2];
            int[] part2 = [3, 4];

            int[] all = [..part1, ..part2, 5];  // [1,2,3,4,5]

            //with Span
            Span<int> numbersSpan = [1, 2, 3, 4];
           

            PrintNumbers([10, 20, 30]);
        }

        void PrintNumbers(params int[] nums)
        {
            foreach (var n in nums)
                Console.WriteLine(n);
        }

        


    }
}
