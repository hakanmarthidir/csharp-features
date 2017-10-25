using System;

namespace Features_7
{
    class TupleDeConstructions
    {

        public (int Id, string FirstName, string LastName, string Email) GetUserById(int userId) // Tuple Type
        {
            int id = 1;
            string firstName = "xx";
            string lastName = "ccc";
            string email = "sss@dd.com";
            return (id, firstName, lastName, email); // Tuple Literal
        }

        public TupleDeConstructions()
        {
            //Tuple Deconstruction
            //Tuple Deconstruction özelliği oluşturduğumuz Tuple tiplerini elementlerine parçalamamıza imkan sağlıyor.

            //Kullanımı
            (int id1, string firstName1, string lastName1, string email1) = GetUserById(1);
            Console.WriteLine($"{id1} - {firstName1} - {lastName1} - {email1}");

            //veya 
            var (id, firstName, lastName, email) = GetUserById(1);
            Console.WriteLine($"{id} - {firstName} - {lastName} - {email}");

            //veya
            int _id;
            string fname;
            string lname;
            string Email;
            (_id, fname, lname, Email) = GetUserById(1);

        }


    }
}
