namespace Features_12
{

    // to give message to the team...
    [System.Diagnostics.CodeAnalysis.Experimental("MyExperimentalClass")]
    public class ExperimentalAttribute
    {

        [System.Diagnostics.CodeAnalysis.Experimental("CalculateFeature", UrlFormat = "https://test/documenturl")]
        public static void CalculateFeature()
        {
            Console.WriteLine("my experimental feature for calculation...");
        }
    }
}
