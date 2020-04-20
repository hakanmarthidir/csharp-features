using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{
    public enum CustomerType
    {
        Bank,
        Personal,
        ShoppingCenter
    }
    public class SwitchExpressions
    {
        // could be static
        public double GiveRate(CustomerType customer, int customerCount) => customer switch
    {
        CustomerType.Bank => Calculate(customerCount, 1),
        CustomerType.Personal => Calculate(customerCount, 2),
        CustomerType.ShoppingCenter => Calculate(customerCount, 3),
        _ => Calculate(customerCount, 0)
    };

        private double Calculate(int customerCount, int multiplyValue)
        {
            return customerCount * multiplyValue;
        }
    }
}
