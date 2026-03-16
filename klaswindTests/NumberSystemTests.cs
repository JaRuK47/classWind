using Microsoft.VisualStudio.TestTools.UnitTesting;
using klaswind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaswind.Tests
{
    [TestClass()]
    public class NumberSystemTests
    {
        [TestMethod()]
        public void VerboseTest()
        {
            var val = new NumberSystem(10, MeasureType.n10);
            Assert.AreEqual("10 с.с. 10", val.Verbose());

            val = new NumberSystem(10, MeasureType.n8);
            Assert.AreEqual("10 с.с. 8", val.Verbose());

            val = new NumberSystem(10, MeasureType.n2);
            Assert.AreEqual("10 с.с. 2", val.Verbose());

            val = new NumberSystem(10, MeasureType.n16);
            Assert.AreEqual("10 с.с. 16", val.Verbose());
        }

        [TestMethod()]
        public void AddNumberTest()
        {
            var val = new NumberSystem(1, MeasureType.n10);
            val = val + 4.25;
            Assert.AreEqual("5,25 с.с. 10", val.Verbose());
        }

        [TestMethod()]
        public void SubNumberTest()
        {
            var val = new NumberSystem(3, MeasureType.n10);
            val = val - 1.75;
            Assert.AreEqual("1,25 с.с. 10", val.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var val = new NumberSystem(3, MeasureType.n10);
            val = val * 3;
            Assert.AreEqual("9 с.с. 10", val.Verbose());
        }

        [TestMethod()]
        public void DivByNumberTest()
        {
            var val = new NumberSystem(3, MeasureType.n10);
            val = val / 3;
            Assert.AreEqual("1 с.с. 10", val.Verbose());
        }
    }
}

namespace klaswindTests
{
    internal class NumberSystemTests
    {
    }
}
