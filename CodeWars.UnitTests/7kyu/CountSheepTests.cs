namespace CodeWars.UnitTests;

public class CountSheepTests
{
    [Fact]
    public void BasicTest1()
    {
        CountSheeps counter = new CountSheeps();
        int[] friday = new int[] { 1, 2 };
        int[] saturday = new int[] { 3, 4 };
        Assert.Equal(5, counter.lostSheep(friday, saturday, 15));
    }
    [Fact]
    public void BasicTest2()
    {
        CountSheeps counter = new CountSheeps();
        int[] friday = new int[] { 3, 1, 2 };
        int[] saturday = new int[] { 4, 5 };
        Assert.Equal(6, counter.lostSheep(friday, saturday, 21));
    }

    [Fact]
    public void BasicTest3()
    {
        CountSheeps counter = new CountSheeps();
        int[] friday = new int[] { 5, 1, 4 };
        int[] saturday = new int[] { 5, 4 };
        Assert.Equal(10, counter.lostSheep(friday, saturday, 29));
    }
}