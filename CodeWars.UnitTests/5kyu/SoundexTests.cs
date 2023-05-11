namespace CodeWars.UnitTests._5kyu
{
    public class SoundexTests
    {
        [Theory]
        [InlineData("A", "A000")]
        [InlineData("Ab", "A100")]
        [InlineData("Ax", "A200")]
        [InlineData("Ashcraft", "A261")]
        [InlineData("hjaidjaqmfkd", "H232")]
        [InlineData("uryrtkzp", "U663")]
        public void SoundexOneWord(string input, string expected)
        {
            Assert.Equal(expected, Soundex.Encode(input));
        }

        [Theory]
        [InlineData("Hello World", "H400 W643")]
        public void SoundexMultipleWords(string input, string expected)
        {
            Assert.Equal(expected, Soundex.Encode(input));
        }

        [Theory]
        [InlineData("Sarah Connor", "S600 C560")]
        [InlineData("sarah connor", "S600 C560")]
        [InlineData("Sayra Cunnarr", "S600 C560")]
        [InlineData("Serah Coner", "S600 C560")]
        [InlineData("Sarh Connor", "S600 C560")]
        [InlineData("Arnold Schwarzenegger", "A654 S625")] //Shame it's not T800 lol
        public void SoundexArnieTest(string input, string expected)
        {
            Assert.Equal(expected, Soundex.Encode(input));
        }

        [Theory]
        [InlineData("Tim", "T500")]
        [InlineData("Joe", "J000")]
        [InlineData("Ann", "A500")]
        [InlineData("Madge", "M320")]
        public void SoundexShortNames(string input, string expected)
        {
            Assert.Equal(expected, Soundex.Encode(input));
        }

        [Theory]
        [InlineData("uryrtkzp", "U663")]
        public void SoundexStepsOrder(string input, string expected)
        {
            Assert.Equal(expected, Soundex.Encode(input));
        }
    }
}
