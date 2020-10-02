using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CykelLibraryMedUnitTest.Tests
{
    [TestClass]
    public class CykelTests
    {
        private readonly Cykel _cykel = new Cykel();

        /*[TestMethod]
        public void TestConstructor()
        {
            Assert.IsTrue(_cykel.Farve.Length >= 1);
            Assert.IsTrue(_cykel.Pris > 0);
            Assert.IsTrue(3 <= _cykel.Gear && _cykel.Gear <= 32);
        }*/

        [TestMethod]
        public void TestFarve()
        {
            _cykel.Farve = "A";
            Assert.AreEqual("A", _cykel.Farve);
            Assert.ThrowsException<ArgumentException>(() => _cykel.Farve = "");
            Assert.ThrowsException<ArgumentNullException>(() => _cykel.Farve = null);
        }

        [TestMethod]
        public void TestPris()
        {
            _cykel.Pris = 1;
            Assert.AreEqual(1, _cykel.Pris);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Pris = 0);
        }

        [TestMethod]
        public void TestGear()
        {
            _cykel.Gear = 3;
            Assert.AreEqual(3, _cykel.Gear);
            _cykel.Gear = 32;
            Assert.AreEqual(32, _cykel.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _cykel.Gear = 33);
        }

        [TestMethod]
        public void ToStringTest()
        {
            // TODO should test ...
        }
    }
}