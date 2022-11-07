namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        string Returnstring;
        public string Determine(int input)
        {

            if (input % 3 == 0)
            {
                Returnstring += "Foo";
            }
            if (input % 5 == 0)
            {
                Returnstring += "Bar";
            }
            if (input % 7 == 0)
            {
                Returnstring += "Qix";
            }
            if (input % 3 != 0 && input % 5 != 0 && input % 7 != 0)
            {
                return input.ToString();
            }

            return Returnstring;
        }
    }
}