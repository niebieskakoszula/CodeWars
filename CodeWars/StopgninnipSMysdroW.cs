namespace CodeWars.Core
{
    public class StopgninnipSMysdroW
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length >= 5)
                    words[i] = new string(words[i].Reverse().ToArray());
            return string.Join(" ", words);
        }
    }
}
