using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algo
{
    public class IntegrationTests
    {
        /// <summary>
        /// Test sprawdzający pełne działanie programu
        /// </summary>

        [Fact]
        public void FullIntegrationTest_ValidInput_ReturnSortedArray()
        {
            int[] inputArray = CountingSort.GetInputArray();

            bool isValid = CountingSort.ValidArray(inputArray);
            Assert.True(isValid);

            int minValue =  inputArray.Min();
            int maxValue = inputArray.Max();

            int[] sortedArray = CountingSort.Sort(inputArray, minValue, maxValue);

            int[] expected = { -8, -2, 0, 3, 5, 10 };

            Assert.Equal(expected, sortedArray);
        }

        /// <summary>
        /// Test z niepoprawnymi danymi (zbyt dużo) wyjście poza zakres (0,100)
        /// </summary>

        [Fact]
        public void FullIntegrationTest_Invalid_ReturnValidationArray()
        {
            int[] inputArray = new int[105];

            bool isValid = CountingSort.ValidArray(inputArray);

            Assert.False(isValid);
        }

    /// <summary>
    /// Test sprawdzający pełne działanie programu dla danych zawierających powtarzające się wartości.
    /// </summary>
    [Fact]
    public void FullIntegrationTest_DuplicateValues_ReturnsSortedArrayWithDuplicates()
    {
        int[] inputArray = { 5, 3, 5, 1, 3, 2, 5, 3 };

        bool isValid = SortingProgram.ValidateInputArray(inputArray);
        Assert.True(isValid);

        int minValue = inputArray.Min(); 
        int maxValue = inputArray.Max();

        int[] sortedArray = CountingSort.Sort(inputArray, minValue, maxValue);

        int[] expected = { 1, 2, 3, 3, 3, 5, 5, 5 };

        Assert.Equal(expected, sortedArray);
    }
    }
}
