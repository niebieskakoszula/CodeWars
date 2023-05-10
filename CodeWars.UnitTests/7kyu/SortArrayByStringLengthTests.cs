namespace CodeWars.UnitTests;

public class SortArrayByStringLengthTests
{
    [Fact]
    public void ExampleTests()
    {
        Assert.Equal(new string[] { "I", "To", "Beg", "Life" }, 
            SortArrayByStringLength.SortByLength(new string[] { "Beg", "Life", "I", "To" }));

        Assert.Equal(new string[] { "", "Pizza", "Brains", "Moderately" }, 
            SortArrayByStringLength.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));

        Assert.Equal(new string[] { "Short", "Longer", "Longest" }, 
            SortArrayByStringLength.SortByLength(new string[] { "Longer", "Longest", "Short" }));
    }
}
