namespace CodeWars.UnitTests._6kyu
{
    public class DeleteNthOccurrencesTests
    {
        [Theory]
        [InlineData(new int[] {21, 37, 21, 22}, 1, new int[] { 21, 37, 22 })]
        [InlineData(new int[] {1, 1, 3, 3, 7, 2, 2, 2, 2}, 3, new int[] { 1, 1, 3, 3, 7, 2, 2, 2 })]
        public void DeleteNthOccurrencesTest(int[] input, int x, int[] expected)
        {
            Assert.Equal(expected, DeleteNthOccurrences.DeleteNth(input, x));
        }
    }
}
