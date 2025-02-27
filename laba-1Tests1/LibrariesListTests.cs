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
    public class LibrariesListTests
    {
        [TestMethod()]
        public void AddTest()
        {
            LibrariesList librariesList = new LibrariesList();
            librariesList.OnAddingLibrary += () => { };
            librariesList.OnDeletingLibrary += () => { };
            Library lib = new Library("Библиотека", "Володарского 11");
            bool expected = true;
            bool actual = librariesList.Add(lib);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            LibrariesList librariesList = new LibrariesList();
            librariesList.OnAddingLibrary += () => { };
            librariesList.OnDeletingLibrary += () => { };
            Library lib = new Library("Библиотека", "Володарского 11");

            bool expected = true;
            bool actual = librariesList.Remove(lib);

            Assert.AreEqual(expected, actual);
        }


    }
}