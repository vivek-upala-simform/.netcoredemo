using System;
using Xunit;
using netcoredemo.Service;
namespace demo.test
{
    public class CalcTest
    {
        [Fact]
        public void Sum()
        {
            int expected = 6;
            int actual = MathService.Add(2, 3);
            Assert.Equal(expected, actual);
        }
    }
}
