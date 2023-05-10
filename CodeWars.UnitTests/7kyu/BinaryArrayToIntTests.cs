namespace CodeWars.UnitTests._7kyu;

public class BinaryArrayToIntTests
{
    [Fact]
    public void BinaryArrayToNumber_GivenEmptyArray_ReturnsZero()
    {
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { }).Should().Be(0);
    }
    [Fact]
    public void BinaryArrayToNumber_GivenArrayWithOneElement_ReturnsThatElement()
    {
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 0 }).Should().Be(0);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1 }).Should().Be(1);
    }
    [Fact]
    public void BinaryArrayToNumber_GivenArrayWithManyElements_ReturnsDecimalValue()
    {
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 0, 0 }).Should().Be(0);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 0, 1 }).Should().Be(1);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 0 }).Should().Be(2);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1 }).Should().Be(3);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 0, 0 }).Should().Be(4);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 0, 1 }).Should().Be(5);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1, 0 }).Should().Be(6);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1, 1 }).Should().Be(7);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 0, 0, 0 }).Should().Be(0);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1, 1, 1 }).Should().Be(15);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1, 1, 1, 1 }).Should().Be(31);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1, 1, 1, 1, 1 }).Should().Be(63);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1, 1, 1, 1, 1, 1 }).Should().Be(127);
        BinaryArrayToInt.BinaryArrayToNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }).Should().Be(255);
    }
}
