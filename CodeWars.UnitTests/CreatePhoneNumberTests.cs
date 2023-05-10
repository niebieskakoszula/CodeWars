namespace CodeWars.UnitTests
{
    public class CreatePhoneNumberTests
    {
        [Fact]
        public void CreatePhoneNumberTest()
        {
            Assert.Equal("(123) 456-7890", CreatePhoneNumber.CreatePhoneNumberMethod(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            Assert.Equal("(111) 111-1111", CreatePhoneNumber.CreatePhoneNumberMethod(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }
    }
}
