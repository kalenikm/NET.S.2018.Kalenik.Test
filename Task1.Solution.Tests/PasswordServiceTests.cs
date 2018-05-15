using System;
using System.Collections.Generic;
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

            var passwordService = new PasswordService(repositoryMock.Object);
            passwordService.AddPassword("2g4ty34gwh4h", new List<IValidator>() { validatorMock.Object});

            validatorMock.Verify(val => val.IsValid("2g4ty34gwh4h"));
            repositoryMock.Verify(rep => rep.Save("2g4ty34gwh4h"));
        }

        [Test]
        public void ValidatorIsNull_Exception()
        {
            Assert.Catch<ArgumentNullException>(() => new PasswordService(null));
        }

        [Test]
        public void PasswordIsNull_Exception()
        {
            var validatorMock = new Mock<IValidator>(MockBehavior.Strict);
            var repositoryMock = new Mock<IRepository>(MockBehavior.Strict);

            Assert.Catch<ArgumentNullException>(() => new PasswordService(repositoryMock.Object).AddPassword(null, new List<IValidator>() {validatorMock.Object}));
        }
    }
}