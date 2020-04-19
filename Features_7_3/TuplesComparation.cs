using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features_7_3
{

    // Artık tuple valuları == ve != karsılastırmaları ile denetlenebilir. 
    class TuplesComparation
    {
        public Tuple<int, string, string, string> GetUserById(int userId)
        {
            var user = new Tuple<int, string, string, string>(userId, "xxx", "yyy", "xxx@yyy.com");
            return user;
        }

        public bool UserComparation()
        {
            var user1 = GetUserById(1);
            var user2 = GetUserById(2);

            //Eskiden
            //var equalUser = user1.Item1.Equals(user2.Item1);
            //return equalUser;

            var comparation = user1.Item1 == user2.Item1;
            //var comparation = user1.Item1 != user2.Item1;
            return comparation;        
        }

    }
}
