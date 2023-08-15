using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.UnitTests._5kyu
{
    public class RgbToHexConversionTests
    {
        [Theory]
        [InlineData(255, 255, 255, "FFFFFF")]
        [InlineData(255, 255, 300, "FFFFFF")]
        [InlineData(0, 0, 0, "000000")]
        [InlineData(148, 0, 211, "9400D3")]
        [InlineData(148, -20, 211, "9400D3")]
        [InlineData(144, 195, 212, "90C3D4")]
        [InlineData(212, 53, 12, "D4350C")]
        public void RgbTest(int r, int g, int b, string expected)
        {
            Assert.Equal(expected, RgbToHexConversion.Rgb(r, g, b));
        }
    }
}
