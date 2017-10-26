namespace Features_3
{
    class AutoImplementedProperties
    {
        //AutoImplemented
        public int MyProperty { get; set; }
        //OldStyle
        private int _MyProperty2;
        public int MyProperty2
        {
            get { return this._MyProperty2; }
            set { this._MyProperty2 = value; }
        }
    }


}
