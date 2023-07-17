namespace CodeWars.Core._6kyu
{
    public class SumOfDigits
    {
        public static int DigitalRoot(long n)
        {
            var result = n.ToString().Select(x => int.Parse(x.ToString())).Sum();
            return result < 10 ? result : DigitalRoot(result);
        }
    }
}