namespace CodeWars.Core._6kyu
{
    public class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }
    }
}
