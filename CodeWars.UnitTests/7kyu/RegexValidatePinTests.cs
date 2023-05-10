using System.ComponentModel;

namespace CodeWars.UnitTests._7kyu;

public class RegexValidatePinTests
{

    [Theory, Description("ValidatePin should return false for pins with length other than 4 or 6")]
    [InlineData("1")]        
    [InlineData("12")]
    [InlineData("123")]
    [InlineData("12345")]
    [InlineData("1234567")]
    [InlineData("-1234")]
    [InlineData("1.234")]
    [InlineData("00000000")]
    public void ValidatePin_GivenWrongLenght_ReturnsFalse(string pin)
    {
        RegexValidatePin.ValidatePin(pin).Should().BeFalse();
    }

    [Theory, Description("ValidatePin should return false for pins which contain characters other than digits")]
    [InlineData("a234")]
    [InlineData(".234")]
    [InlineData("0.234")]
    public void ValidatePin_GivenNotANumber_ReturnsFalse(string pin)
    {
        RegexValidatePin.ValidatePin(pin).Should().BeFalse();
    }

    [Theory, Description("ValidatePin should return true for valid pins")]
    [InlineData("1234")]
    [InlineData("0000")]
    [InlineData("1111")]
    [InlineData("123456")]
    [InlineData("098765")]
    [InlineData("000000")]
    [InlineData("090909")]
    public void ValidatePin_GivenValidPin_ReturnsTrue(string pin)
    {
        RegexValidatePin.ValidatePin(pin).Should().BeTrue();
    }

    [Theory, Description("ValidatePin should return false for pins which contain white spaces")]
    [InlineData("12 34")]
    [InlineData("12\n34")]
    [InlineData("023\t4")]
    public void ValidatePin_GivenWhiteSpace_ReturnsFalse(string pin)
    {
        RegexValidatePin.ValidatePin(pin).Should().BeFalse();
    }
}
