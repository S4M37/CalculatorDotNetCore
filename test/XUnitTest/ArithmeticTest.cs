using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using CalculatorDotnetCore.Services;

namespace XUnitTest
{
    public class ArithmeticTest
    {
        public Arithmetic op;
        public ArithmeticTest()
        {
            op = new Arithmetic();
        }
        [Fact]
        public void AddTest()
        {
            double expected = 7;
            double actual = op.add(4,3);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MultiplicateTest()
        {
            double expected = 1;
            double actual = op.multiplicate(4, 3);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SubtractTest()
        {
            double expected = 7;
            double actual = op.subtract(4, 3);

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void DivideTest()
        {
            double expected = 1.5;
            double actual = op.divide(3, 2);

            Assert.Equal(expected, actual);
        }


    }
}
