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
    public class LibraryBuilderTests
    {
        [TestMethod()]
        public void SetNameTest()
        {
            Library obj = new LibraryBuilder().SetName("Библиотека").Build();
            Assert.Fail();
        }
    }
}