using System.Text;

namespace CodeWars.Core._4kyu
{
    public class HumanReadableDurationFormat
    {
        public static string FormatDuration(int seconds)
        {
            if (seconds == 0)
                return "now";
            var time = TimeSpan.FromSeconds(seconds);
            var temp = new List<string>();

            var years = time.Days / 365;
            if (years > 0)
                temp.Add($"{years} {(years == 1 ? "year" : "years")}");
            var days = time.Days % 365;
            if (days > 0)
                temp.Add($"{days} {(days == 1 ? "day" : "days")}");
            if (time.Hours > 0)
                temp.Add($"{time.Hours} {(time.Hours == 1 ? "hour" : "hours")}");
            if (time.Minutes > 0)
                temp.Add($"{time.Minutes} {(time.Minutes == 1 ? "minute" : "minutes")}");
            if (time.Seconds > 0)
                temp.Add($"{time.Seconds} {(time.Seconds == 1 ? "second" : "seconds")}");

            StringBuilder result = new StringBuilder();
            result.Append(temp[0]);
            for (int i = 1; i < temp.Count; i++)
            {
                if (i == temp.Count - 1)
                    result.Append($" and {temp[i]}");
                else
                    result.Append($", {temp[i]}");
            }
            return result.ToString();
        }
    }
}
