using System.Text;

namespace CodeWars.Core._5kyu
{
    public static class Soundex
    {
        public static string Encode(string names)
        {
            var result = new StringBuilder();
            foreach (var name in names.Split(' '))
            {
                result.Append(EncodeWord(name));
                result.Append(' ');
            }
            return result.ToString().TrimEnd();
        }
        public static string EncodeWord(string word)
        {
            var result = new StringBuilder();
            result.Append(char.ToUpper(word[0])); //Should be mentioned in description
            word = word.ToLower();
            var previousCode = GetCode(word[0]);
            for (int i = 1; i < word.Length; i++)
            {
                var code = GetCode(word[i]);
                if (code == '0')
                    continue;
                else if (code == '-')
                    previousCode = code;
                else if (code != previousCode)
                {
                    result.Append(code);
                    previousCode = code;
                }
            }
            return result.ToString().PadRight(4, '0')[..4];
        }
        private static char GetCode(char c)
        {
            return c switch
            {
                'b' or 'f' or 'p' or 'v' => '1',
                'c' or 'g' or 'j' or 'k' or 'q' or 's' or 'x' or 'z' => '2',
                'd' or 't' => '3',
                'l' => '4',
                'm' or 'n' => '5',
                'r' => '6',
                'a' or 'e' or 'i' or 'o' or 'u' or 'y' => '-', //those letters should be removed AFTER replacing lettes with numbers
                                                               //so I added '-' to make sure I won't skip them while removing adjacent duplicates
                _ => '0',
            };
        }
    }
}
