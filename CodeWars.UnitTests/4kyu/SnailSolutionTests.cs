using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.UnitTests._4kyu
{
    public class SnailSolutionTests
    {
        [Fact]
        public void Snail_EmptyArray_ReturnEmptyArray()
        {
            //Arrange
            var array = new int[][] { };
            var expected = new int[] { };
            //Act
            var actual = SnailSolution.Snail(array);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Snail_1x1Array()
        {
            //Arrange
            var array = new int[][] { new int[] { 1 } };
            var expected = new int[] { 1 };
            //Act
            var actual = SnailSolution.Snail(array);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Snail_2x2Array()
        {
            //Arrange
            var array = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
            var expected = new int[] { 1, 2, 4, 3 };
            //Act
            var actual = SnailSolution.Snail(array);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Snail_3x3Array()
        {
            //Arrange
            var array = new int[][]
                {
                    new []{1, 2, 3},
                    new []{4, 5, 6},
                    new []{7, 8, 9}
                };
            var expected = new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            //Act
            var actual = SnailSolution.Snail(array);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Snail_4x4Array()
        {
            //Arrange
            var array = new int[][]
            {
                    new []{1, 2, 3, 4},
                    new []{5, 6, 7, 8},
                    new []{9, 10, 11, 12},
                    new []{13, 14, 15, 16}
                };
            var expected = new int[] { 1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10 };
            //Act
            var actual = SnailSolution.Snail(array);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Snail_5x5Array()
        {
            //Arrange
            var array = new int[][]
            {
                    new []{1, 2, 3, 4, 5},
                    new []{6, 7, 8, 9, 10},
                    new []{11, 12, 13, 14, 15},
                    new []{16, 17, 18, 19, 20},
                    new []{21, 22, 23, 24, 25}
                };
            var expected = new int[] { 1, 2, 3, 4, 5, 10, 15, 20, 25, 24, 23, 22, 21, 16, 11, 6, 7, 8, 9, 14, 19, 18, 17, 12, 13 };
            //Act
            var actual = SnailSolution.Snail(array);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
