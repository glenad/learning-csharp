using NUnit.Framework;
using PsFirstNunit;

namespace UnitTests
{
    [TestFixture]
    public class AirlineMembershipNumberValidatorTests
    {
        [Test]
        //[Ignore("Just a demo")]
        [Category("SmokeTest")]
        public void ShouldValidateCorrectNumber()
        {
            var sut = new AirlineMembershipNumberValidator();

            var isValid = sut.ValidityOf("A1234567");

            Assert.That(isValid, Is.True);
        }

        [Test]
        public void ShouldInvalidateMissingLetter()
        {
            var sut = new AirlineMembershipNumberValidator();

            var isValid = sut.ValidityOf("12345678");

            Assert.That(isValid, Is.False);
        }

        [Test]
        public void ShouldInvalidateLengthGreaterThen8Chars()
        {
            var sut = new AirlineMembershipNumberValidator();

            var isValid = sut.ValidityOf("B87654321");

            Assert.That(isValid, Is.False);

        }

    }
}
