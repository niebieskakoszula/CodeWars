namespace CodeWars.UnitTests
{
    public class BoolToStringTest
    {
        [Fact]
        public void boolToWord_GivenTrue_ReturnYes()
        {
            Assert.Equal("Yes", BoolToString.boolToWord(true));
        }
        [Fact]
        public void boolToWord_GivenFalse_ReturnNo()
        {
            Assert.Equal("No", BoolToString.boolToWord(false));
        }
    }
}
