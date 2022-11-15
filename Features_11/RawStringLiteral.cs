namespace Features_11
{
    internal class RawStringLiteral
    {

        public static string RawLiteralStringSample1()
        {

            string message = """
                Lorem ipsum Lorem ipsumLorem ipsumLorem ipsum
                    Lorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsum
                        Lorem ipsumLorem "NOT LOREM IPSUM" ipsumLorem ipsumLorem ipsum
                Lorem ipsumLorem ipsumLorem ipsumLorem ipsumLorem ipsum
                """;

            return message;

        }

        public static string RawLiteralStringSample2()
        {
            var htmlMessage = """
                                <element attr="content">
                                    <body>
                                     This line is indented by 4 spaces.
                                    </body>
                                </element>
                              """;

            return htmlMessage;

        }

        public static string RawLiteralStringSample3()
        {
            var longitude = 12;
            var latitude = 45;

            var message = $$"""
                            My location is {{longitude}} - {{latitude}}
                          """;

            return message;

        }
    }
}
