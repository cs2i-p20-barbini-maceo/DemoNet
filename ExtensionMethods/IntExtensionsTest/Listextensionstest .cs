using ExtensionMethods;
using System.Collections.Generic;

namespace ListExtensionsTest
{
    [TestClass]
    public class ListExtensionsTest
    {
        [TestMethod]
        public void TestToUpper()
        {
            var list = new List<string> { "alpha", "Bravo" };
            var expected = new List<string> { "ALPHA", "BRAVO" };

            CollectionAssert.AreEqual(expected, list.ToUpper());
        }

        [TestMethod]
        public void TestToLower()
        {
            var list = new List<string> { "ALPHA", "Bravo" };
            var expected = new List<string> { "alpha", "bravo" };

            CollectionAssert.AreEqual(expected, list.ToLower());
        }
        [TestMethod]
        public void TestLonguestString()
        {
            var list = new List<string> { "Fox", "Foxtrot", "India" };
            Assert.AreEqual("Foxtrot", list.LonguestString());
        }

        [TestMethod]
        public void TestShortestString()
        {
            var list = new List<string> { "Foxtrot", "Fox", "India" };

            Assert.AreEqual("Fox", list.ShortestString());
        }

        [TestMethod]
        public void TestMaxValue()
        {
            var list = new List<int> { 4, 12, -3, 7 };

            Assert.AreEqual(12, list.MaxValue());
        }

        [TestMethod]
        public void TestMinValue()
        {
            var list = new List<int> { 4, 12, -3, 7 };

            Assert.AreEqual(-3, list.MinValue());
        }
        [TestMethod]
        public void TestListTotal()
        {
            var list = new List<int> { 2, 4, 6 };

            Assert.AreEqual(12, list.ListTotal());
        }

        [TestMethod]
        public void TestListAverage()
        {
            var list = new List<int> { 1, 2 };

            Assert.AreEqual(1.5, list.ListAverage());
        }

    }
}

