namespace CodeWars.Core._6kyu
{
    public static class HighestScoringWord
    {
        public static string High(string s)
        {
            var words = s.Split(' ');
            var maxScore = 0;
            var maxScoreWord = "";
            foreach(var word in words)
            {
                var score = 0;
                foreach(char c in word)
                {
                    score += c - 'a' + 1;
                }
                if (score > maxScore)
                {
                    maxScore = score;
                    maxScoreWord = word;
                }
            }
            return maxScoreWord;
        }
    }
}
