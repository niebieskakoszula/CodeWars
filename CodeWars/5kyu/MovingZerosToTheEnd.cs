namespace CodeWars.Core._5kyu
{
    public class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
