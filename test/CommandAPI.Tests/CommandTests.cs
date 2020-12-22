using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            // Arrange
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // Act
            testCommand.HowTo = "Execute Unit Tests";

            // Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Act
            testCommand.Platform = "xTest";

            // Assert
            Assert.Equal("xTest", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // Act
            testCommand.CommandLine = "d test";

            // Assert
            Assert.Equal("d test", testCommand.CommandLine);
        }
    }
}