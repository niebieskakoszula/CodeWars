namespace CodeWars.UnitTests._6kyu
{
    public class CountingDuplicatesTests
    {
        [Theory]
        [InlineData("abcde", 0)]
        [InlineData("abcdea", 1)]
        [InlineData("indivisibility", 1)]
        [InlineData("aabBcde", 2)]
        [InlineData("Indivisibility", 1)]
        [InlineData("Indivisibilities", 2)]
        [InlineData("aAbBcC", 3)]
        [InlineData("daAbBcC11", 4)]
        public void DuplicateCount_ShouldReturnExpected(string str, int expected)
        {
            // Arrange
            // Act
            var actual = CountingDuplicates.DuplicateCount(str);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
