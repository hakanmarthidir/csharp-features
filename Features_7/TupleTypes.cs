using System;

namespace Features_7
{
    public class OldTupleUsing
    {

        public Tuple<int, string, string, string> GetUserById(int userId)
        {
            var user = new Tuple<int, string, string, string>(1, "xxx", "yyy", "xxx@yyy.com");
            return user;
        }

        public OldTupleUsing()
        {
            Tuple<int, string, string, string> user = GetUserById(1);

            var i1 = user.Item1;
            var i2 = user.Item2;
            var i3 = user.Item3;
            var i4 = user.Item4;
        }
    }

    class TupleTypes
    {
        //Sample 1 
        public (int, string, string, string) GetUserById1(int userId) // Tuple Type
        {
            int id = 1;
            string firstName = "xxx";
            string lastName = "yyy";
            string email = "xxx@yyy.com";
            return (id, firstName, lastName, email); // Tuple Literal
        }

        public (int Id, string FirstName, string LastName, string Email) GetUserById2(int userId) // Tuple Type
        {

            int id = 1;
            string firstName = "xxx";
            string lastName = "yyy";
            string email = "xxx@yyy.com";

            return (id, firstName, lastName, email); // Tuple Literal

            //veya 
            //return (Id: id, FirstName: firstName, LastName: lastName, Email: email);
        }

        //Sample 2
        //(string Alpha, string Beta) namedLetters = ("a", "b");
        //(string First, string Second) firstLetters = (Alpha: "a", Beta: "b");
        public TupleTypes()
        {
            //İsimlendirme yoksa Item1 -2 diye gider. 
            var userList1 = GetUserById1(1);
            Console.WriteLine($"{userList1.Item1},{userList1.Item2},{userList1.Item3}");

            //Isimlendirme yaptıgımız için cagirabiliriz. 
            var userList2 = GetUserById2(1);
            Console.WriteLine($"{userList2.Id},{userList2.FirstName},{userList2.LastName}");

        }
    }
}
