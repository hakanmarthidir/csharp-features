using System.Collections.Generic;

namespace Features_6
{
    class IndexInitializers
    {
        public IndexInitializers()
        {
            //Old Way
            List<string> messages = new List<string>
            {
                "Page not Found",
                "Page moved, but left a forwarding address.",
                "The web server can't come out to play today."
            };


            //New Way
            Dictionary<int, string> webErrors = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };

        }
    }

}
