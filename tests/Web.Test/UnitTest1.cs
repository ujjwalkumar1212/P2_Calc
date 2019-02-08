using System;
using Xunit;
using Web.Contents;

namespace Web.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double expected = 12.5;
            double actual = Multiplier.Multiply(1.25, 10);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-3, 5, -15)]
        [InlineData(-6, -10, 60)]
        [InlineData(5, 8, 40)]
        [InlineData(6, 3, 18)]
        public void MultiplyTest_SimpleMultiplication( double n1, double n2, double n3)
        {
            double expected = n3;
            double actual = Multiplier.Multiply(n1, n2);
            Assert.Equal(expected, actual);
        }
    }
}
