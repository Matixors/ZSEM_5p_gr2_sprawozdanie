
namespace Sorting_Algo
{
    public class UnitTest1
    {
        [Fact]
        public void Sort_ValidPositiveNumbers()
        {
            int[] arr = { 4, 5, 6, 3, 2, 1 };
            int[] expected_result = { 1, 2, 3, 4, 5, 6 };

            var result = CountingSort.Sort(arr, arr.Min(), arr.Max());

            Assert.Equal(expected_result, result);
        }

        [Fact]
        public void Sort_ValidNegativeNumbers()
        {

            int[] arr = { 4, -5, 6, 3, -2, 1 };
            int[] expected_result = { -5, -2, 1, 3, 4, 6 };

            var result = CountingSort.Sort(arr, arr.Min(), arr.Max());

            Assert.Equal(expected_result, result);

        }

        [Fact]
        public void Sort_AleradySorted()
        {
            int[] arr = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] expected_result = { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = CountingSort.Sort(arr, arr.Min(), arr.Max());

            Assert.Equal(expected_result, result);
        }

        [Fact]
        public void Sort_ExpectedInvalid()
        {
            int[] arr = { 1, 3, 2 };
            int[] expected_result = { 3, 2, 1 };

            var result = CountingSort.Sort(arr, arr.Min(), arr.Max());

            Assert.Equal(expected_result, result);
        }
    }
}