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

            //Dictionary
            var dictionaries = new List<Student>()
            {
                new Student()
                {
                    Name = "Kishore",
                    Age = 21,
                    Country = "India",
                    StudentId = 1
                },
                new Student()
                {
                    Name = "Mathan",
                    Age = 22,
                    Country = "America",
                    StudentId = 2
                },
                new Student()
                {
                    Name = "Mahesh",
                    Age = 23,
                    Country = "China",
                    StudentId = 3
                },
                new Student()
                {
                    Name = "Ajay",
                    Age = 24,
                    Country = "Japan",
                    StudentId = 4
                }
            };

            var dictionaryById = dictionaries.ToDictionary(student => student.StudentId);

            foreach (var dictionary in dictionaryById)
            {
                Console.WriteLine(dictionary.Key + "\t" + dictionary.Value.Name);
            }

            //Lookups
            var lookUps = new List<Student>()
            {
                new Student()
                {
                    Name = "Kishore",
                    Age = 21,
                    Country = "India",
                    StudentId = 1
                },
                new Student()
                {
                    Name = "Mathan",
                    Age = 22,
                    Country = "India",
                    StudentId = 2
                },
                new Student()
                {
                    Name = "Mahesh",
                    Age = 23,
                    Country = "Japan",
                    StudentId = 3
                },
                new Student()
                {
                    Name = "Ajay",
                    Age = 24,
                    Country = "Japan",
                    StudentId = 4
                }
            };

            var lookUpByCountry = lookUps.ToLookup(student => student.Country);

            foreach (var dictionary in lookUpByCountry)
            {
                Console.WriteLine(dictionary.Key);
                foreach (var dictionary2 in lookUpByCountry[dictionary.Key])
                {
                    Console.WriteLine("\t"+dictionary2.Name);
                }
            }
        }
    }
}
