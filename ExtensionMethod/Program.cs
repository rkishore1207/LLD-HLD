namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "3Kishore";
            Console.WriteLine(value.TransformFirstCharacter());

            var countryString = countries.Aggregate("Japan", (a, b) => a + ", " + b);
            Console.WriteLine(countryString);

            IEnumerable<string> result = countries.SkipWhile(country => country.Length > 2);
            foreach (var country in result)
            {
                Console.WriteLine(country);
            }
        }
    }
}
