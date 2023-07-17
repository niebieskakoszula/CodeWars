namespace CodeWars.UnitTests._6kyu
{
    public class WhoLikesItTests
    {
        [Fact]
        public void Tests()
        {
            Assert.Equal("no one likes this", WhoLikesIt.Solve(new string[0]));
            Assert.Equal("Peter likes this", WhoLikesIt.Solve(new string[] { "Peter" }));
            Assert.Equal("Jacob and Alex like this", WhoLikesIt.Solve(new string[] { "Jacob", "Alex" }));
            Assert.Equal("Max, John and Mark like this", WhoLikesIt.Solve(new string[] { "Max", "John", "Mark" }));
            Assert.Equal("Alex, Jacob and 2 others like this", WhoLikesIt.Solve(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
