using NUnit.Framework;
using PsAnotherNUnit;

namespace UnitTests
{
    [TestFixture]
    public class AirlineMembershipNumberValidatorTests
    {
        [Test]
        public void ShouldValidateCorrectNumber()
        {
            var sut = new AirlineMembershipNumberValidator();

            var isValid = sut.ValidityOf("A1234567");

            Assert.That(isValid, Is.True);

        }
    }
}
