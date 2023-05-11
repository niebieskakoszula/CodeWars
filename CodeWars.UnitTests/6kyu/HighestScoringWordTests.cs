using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars.UnitTests._6kyu
{
    public class HighestScoringWordTests
    {
        [Theory]
        [MemberData(nameof(HighestScoringWordTestsCases))]
        public void HighTest(string input, string expected)
        {
            Assert.Equal(expected, HighestScoringWord.High(input));
        }
        public static IEnumerable<object[]> HighestScoringWordTestsCases
        {
            get
            {
                yield return new object[] { "man i need a taxi up to ubud", "taxi" };
                yield return new object[] { "what time are we climbing up to the volcano", "volcano" };
                yield return new object[] { "take me to semynak", "semynak" };
                yield return new object[] { "aa b", "aa" };
                yield return new object[] { "b aa", "b" };
                yield return new object[] { "bb d", "bb" };
                yield return new object[] { "d bb", "d" };
                yield return new object[] { "aaa b", "aaa" };
            }
        }
    }
}
