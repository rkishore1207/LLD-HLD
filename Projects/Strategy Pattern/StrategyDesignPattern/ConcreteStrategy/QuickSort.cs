
namespace StrategyDesignPattern.ConcreteStrategy
{
    public class QuickSort : ISortStrategy
    {
        public List<string> Sort(List<string> students)
        {
            Console.WriteLine("Quick Sort");
            return SortArray(students, 0, students.Count - 1);
        }

        public List<string> SortArray(List<string> array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[(leftIndex + rightIndex) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[i].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);

            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            return array;
        }
    }
}
