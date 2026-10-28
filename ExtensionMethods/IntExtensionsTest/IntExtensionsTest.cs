using ExtensionMethods;
namespace IntExtensionsTest
{
    [TestClass]
    public class IntExtensionsTest
    {
        [TestMethod]
        public void TestIsEven()
        {
            var x = 12;
            Assert.AreEqual(true, x.IsEven());
            Assert.IsTrue(x.IsEven());

            var y = 5;
            Assert.IsFalse(y.IsEven());

            Assert.IsTrue(208.IsEven());
        }
        [TestMethod]

        public void TestIsOdd()
        {
            Assert.IsTrue(5.IsOdd());
            Assert.IsFalse(10.IsOdd());
        }

        [TestMethod]
        public void Test()
        {
            var x = 100;
            Assert.IsTrue(x.IsDivisibleBy(25));
            Assert.IsFalse(x.IsDivisibleBy(3));
        }
        [TestMethod]

        public void TestLeft()
        {
            var s = "Foxtrot";
            Assert.AreEqual("Fox", s.Left(3));
        }
        [TestMethod]

        public void Maxchars()
        {
            var s = "Foxtrot";
            Assert.AreEqual("Foxtrot", s.Left(10));
        }
        [TestMethod]

        public void TestLeftNegative()
        {
            var s = "Fox";
            Assert.AreEqual("Fox", s.Left(-2));
        }
        [TestMethod]


        public void TestRight()
        {
            var s = "Foxtrot";
            Assert.AreEqual("trot", s.Right(4));
        }
        [TestMethod]


        public void TestRightMaxchars()
        {
            var s = "Foxtrot";
            Assert.AreEqual("Foxtrot", s.Right(10));
        }
        [TestMethod]

        public void TestRightNegative()
        {
            var s = "Fox";
            Assert.AreEqual("Fox", s.Right(-2));
        }
    }
}
