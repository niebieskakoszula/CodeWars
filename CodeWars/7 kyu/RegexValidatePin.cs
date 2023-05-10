using System.Text.RegularExpressions;

namespace CodeWars.Core;

public static class RegexValidatePin
{
    static readonly string pattern = @"\A(\d{4}|\d{6})\z";
    public static bool ValidatePin(string pin)
    {
        return new Regex(pattern).IsMatch(pin);
    }
}
