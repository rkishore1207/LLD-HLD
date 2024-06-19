namespace StrategyDesignPattern.Factory
{
    public interface IStrategyFactory
    {
        public ISortStrategy CreateStrategy(string strategy);
    }
}
