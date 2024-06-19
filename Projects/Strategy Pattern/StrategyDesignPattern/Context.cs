namespace StrategyDesignPattern
{
    public class Context
    {
        private readonly ISortStrategy _sortStrategy;
        private readonly List<string> _students;

        public Context(ISortStrategy sortStrategy, List<string> students)
        {
            _sortStrategy = sortStrategy;
            _students = students;
        }

        public List<string> Sort()
        {
            return _sortStrategy.Sort(_students);
        }
    }
}
