
namespace StrategyDesignPattern.ConcreteStrategy
{
    public class MergeSort : ISortStrategy
    {
        public List<string> Sort(List<string> students)
        {
            Console.WriteLine("Merge Sort");
            return SortArray(students, 0, students.Count - 1);
        }

        public List<string> SortArray(List<string> array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }

        public void MergeArray(List<string> array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new string[leftArrayLength];
            var rightTempArray = new string[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array.ElementAt(left + i);
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (string.Equals(leftTempArray[i], rightTempArray[j]))
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }
    }
}
