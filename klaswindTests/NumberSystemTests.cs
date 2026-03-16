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
            var length = new NumberSystem(10, MeasureType.n10);
            Assert.AreEqual("10 n10", length.Verbose());
        }
    }
}

namespace klaswindTests
{
    internal class NumberSystemTests
    {
    }
}
