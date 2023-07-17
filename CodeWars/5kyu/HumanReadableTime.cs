namespace CodeWars.Core._5kyu
{
    public class HumanReadableTime
    {
        public static string GetReadableTime(int seconds)
        {
            var result = TimeSpan.FromSeconds(seconds);
            return string.Format("{0:00}:{1:00}:{2:00}", (int)result.TotalHours, result.Minutes, result.Seconds);
        }
    }
}
