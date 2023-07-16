using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.UnitTests._6kyu
{
    public class FindTheOddIntTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 3, 3 }, 1)]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 4 }, 4)]
        [InlineData(new int[] { 7 }, 7)]
        [InlineData(new int[] { 0 }, 0)]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 1, 0, 1, 0 }, 0)]
        [InlineData(new int[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }, 4)]
        [InlineData(new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }, 5)]
        public void FindOddTest(int[] input, int expected)
        {
            Assert.Equal(expected, FindTheOddInt.FindOdd(input));
        }
    }
}
