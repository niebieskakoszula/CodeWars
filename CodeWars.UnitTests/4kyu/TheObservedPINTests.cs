using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.UnitTests._4kyu
{
    public class TheObservedPINTests
    {
        [Theory]
        [InlineData("8", new string[] { "5", "7", "8", "9", "0" })]
        [InlineData("11", new string[] { "11", "22", "44", "12", "21", "14", "41", "24", "42" })]
        [InlineData("369", new string[] { "339", "366", "399", "658", "636", "258", "268", "669", "668", "266", "369", "398", "256", "296", "259", "368", "638", "396", "238", "356", "659", "639", "666", "359", "336", "299", "338", "696", "269", "358", "656", "698", "699", "298", "236", "239" })]
        public void GetPINsTest(string observed, string[] expected)
        {
            TheObservedPIN.GetPINs(observed).Should().BeEquivalentTo(expected);
            //Assert.Equal(ex, );
        }
    }
}
