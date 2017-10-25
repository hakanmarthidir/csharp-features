using System;

namespace Features_7_1
{
    public class TupleProjectionInitializer
    {
        public TupleProjectionInitializer()
        {
            var firstName = "Hakan";
            var lastName = "Hıdır";
            var dateOfBirth = new DateTime(1982, 1, 1);

            //c# 7.0
            var person = (firstName: firstName, lastName: lastName, dateOfBirth: dateOfBirth);
            var x = person.firstName;   // "Hakan"
            var y = person.lastName;    // "Hıdır"
            var z = person.dateOfBirth;  // 1/1/1982

            // C# 7.1, allows "inferred names"
            var person2 = (firstName, lastName, dateOfBirth);
            var a = person2.firstName;   // "Hakan"
            var b = person2.lastName;    // "Hıdır"
            var c = person2.dateOfBirth; // 1/1/1982

            //Mixed Tuple
            var stringContent = "Chicago Bulls";
            var mixedTuple = (42, stringContent);

            //Sample
            var pt1 = (X: 3, Y: 0);
            var pt2 = (X: 3, Y: 4);
            var xCoords = (pt1.X, pt2.X);

        }
    }
}
