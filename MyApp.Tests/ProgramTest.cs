using System;
using System.IO;
using Xunit;

namespace MyApp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void MainPrintsYay()
        {
            StringReader reader = new StringReader("2000");
            Console.SetIn(reader);
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main();

            string expected = "yay";
            string actual = writer.ToString().Split(Environment.NewLine)[1];

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MainPrintsNay()
        {
            StringReader reader = new StringReader("1900");
            Console.SetIn(reader);
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main();

            string expected = "nay";
            string actual = writer.ToString().Split(Environment.NewLine)[1];

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MainNotANumber()
        {
            StringReader reader = new StringReader("190d");
            Console.SetIn(reader);
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main();

            string expected = "You need to enter a number, quitting!";
            string actual = writer.ToString().Split(Environment.NewLine)[1];

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MainBelow1582()
        {
            StringReader reader = new StringReader("1581");
            Console.SetIn(reader);
            StringWriter writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main();

            string expected = "Cannot handle years below 1582, quitting!";
            string actual = writer.ToString().Split(Environment.NewLine)[1];

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void isLeapYearTest()
        {
            Assert.True(Program.isLeapYear(2004));
            Assert.False(Program.isLeapYear(1900));
            Assert.True(Program.isLeapYear(1600));
        }
    }
}
