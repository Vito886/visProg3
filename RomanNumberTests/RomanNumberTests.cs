using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            try
            {
                var res = new RomanNumber(1);
            }
            catch (RomanNumberException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

            try
            {
                var res = new RomanNumber(3999);
            }
            catch (RomanNumberException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }

            try
            {
                var res = new RomanNumber(2500);
            }
            catch (RomanNumberException ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(4000));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(10000));
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var num1 = new RomanNumber(4);
            var num2 = new RomanNumber(102);

            Assert.AreEqual(num1.ToString(), "IV");
            Assert.AreEqual(num2.ToString(), "CII");
        }

        [TestMethod()]
        public void CloneTest()
        {
            var num1 = new RomanNumber(512);
            var num2 = num1.Clone();

            Assert.AreEqual(num1.ToString(), num2.ToString());
        }

        [TestMethod()]
        public void CompareToTest()
        {
            var num1 = new RomanNumber(54);
            var num2 = new RomanNumber(199);
            RomanNumber? num3 = null;

            Assert.IsTrue(num1.CompareTo(num2) > 0);
            Assert.IsTrue(num2.CompareTo(num1) < 0);
            Assert.IsTrue(num1.CompareTo(num1) == 0);
            Assert.ThrowsException<ArgumentException>(() => num1.CompareTo(num3));
        }

        [TestMethod()]
        public void AddTest()
        {
            var num1 = new RomanNumber(424);
            var num2 = new RomanNumber(811);
            var num3 = new RomanNumber(3899);
            RomanNumber? num4 = null;

            Assert.AreEqual("MCCXXXV", (num1 + num2).ToString());
            Assert.ThrowsException<RomanNumberException>(() => num1 + num3);
            Assert.ThrowsException<RomanNumberException>(() => num1 + num4);
            Assert.ThrowsException<RomanNumberException>(() => num3 + num4);
            Assert.ThrowsException<RomanNumberException>(() => num3 + num3);
            Assert.ThrowsException<RomanNumberException>(() => num4 + num4);
        }

        [TestMethod()]
        public void SubTest()
        {
            var num1 = new RomanNumber(3000);
            var num2 = new RomanNumber(163);
            RomanNumber? num3 = null;

            Assert.AreEqual("MMDCCCXXXVII", (num1 - num2).ToString());
            Assert.ThrowsException<RomanNumberException>(() => num2 - num1);
            Assert.ThrowsException<RomanNumberException>(() => num1 - num3);
            Assert.ThrowsException<RomanNumberException>(() => num3 - num1);
            Assert.ThrowsException<RomanNumberException>(() => num3 - num3);
            Assert.ThrowsException<RomanNumberException>(() => num1 - num1);
        }

        [TestMethod()]
        public void MulTest()
        {
            var num1 = new RomanNumber(610);
            var num2 = new RomanNumber(3);
            var num3 = new RomanNumber(88);
            RomanNumber? num4 = null;

            Assert.AreEqual("MDCCCXXX", (num1 * num2).ToString());
            Assert.ThrowsException<RomanNumberException>(() => num1 * num3);
            Assert.ThrowsException<RomanNumberException>(() => num1 * num4);
            Assert.ThrowsException<RomanNumberException>(() => num4 * num1);
            Assert.ThrowsException<RomanNumberException>(() => num4 * num4);
        }

        [TestMethod()]
        public void DivTest()
        {
            var num1 = new RomanNumber(2422);
            var num2 = new RomanNumber(2);
            RomanNumber? num3 = null;

            Assert.AreEqual("MCCXI", (num1 / num2).ToString());
            Assert.AreEqual("I", (num1 / num1).ToString());
            Assert.ThrowsException<RomanNumberException>(() => num2 / num1);
            Assert.ThrowsException<RomanNumberException>(() => num3 / num3);
            Assert.ThrowsException<RomanNumberException>(() => num1 / num3);
            Assert.ThrowsException<RomanNumberException>(() => num3 / num1);

        }

    }
}