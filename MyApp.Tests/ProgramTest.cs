using System;
using Xunit;

namespace MyApp.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void isLeapYearTest()
        {
            Assert.True(Program.isLeapYear(2004));
            Assert.False(Program.isLeapYear(1900));
            Assert.True(Program.isLeapYear(1600));
        }
    }
}