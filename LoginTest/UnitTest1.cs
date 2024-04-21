using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GUI_tubes_KPL;

namespace LoginTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidLoginTest()
        {
            // Arrange
            Login login = new Login();
            string username = "admin";
            string password = "password123";

            // Act
            bool result = login.ValidateLogin(username, password);

            // Assert
            Assert.IsTrue(result, "Expected a valid login.");
        }

        [TestMethod]
        public void InvalidLoginTest()
        {
            // Arrange
            Login login = new Login();
            string username = "user1";
            string password = "invalidpassword";

            // Act
            bool result = login.ValidateLogin(username, password);

            // Assert
            Assert.IsFalse(result, "Expected an invalid login.");
        }

    }
}
