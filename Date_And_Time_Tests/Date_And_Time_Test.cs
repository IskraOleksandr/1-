using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Date_And_Time_n;

namespace Date_And_Time_Tests
{
    [TestClass]
    public class Date_And_Time_Test
    {
        [TestMethod]
        public void IsValidDateTime_ValidDateTime_ReturnsTrue()
        {
            // Arrange
            int year = 2022, month = 12, day = 31;
            int hour = 23, minute = 59, second = 12;
            Date_And_Time date_And_Time = new Date_And_Time();

            // Act
            bool result = date_And_Time.IsValidDateTime(year, month, day, hour, minute, second);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidDateTime_InvalidYear_ReturnsFalse()
        {
            // Arrange
            int year = 0, month = 12, day = 31;
            int hour = 23, minute = 59, second = 31;
            Date_And_Time date_And_Time = new Date_And_Time();
            // Act
            bool result = date_And_Time.IsValidDateTime(year, month, day, hour, minute, second);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidDateTime_InvalidMonth_ReturnsFalse()
        {
            // Arrange
            int year = 2022, month = 13, day = 31;
            int hour = 23, minute = 59, second = 23;
            Date_And_Time date_And_Time = new Date_And_Time();

            // Act
            bool result = date_And_Time.IsValidDateTime(year, month, day, hour, minute, second);

            // Assert
            Assert.IsFalse(result);
        }
    }
}