//https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1/csharp

namespace CodeWars.Core._4kyu
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            if(array.Length == 0 || array[0].Length == 0)
                return new int[] { };
            var size = array.Length;
            var result = new int[size * size];

            int i = -1, j = 0, counter = 0, loop = 0;
            while(counter < size * size)
            {
                for (i = i + 1; i < size - loop; i++)
                {
                    result[counter] = array[j][i];
                    ++counter;
                }--i;
                for (j = j + 1; j < size - loop; j++)
                {
                    result[counter] = array[j][i];
                    ++counter;
                }--j;
                for (i = i - 1; i > loop; i--)
                {
                    result[counter] = array[j][i];
                    ++counter;
                }
                for (j = j; j > loop; j--)
                {
                    result[counter] = array[j][i];
                    ++counter;
                }++j;
                loop++;
            }

            return result;
        }
    }
}