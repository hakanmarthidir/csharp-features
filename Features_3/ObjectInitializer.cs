namespace Features_3
{

    class Student
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class ObjectInitializer
    {
        public ObjectInitializer()
        {
            // Student nesnesi için dolu bir constructor olusturmadık. ancak bu sekilde yazabilir ve istedigimiz parametrelere atama yapabiliriz. 
            Student s = new Student { X = 1, Y = 2 };
        }
    }


}
