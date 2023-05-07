//https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/csharp

namespace CodeWars.Core
{
    public static class CategorizeNewMember
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            foreach (var member in data)
            {
                if (55 <= member[0] && 7 < member[1])
                    yield return "Senior";
                else
                    yield return "Open";
            }
        }
    }
}
