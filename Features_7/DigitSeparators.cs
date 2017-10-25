namespace Features_7
{
    class DigitSeparators
    {
        // Literal: Altçizgi (underscore) seperator (ayırıcı)
        // olarak değil dönüş tipi olarak dönüyor
        private static int GetNumber()
        {
            return 5_7_8_123_1;
        }
        // Sonuç => 5781231

        public void XXX()
        {
            var d = 123_456;
            var x = 0xAB_CD_EF;
            var b = 0b1010_1011_1100_1101_1110_1111;
        }
    }
}
