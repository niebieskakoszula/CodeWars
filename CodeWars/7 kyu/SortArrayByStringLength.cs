//https://www.codewars.com/kata/57ea5b0b75ae11d1e800006c

namespace CodeWars.Core;

public static class SortArrayByStringLength
{
    public static string[] SortByLength(string[] array)
    {
        return array.OrderBy(e => e.Length).ToArray();
    }
}
