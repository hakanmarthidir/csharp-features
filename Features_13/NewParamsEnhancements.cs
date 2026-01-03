namespace Features_13
{
    public class NewParamsClass
    {

        //params parameter list were enhanced so you can use IList<>, ICollection, IReadOnlyList etc.

        static void PrintValues(params IEnumerable<int> values) 
        {
            //todo
        }

        static int ReturnTotalValues(params ReadOnlySpan<int> values) 
        {
            int total = 0;
            foreach (var n in values)
                total += n;
            return total;
        }

        static void LogInfo(params IEnumerable<string> messages)
        {
            foreach (var message in messages) { }
        }


    }
}
