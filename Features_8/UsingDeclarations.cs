using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Features_8
{
    public class UsingDeclarations
    {

        public void WriteToDatabaseClassic()
        {
            using (var connection = new SqlConnection("Server=.;Database=BlaBla;Integrated Security=True"))
            {
                SqlCommand com = new SqlCommand("Your command", connection);
            }
        }

        // New Using Declaration
        public void WriteToDatabaseNewStyle()
        {
            using var connection = new SqlConnection("Server=.;Database=BlaBla;Integrated Security=True");
            SqlCommand com = new SqlCommand("Your command", connection);
        }

    }
}
