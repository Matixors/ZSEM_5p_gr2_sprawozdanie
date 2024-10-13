using System;

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

    static void Main(string[] args)
    {
        int[] arr = { 11, 5, 54, 23, 6};
        var sorted = Sort(arr, arr.Min(), arr.Max());
        Console.WriteLine("Posortwoana tablica: " + string.Join(", ", sorted));
    }
}