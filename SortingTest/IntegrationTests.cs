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
    }
}
