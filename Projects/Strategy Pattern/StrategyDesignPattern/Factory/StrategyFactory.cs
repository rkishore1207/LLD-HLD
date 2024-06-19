using StrategyDesignPattern.ConcreteStrategy;

namespace StrategyDesignPattern.Factory
{
    public class StrategyFactory : IStrategyFactory
    {
        public ISortStrategy CreateStrategy(string strategy)
        {
            switch (strategy.ToLower())
            {
                case "merge":
                    return new MergeSort();
                case "quick":
                    return new QuickSort();
                case "shell":
                    return new ShellSort();
                default:
                    return new MergeSort();
            }
        }
    }
}
