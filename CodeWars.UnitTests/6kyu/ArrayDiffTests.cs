using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.UnitTests._6kyu
{
    public class ArrayDiffTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { 1 }, new int[] { 2 })]
        [InlineData(new int[] { 1, 2, 2 }, new int[] { 1 }, new int[] { 2, 2 })]
        [InlineData(new int[] { 1, 2, 2 }, new int[] { 2 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2, 2 }, new int[] { }, new int[] { 1, 2, 2 })]
        [InlineData(new int[] { }, new int[] { 1, 2 }, new int[] { })]
        public void Solve_ShouldReturnExpected(int[] a, int[] b, int[] expected)
        {
            // Arrange
            // Act
            var actual = ArrayDiff.Solve(a, b);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
