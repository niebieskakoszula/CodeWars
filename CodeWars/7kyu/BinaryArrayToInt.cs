//https://www.codewars.com/kata/578553c3a1b8d5c40300037c/csharp

namespace CodeWars.Core._7kyu;

public class BinaryArrayToInt
{
    public static int BinaryArrayToNumber(int[] binaryArray)
    {
        return binaryArray.Aggregate(0, (acc, x) => acc * 2 + x);
    }
}
