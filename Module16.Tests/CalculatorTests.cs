using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Module16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [Test]
        public void AdditionMustustReturnCorrectValuel()
        {
            Assert.AreEqual(8, calculator.Additional(4, 4));
        }

        [Test]
        public void AdditionMustustReturnNotNull()
        {
            Assert.IsNotNull(calculator.Additional(4, 4));
        }

        [Test]
        public void SubtractionMustustReturnCorrectValuel()
        {
            Assert.AreEqual(-8, calculator.Subtraction(-4, 4));
        }

        [Test]
        public void SubtractionMustustReturnNotNulll()
        {
            Assert.NotNull(calculator.Subtraction(0, 0));
        }


        [Test]
        public void MiltiplicationMustustReturnCorrectValuel()
        {
            Assert.AreEqual(-8, calculator.Miltiplication(4, -2));
        }

        public void MiltiplicationMustustReturnNotNulll()
        {
            Assert.NotNull(calculator.Miltiplication(0, 0));
        }


        [Test]
        public void DivisionMustustReturnCorrectValuel()
        {
            Assert.AreEqual(-1, calculator.Division(4, -4));
        }

        [Test]
        public void DivisionMustustReturnExrption()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(4, 0));
        }

        [Test]
        public void DivisionMustustReturnNotNulll()
        {
            Assert.NotNull(calculator.Division(0, 1));
        }
    }
}
