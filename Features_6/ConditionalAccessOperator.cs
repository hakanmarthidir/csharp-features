namespace Features_6
{
    class ConditionalAccessOperator
    {
        class Address { public string City { get; set; } }
        class Employee
        {
            public string MyFirstName { get; set; }
            public Address MyAddress { get; set; }
        }
        public ConditionalAccessOperator()
        {
            int? x = null;
            int y = x ?? -1; // x null ise -1 i ata

            var emp = new Employee() { MyAddress = new Address(), MyFirstName = "safsdd" };
            var address1 = emp != null ? emp.MyAddress : null; //old way
            var address2 = emp?.MyAddress; //new way

            var name1 = emp != null ? emp.MyAddress != null ? emp.MyAddress.City : null : null; //old way
            var name2 = emp?.MyAddress?.City; //new way


        }
    }

}
