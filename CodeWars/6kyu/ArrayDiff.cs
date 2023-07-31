namespace CodeWars.Core._6kyu
{
    public class ArrayDiff
    {
        public static int[] Solve(int[] a, int[] b) =>
            a.Where(x => !b.Contains(x)).ToArray();
    }
}
