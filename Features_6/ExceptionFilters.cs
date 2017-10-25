using System;
using System.Threading;

namespace Features_6
{
    class ExceptionFilters
    {
        public ExceptionFilters()
        {            
            try
            {
                
            }
            catch (Exception e) when ((DateTime.Now.DayOfWeek == DayOfWeek.Saturday) || (DateTime.Now.DayOfWeek == DayOfWeek.Sunday))
            {
                
            }
           
            try
            {
                
            }
            catch (Exception e) when (Thread.CurrentPrincipal.Identity.Name == "XXX")
            {
                
            }

        }
    }

}
