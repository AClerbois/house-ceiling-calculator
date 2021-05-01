using System;
using Xunit;

namespace Sot.House.Calculator.Tests
{
    public class RectangularRoomUnitTest
    {
        [Fact]
        public void CountCrossbarStartInLength()
        {
            // Arrange 
            var sut = new RectangularRoom("", 327, 229);

            // Act
            var count = sut.CountCrossbarStartInLength;

            // Assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void CountCrossbarStartInBreadth()
        {
            // Arrange 
            var sut = new RectangularRoom("", 327, 229);

            // Act
            var count = sut.CountCrossbarStartInBreadth;

            // Assert
            Assert.Equal(5, count);
        }

        [Theory]
        [InlineData(327, 0)]
        [InlineData(450, 1)]
        [InlineData(750, 1)]
        [InlineData(850, 2)]
        public void CountAttachInBreath(decimal breath, int expectedCount)
        {
            // Arrange 
            var sut = new RectangularRoom("", breath, 229);

            // Act
            var count = sut.CountAttachInBreath;

            // Assert
            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData(327, 0)]
        [InlineData(450, 1)]
        [InlineData(750, 1)]
        [InlineData(850, 2)]
        public void CountAttachInLength(decimal length, int expectedCount)
        {
            // Arrange 
            var sut = new RectangularRoom("", 327, length);

            // Act
            var count = sut.CountAttachInLength;

            // Assert
            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData(327, 229, 25)]
        [InlineData(400, 229, 30)]
        [InlineData(400, 250, 36)]
        public void StartCrossbarCount(decimal breath, decimal length, int expectedCount)
        {
            // Arrange 
            var sut = new RectangularRoom("", breath, length);

            // Act
            var count = sut.StartCrossbarCount;

            // Assert
            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData(327, 229, 2780)]
        public void TotalCrossbarDistance(decimal breath, decimal length, decimal expectedCount)
        {
            // Arrange 
            var sut = new RectangularRoom("", breath, length);

            // Act
            var count = sut.TotalCrossbarDistance;

            // Assert
            Assert.Equal(expectedCount, count);
        }

        [Theory]
        [InlineData(327, 229, 10)]
        [InlineData(410, 229, 16)]
        public void TotalCrossbar(decimal breath, decimal length, decimal expectedCount)
        {
            // Arrange 
            var sut = new RectangularRoom("", breath, length);

            // Act
            var count = sut.TotalCrossbar;

            // Assert
            Assert.Equal(expectedCount, count);
        }


        [Theory]
        [InlineData(327, 229, 2780)]
        public void TotalLengthCrossbar(decimal breath, decimal length, decimal expectedCount)
        {
            // Arrange 
            var sut = new RectangularRoom("", breath, length);

            // Act
            var count = sut.TotalLengthCrossbar;

            // Assert
            Assert.Equal(expectedCount, count);
        }
    }
}
