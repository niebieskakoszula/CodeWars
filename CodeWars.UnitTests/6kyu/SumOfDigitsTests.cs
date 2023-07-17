namespace CodeWars.UnitTests._6kyu
{
    public class SumOfDigitsTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(123, 6)]
        [InlineData(1234, 1)]
        [InlineData(12345, 6)]
        [InlineData(16, 7)]
        [InlineData(942, 6)]
        [InlineData(132189, 6)]
        [InlineData(493193, 2)]
        [InlineData(999999999999, 9)]
        public void DigitalRootTest(long n, int expected)
        {
            Assert.Equal(expected, SumOfDigits.DigitalRoot(n));
        }
    }
}
