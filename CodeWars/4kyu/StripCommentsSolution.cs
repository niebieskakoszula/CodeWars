using System.Text;

namespace CodeWars.Core._4kyu
{
    public class StripCommentsSolution
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            var result = new StringBuilder();
            var lines = text.Split('\n');
            for(int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                var minIndex = line.Length;
                foreach (var symbol in commentSymbols)
                {
                    var index = line.IndexOf(symbol);
                    if (index != -1)
                        minIndex = Math.Min(minIndex, index);
                }
                result.Append(line.Substring(0, minIndex).TrimEnd() + (i == lines.Length -1 ? "" : "\n"));
            }
            return result.ToString();
        }
    }
}
