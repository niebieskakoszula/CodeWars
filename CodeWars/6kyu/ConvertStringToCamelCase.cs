using System.Text;

namespace CodeWars.Core._6kyu
{
    public static class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            var result = new StringBuilder();
            var words = str.Split(new char[] { '-', '_' });
            result.Append(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                result.Append(char.ToUpper(words[i][0]));
                result.Append(words[i].Substring(1));
            }
            return result.ToString();
        }
    }
}
