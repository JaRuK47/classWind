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
            var val = new NumberSystem("10", MeasureType.n10);
            Assert.AreEqual("10 с.с. 10", val.Verbose());

            val = new NumberSystem("10", MeasureType.n8);
            Assert.AreEqual("10 с.с. 8", val.Verbose());

            val = new NumberSystem("10", MeasureType.n2);
            Assert.AreEqual("10 с.с. 2", val.Verbose());

            val = new NumberSystem("10", MeasureType.n16);
            Assert.AreEqual("10 с.с. 16", val.Verbose());
        }

        [TestMethod()]
        public void AddNumberTest()
        {
            var val = new NumberSystem("1", MeasureType.n10);
            val = val + 4;
            Assert.AreEqual("5 с.с. 10", val.Verbose());
        }

        [TestMethod()]
        public void SubNumberTest()
        {
            var val = new NumberSystem("3", MeasureType.n10);
            val = val - 1;
            Assert.AreEqual("2 с.с. 10", val.Verbose());
        }

        [TestMethod()]
        public void MulByNumberTest()
        {
            var val = new NumberSystem("3", MeasureType.n10);
            val = val * 3;
            Assert.AreEqual("9 с.с. 10", val.Verbose());
        }

        [TestMethod()]
        public void DivByNumberTest()
        {
            var val = new NumberSystem("3", MeasureType.n10);
            val = val / 3;
            Assert.AreEqual("1 с.с. 10", val.Verbose());
        }

        [TestMethod()]
        public void ССToAnyTest()
        {
            NumberSystem val;

            val = new NumberSystem("4", MeasureType.n10);
            Assert.AreEqual("100 с.с. 2", val.To(MeasureType.n2).Verbose());

            val = new NumberSystem("16", MeasureType.n10);
            Assert.AreEqual("20 с.с. 8", val.To(MeasureType.n8).Verbose());

            val = new NumberSystem("20", MeasureType.n10);
            Assert.AreEqual("14 с.с. 16", val.To(MeasureType.n16).Verbose());

            val = new NumberSystem("100", MeasureType.n2);
            Assert.AreEqual("4 с.с. 10", val.To(MeasureType.n10).Verbose());

            val = new NumberSystem("100000", MeasureType.n2);
            Assert.AreEqual("20 с.с. 16", val.To(MeasureType.n16).Verbose());
        }

        [TestMethod()]
        public void AddSubN2N16Test()
        {
            var n2 = new NumberSystem("10100", MeasureType.n2);
            var n16 = new NumberSystem("18", MeasureType.n16);

            Assert.AreEqual("101100 с.с. 2", (n2 + n16).Verbose());
            Assert.AreEqual("2C с.с. 16", (n16 + n2).Verbose());

            Assert.AreEqual("11111111111111111111111111111100 с.с. 2", (n2 - n16).Verbose());
            Assert.AreEqual("4 с.с. 16", (n16 - n2).Verbose());
        }
    }
}

namespace klaswindTests
{
    internal class NumberSystemTests
    {
    }
}
