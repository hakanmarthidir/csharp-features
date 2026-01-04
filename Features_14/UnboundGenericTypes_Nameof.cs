using System;
using System.Collections.Generic;
using System.Text;

namespace Features_14
{
    internal class UnboundGenericTypes_Nameof
    {
        public UnboundGenericTypes_Nameof()
        {

            // valid on C# 14:
            string listName = nameof(List<>);             // "List"
            string dictName = nameof(Dictionary<,>);      // "Dictionary"
            string funcName = nameof(Func<,,>);           // "Func"

            //In earlier versions of C#, only closed generic types, such as List<int>, could be used to return the List name.

            //on DI registration ->
            //services.AddScoped(typeof(Repository<>));
            //logger.LogInformation("Registered generic type: {Type}", nameof(Repository<>));

        }
    }
}
