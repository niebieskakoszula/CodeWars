//https://www.codewars.com/kata/52b7ed099cdc285c300001cd/csharp

namespace CodeWars.Core._4kyu
{
    public class Intervals
    {
        public static int SumIntervals((int, int)[] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return 0;
            var sortedIntervals = intervals.OrderBy(x => x.Item1).ToArray();
            var result = 0;
            var currentInterval = sortedIntervals[0];
            for (var i = 1; i < sortedIntervals.Length; i++)
            {
                var nextInterval = sortedIntervals[i];
                if (nextInterval.Item1 <= currentInterval.Item2)
                {
                    if (nextInterval.Item2 > currentInterval.Item2)
                        currentInterval = (currentInterval.Item1, nextInterval.Item2);
                }
                else
                {
                    result += currentInterval.Item2 - currentInterval.Item1;
                    currentInterval = nextInterval;
                }
            }
            result += currentInterval.Item2 - currentInterval.Item1;
            return result;
        }
    }
}
