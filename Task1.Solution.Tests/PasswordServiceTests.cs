using System;
using Moq;
using NUnit.Framework;
using Task1.Solution.Implementation;
using Task1.Solution.Interfaces;

namespace Task1.Solution.Tests
{
    [TestFixture]
    public class PasswordServiceTests
    {
        [Test]
        public void AddPasswordTest()
        {
            var repositoryMock = new Mock<IRepository>(MockBehavior.Strict);
            repositoryMock.Setup(rep => rep.Save("2g4ty34gwh4h"));

            var validatorMock = new Mock<IValidator>(MockBehavior.Strict);
            validatorMock.Setup(val => val.IsValid("2g4ty34gwh4h")).Returns(new Tuple<bool, string>(true, ""));

            var passwordService = new PasswordService();
            passwordService.AddPassword("2g4ty34gwh4h", validatorMock.Object, repositoryMock.Object);

            validatorMock.Verify(val => val.IsValid("2g4ty34gwh4h"));
            repositoryMock.Verify(rep => rep.Save("2g4ty34gwh4h"));
        }

        [Test]
        public void ValidatorIsNull_Exception()
        {
            Assert.Catch<ArgumentNullException>(() => new PasswordService().AddPassword("g4b3seg", null, null));
        }

        [Test]
        public void RepositoryIsNull_Exception()
        {
            var validatorMock = new Mock<IValidator>(MockBehavior.Strict);

            Assert.Catch<ArgumentNullException>(() => new PasswordService().AddPassword("g4b3seg", validatorMock.Object, null));
        }

        [Test]
        public void PasswordIsNull_Exception()
        {
            var validatorMock = new Mock<IValidator>(MockBehavior.Strict);

            Assert.Catch<ArgumentNullException>(() => new PasswordService().AddPassword(null, null, null));
        }
    }
}