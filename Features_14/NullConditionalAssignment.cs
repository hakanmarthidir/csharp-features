using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Features_14
{
    internal class NullConditionalAssignment
    {

        public NullConditionalAssignment()
        {

            //Before C# 14, you needed to null-check a variable before assigning to a property:
            //if (customer is not null)
            //{
            //    customer.Order = GetCurrentOrder();
            //}

            // with C# 14 -> ?. and ?[] are usable on left side
            // 
            //target?.Member = value;     // if target ≠ null, assign
            //target?[index] = value;     // if target ≠ null, assign  

            //order?.Total += 10;
            //scores?["math"] -= 5;
            //cache?[key] = value;


            //---->
            //EventHandler Sample -> 
            //viewModel?.Loaded += (_, __) => logger.LogInformation("Loaded");


            //---->

            // Previous (C# 13 ve before):
            //if (order != null && order.Customer != null)
            //    order.Customer.LastSeenUtc = DateTime.UtcNow;

            // C# 14:
            //order?.Customer?.LastSeenUtc = DateTime.UtcNow;

        }
    }
}
