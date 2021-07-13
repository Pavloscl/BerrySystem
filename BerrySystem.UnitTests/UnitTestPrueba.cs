using BerrySystem.Api;
using System;
using Xunit;

namespace BerrySystem.UnitTests
{
    public class MailValidatorShould
    {
        // [Fact]
        //public void ValidateValidEmails()
        //{
        //    //Arrange
        //    var mailValidator = new MailValidator();
        //    string emilAddress = "Thecodercaveok@gmail.com";

        //    //Act
        //    bool isValid = mailValidator.IsValidEmail(emilAddress);

        //    //Assert 

        //    Assert.True(isValid,$"{emilAddress } is not valid");
        //}

        //[Fact]

        //public void InvalidateInvalidEmail()
        //{
        //    //Arrange
        //    var mailValidador = new MailValidator();
        //    string emailAddress = "Invalida@invalid.invalid";

        //    //Act
        //    bool isValid = mailValidador.IsValidEmail(emailAddress);

        //    //Assert
        //    Assert.False(isValid);
        //}
        [Theory]
        [InlineData("invalid@invalid", false)]
        [InlineData("PAblo@gmail.com", true)]
        public void ValidateValidEmails(string emailAddress, bool expeted)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            bool isValid = mailValidator.IsValidEmail(emailAddress);

            //Assert 
            Assert.Equal(expeted, isValid);
        } 

        [Theory]
        [InlineData("PAblo@gmail.com", "INBOX")]
        [InlineData("xxx@dodgy.com", "SPAM")]
        public void IdentifySpam(string emailAddress,string expected)
        {
            //Arrange
            var mailValidator = new MailValidator();

            //Act
            string result = mailValidator.IsSpam(emailAddress);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RaiseErrorWhenEmailIsEmpety()
        {
            //Arrage
            var mailValidator = new MailValidator();

            //Act

            //Assert
            Assert.Throws<Exception>(() => mailValidator.IsValidEmail(null));
        }
    }

}

