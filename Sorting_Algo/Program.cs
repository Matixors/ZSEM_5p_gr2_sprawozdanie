using System;

namespace Sorting_Algo
{
    public class CountingSort
    {
        public static int[] Sort(int[] array, int minValue, int maxValue)
        {
            int[] countArray = new int[maxValue - minValue + 1];
            int[] sortedArray = new int[array.Length];

            foreach (var num in array)
            {
                countArray[num - minValue]++;
            }

            int sortedIndex = 0;
            for (int i = 0; i < countArray.Length; i++)
            {
                while (countArray[i] > 0)
                {
                    sortedArray[sortedIndex++] = i + minValue;
                    countArray[i]--;
                }
            }

            return sortedArray;
        }

        public static int[] GetInputArray()
        {
            // Uproszczony przykład na potrzeby testów
            return new int[] { 3, -2, 5, 0, -8, 10};
        }

        public static bool ValidArray(int[] array)
        {
            // Przyjmijmy ramy dla tablicy w przedziale (0,100)
            return array.Length > 0 && array.Length <=100;
        }

        public static void DisplaySortedArray(int[] SortedArray)
        {
            Console.WriteLine("Posortowana tablica: " + string.Join(", ", SortedArray));
        }

        public static void Main(string[] args)
        {
            int[] arr = GetInputArray();
            if (ValidArray(arr))
            {
                int minValue = arr.Min();
                int maxValue = arr.Max();
                int[] sortedArray = CountingSort.Sort(arr, minValue, maxValue);
                DisplaySortedArray(sortedArray);
            }
            else
            {
                Console.WriteLine("Niepoprawne dane wejściowe");

            }
        }
    }
}
