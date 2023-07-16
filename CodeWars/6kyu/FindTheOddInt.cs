namespace CodeWars.Core._6kyu
{
    public class FindTheOddInt
    {
        public static int FindOdd(int[] seq)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in seq)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }
            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                    return item.Key;
            }
            return 0;
        }
    }
}
