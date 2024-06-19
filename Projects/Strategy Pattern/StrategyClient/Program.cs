using StrategyDesignPattern;
using StrategyDesignPattern.Factory;

namespace StrategyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() { "Mathan","Kishore","Ajay"};
            IStrategyFactory strategyFactory = new StrategyFactory();
            ISortStrategy mergeStrategy = strategyFactory.CreateStrategy("Merge");
            Context context = new Context(mergeStrategy,students);
            foreach (string student in context.Sort())
            {
                Console.WriteLine(student);
            }
        }
    }
}
