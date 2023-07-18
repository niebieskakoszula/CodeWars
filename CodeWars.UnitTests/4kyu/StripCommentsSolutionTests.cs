using CodeWars.Core._4kyu;

namespace CodeWars.UnitTests._4kyu
{
    public class StripCommentsSolutionTests
    {
        [Theory]
        [InlineData("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }, "apples, pears\ngrapes\nbananas")]
        [InlineData("a #b\nc\nd $e f g", new string[] { "#", "$" }, "a\nc\nd")]
        public void StripComments(string text, string[] commentSymbols, string expected)
        {
            Assert.Equal(expected, StripCommentsSolution.StripComments(text, commentSymbols));
        }
    }
}
