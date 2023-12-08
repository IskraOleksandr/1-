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
            int year = 2022;
            int month = 12;
            int day = 31;
            int hour = 23;
            int minute = 59;
            Date_And_Time date_And_Time = new Date_And_Time();

            // Act
            bool result = date_And_Time.IsValidDateTime(year, month, day, hour, minute);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidDateTime_InvalidYear_ReturnsFalse()
        {
            // Arrange
            int year = 0;
            int month = 12;
            int day = 31;
            int hour = 23;
            int minute = 59;
            Date_And_Time date_And_Time = new Date_And_Time();
            // Act
            bool result = date_And_Time.IsValidDateTime(year, month, day, hour, minute);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidDateTime_InvalidMonth_ReturnsFalse()
        {
            // Arrange
            int year = 2022;
            int month = 13;
            int day = 31;
            int hour = 23;
            int minute = 59;
            Date_And_Time date_And_Time = new Date_And_Time();

            // Act
            bool result = date_And_Time.IsValidDateTime(year, month, day, hour, minute);

            // Assert
            Assert.IsFalse(result);
        }
    }
}