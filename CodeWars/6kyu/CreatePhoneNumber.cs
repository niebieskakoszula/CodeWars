//https://www.codewars.com/kata/525f50e3b73515a6db000b83/csharp
//requires LINQ

namespace CodeWars.Core;

public class CreatePhoneNumber
{
    public static string CreatePhoneNumberMethod(int[] numbers)
    {
        return string.Format(format: "({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", 
            numbers.Cast<object>().ToArray());
    }
}
