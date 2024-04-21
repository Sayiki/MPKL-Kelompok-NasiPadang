using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Register;
using GUI_tubes_KPL;

namespace Register_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidRegistration()
        {
            // Arrange
            string username = "testuser";
            string password = "Password123";
            string confirmPassword = "Password123";
            string email = "test@example.com";

            // Act
            var registration = new Register<string>(username, password, confirmPassword, email);
            bool result = registration.RegisterUser();

            // Assert
            Assert.IsTrue(result, "Registration should succeed for valid data");
        }

        [TestMethod]
        public void TestInvalidRegistration_NullFields()
        {
            // Arrange
            string username = "";
            string password = "";
            string confirmPassword = "";
            string email = "";

            // Act
            var registration = new Register<string>(username, password, confirmPassword, email);
            bool result = registration.RegisterUser();

            // Assert
            Assert.IsFalse(result, "Registration should fail for null fields");
        }
    }
}
