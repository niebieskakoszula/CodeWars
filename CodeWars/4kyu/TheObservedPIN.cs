namespace CodeWars.Core._4kyu
{
    public class TheObservedPIN
    {
        public static List<string> GetPINs(string observed)
        {
            var list = new List<string>();
            var dict = new Dictionary<string, List<string>>()
            {
                { "1", new List<string>() { "1", "2", "4" } },
                { "2", new List<string>() { "1", "2", "3", "5" } },
                { "3", new List<string>() { "2", "3", "6" } },
                { "4", new List<string>() { "1", "4", "5", "7" } },
                { "5", new List<string>() { "2", "4", "5", "6", "8" } },
                { "6", new List<string>() { "3", "5", "6", "9" } },
                { "7", new List<string>() { "4", "7", "8" } },
                { "8", new List<string>() { "5", "7", "8", "9", "0" } },
                { "9", new List<string>() { "6", "8", "9" } },
                { "0", new List<string>() { "8", "0" } }
            };
            foreach (var item in observed)
            {
                list.Add(item.ToString());
            }
            return GetPermutations(list, dict);
        }
        private static List<string> GetPermutations(List<string> list, Dictionary<string, List<string>> dict)
        {
            var result = new List<string>();
            if (list.Count == 1)
            {
                return dict[list[0]];
            }
            else
            {
                var temp = GetPermutations(list.Skip(1).ToList(), dict);
                foreach (var item in dict[list[0]])
                {
                    foreach (var item2 in temp)
                    {
                        result.Add(item + item2);
                    }
                }
            }
            return result;
        }
    }
}
