using static IndexerPractice.Indexer;

namespace IndexerPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            // get value through indexer
            Console.WriteLine( company[1] );
            // set value throug indexer
            company[2] = "Jadeja";
            Console.WriteLine(company[2]);
        }
    }
}
