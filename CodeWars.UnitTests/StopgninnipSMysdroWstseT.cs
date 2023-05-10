namespace CodeWars.UnitTests
{
    public class StopgninnipSMysdroWstseT
    {
        [Fact]
        public void SimpleTest()
        {
            Assert.Equal("emocleW", StopgninnipSMysdroW.SpinWords("Welcome"));
        }
        [Fact]
        public void LenghtTest_SingleWord()
        {
            Assert.Equal("Hey wollef sroirraw", StopgninnipSMysdroW.SpinWords("Hey fellow warriors"));
        }
        [Fact]
        public void LenghtTest_AllWords()
        {
            Assert.Equal("This is a test", StopgninnipSMysdroW.SpinWords("This is a test"));
        }
        [Fact]
        public void LenghtTest_AllExceptOneWord()
        {
            Assert.Equal("This is rehtona test", StopgninnipSMysdroW.SpinWords("This is another test"));
        }
        [Fact]
        public void RandomTest()
        {
            Assert.Equal("You are tsomla to the last test", StopgninnipSMysdroW.SpinWords("You are almost to the last test"));
        }
        [Fact]
        public void RandomTest2()
        {
            Assert.Equal("Just gniddik ereht is llits one more", StopgninnipSMysdroW.SpinWords("Just kidding there is still one more"));
        }
    }
}
