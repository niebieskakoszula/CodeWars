namespace CodeWars.Core._6kyu
{
    public static class DeleteNthOccurrences
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            var result = new List<int>();
            var countDictionary = arr.GroupBy(x => x)
                .ToDictionary(x => x.Key, x => 0);

            foreach (var item in arr)
            {
                if (countDictionary[item] < x) 
                { 
                    result.Add(item);
                    countDictionary[item]++; 
                }
            }

            return result.ToArray();
        }
    }
}
