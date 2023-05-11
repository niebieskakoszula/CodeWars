namespace CodeWars.UnitTests._6kyu
{
    public class ConvertStringToCamelCaseTests
    {
        [Theory]
        [InlineData("the-stealth-warrior", "theStealthWarrior")]
        [InlineData("The_Stealth_Warrior", "TheStealthWarrior")]
        public void ToCamelCase_DontChangeFirstLetter(string input, string expected)
        {
            Assert.Equal(expected, ConvertStringToCamelCase.ToCamelCase(input));
        }
        [Theory]
        [InlineData("the_stealth-warrior", "theStealthWarrior")]
        [InlineData("The_Stealth-Warrior", "TheStealthWarrior")]
        public void ToCamelCase_WorksWithMixedDashesAndUnderScores(string input, string expected)
        {
            Assert.Equal(expected, ConvertStringToCamelCase.ToCamelCase(input));
        }
    }
}
