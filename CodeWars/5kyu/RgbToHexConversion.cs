//https://www.codewars.com/kata/513e08acc600c94f01000001

namespace CodeWars.Core._5kyu
{
    public class RgbToHexConversion
    {
        public static string Rgb(int r, int g, int b)
        {
            return $"{ToHex(r)}{ToHex(g)}{ToHex(b)}";
        }
        private static string ToHex(int value)
        {
            if (value < 0)
                return "00";
            if (value > 255)
                return "FF";
            return value.ToString("X2");
        }
    }
}
