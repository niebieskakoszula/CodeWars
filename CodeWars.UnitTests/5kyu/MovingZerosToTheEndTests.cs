namespace CodeWars.UnitTests._5kyu
{
    public class MovingZerosToTheEndTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }, new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 })]
        [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
        [InlineData(new int[] { 0, 0, 0, 1 }, new int[] { 1, 0, 0, 0 })]
        public void MoveZeroes(int[] arr, int[] expected)
        {
            Assert.Equal(expected, MovingZerosToTheEnd.MoveZeroes(arr));
        }
    }
}
