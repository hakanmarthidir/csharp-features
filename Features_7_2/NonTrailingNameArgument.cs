using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_2
{
    class NonTrailingNameArgument
    {
        public void GiveAnOrder(int orderId, string productName, double price)
        {
            //Sample
        }

        public void GiveAnOrderTest()
        {
            //Methodları yarattıktan sonra parametreleri verirken belirtilen takip sırasına gore vermek zorunda degiliz. 
            //Asagidaki ornekte oldugu gibi parametre adını cagirip degeri atamanız yeterlidir. 
            GiveAnOrder(1, price: 12.45, productName: "test 1");
            GiveAnOrder(price: 23.30, productName: "test 2", orderId: 2);
        }
    }
}
