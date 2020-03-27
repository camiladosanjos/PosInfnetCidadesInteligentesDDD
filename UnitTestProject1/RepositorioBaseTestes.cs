using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PosInfnetCidadesInteligentesDDD.Infra.Dados.Config;
using Xunit;

namespace UnitTestProject1
{

    [TestClass]
    public class RepositorioBaseTestes
    {

        [Fact]
        public void AddUser_Invoke_UserCreated_v1(string expectedLogin, string expectedName, string expectedSurname)
        {
            // Arrange
            var userContextMock = new Mock<EstacaoRecargaDBContext>();
            userContextMock.Setup(x => x.Users.Add(It.IsAny<User>())).Returns((User u) => u);

            var usersService = new UsersService(userContextMock.Object);

            // Act
            var user = usersService.AddUser(expectedLogin, expectedName, expectedSurname);

            // Assert
            Assert.Equal(expectedLogin, user.Login);
            Assert.Equal(expectedName, user.Name);
            Assert.Equal(expectedSurname, user.Surname);
            Assert.False(user.AccountLocked);

            userContextMock.Verify(x => x.SaveChanges(), Times.Once);
        }
    }
}
