using System.Text;

namespace CodeWars.Core._6kyu
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            var result = new StringBuilder();
            word = word.ToLower();
            var countDictionary = word.GroupBy(x => x)
                .Select(x => new { x.Key, Count = x.Count() })
                .ToDictionary(x =>x.Key, x => x.Count);
            
            foreach(char c in word)
            {
                if (countDictionary[c] > 1)
                    result.Append(')');
                else
                    result.Append('(');
            }

            return result.ToString();
        }
    }
}
