using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.UnitTests._5kyu
{
    public class HumanReadableTimeTests
    {
        [Theory]
        [InlineData("00:00:00", 0)]
        [InlineData("00:00:05", 5)]
        [InlineData("00:01:00", 60)]
        [InlineData("23:59:59", 86399)]
        [InlineData("99:59:59", 359999)]
        public void Tests(string expected, int seconds)
        {
            Assert.Equal(expected, HumanReadableTime.GetReadableTime(seconds));
        }
    }
}
