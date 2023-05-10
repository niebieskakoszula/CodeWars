using System.Text.RegularExpressions;

namespace CodeWars.Core._7kyu;

public static class RegexValidatePin
{
    static readonly string pattern = @"\A(\d{4}|\d{6})\z";
    public static bool ValidatePin(string pin)
    {
        return new Regex(pattern).IsMatch(pin);
    }
}
