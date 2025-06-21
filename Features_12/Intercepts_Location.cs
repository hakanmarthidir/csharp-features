namespace Features_12
{
    internal class InterceptsLocation
    {
        // if you are source generator, this will be more helpful to you
    }

    public static class UserInfo
    {
        public static string GetName() => "Original";
    }

    //[InterceptsLocation("Program.cs", line: 9, column: 1)]
    //static string GetName() => "Intercepted by Source Generator!";


    //Unittests
    //Logging-Profiling
    //Lightweight AOP


}
