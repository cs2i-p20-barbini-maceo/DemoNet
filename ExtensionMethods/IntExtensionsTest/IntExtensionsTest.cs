using ExtensionMethods;

namespace IntExtensionsTest
{
    [TestClass]
    public class IntExtensionsTest
    {
        [TestMethod]
        public void TestLeft()
        {
            Assert.AreEqual("Fox", "Foxtrot".Left(3));

            Assert.AreEqual("Foxtrot", "Foxtrot".Left(9));
            Assert.AreEqual("Fox", "Fox".Left(-2));
        }

        [TestMethod]
        public void TestRight()
        {
            Assert.AreEqual("trot", "Foxtrot".Right(4));

            Assert.AreEqual("Foxtrot", "Foxtrot".Right(10));
            Assert.AreEqual("Fox", "Fox".Right(-2));
        }

        [TestMethod]
        public void TestEllipsis()
        {
            Assert.AreEqual("Alpha...", "Alpha Bravo".Ellipsis(5));

            Assert.AreEqual("Alpha++", "Alpha Bravo".Ellipsis(5, "++"));
            Assert.AreEqual("Alpha Bravo", "Alpha Bravo".Ellipsis(11));
            Assert.AreEqual("Alpha Bravo", "Alpha Bravo".Ellipsis(20));
        }

        [TestMethod]
        public void TestFillLeft()
        {
            Assert.AreEqual("Indi", "India".FillLeft(4));
            Assert.AreEqual("  India", "India".FillLeft(7));

            Assert.AreEqual("##India", "India".FillLeft(7, '#'));
        }

    }
}