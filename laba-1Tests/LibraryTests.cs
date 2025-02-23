using Microsoft.VisualStudio.TestTools.UnitTesting;
using laba_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1.Tests
{
    [TestClass()]
    public class LibraryTests
    {
        [TestMethod()]
        public void IWantToTestTest()
        {
            int x = 1;
            int y = 2;
            int expected = 3;

            int actual = Library.IWantToTest(x, y);
            Assert.AreEqual(expected, actual);

            
        }
    }
}