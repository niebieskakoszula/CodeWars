namespace CodeWars.UnitTests._6kyu;

public class DuplicateEncoderTests
{
    [Theory]
    [InlineData("din", "(((")]
    [InlineData("recede", "()()()")]
    [InlineData("Success", ")())())")]
    [InlineData("(( @", "))((")]
    public void BasicTest1(string input, string expected)
    {
        Assert.Equal(expected, DuplicateEncoder.DuplicateEncode(input));
    }
}
