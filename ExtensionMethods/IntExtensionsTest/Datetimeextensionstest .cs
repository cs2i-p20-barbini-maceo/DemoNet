using ExtensionMethods;

namespace DateTimeExtensionsTest
{
    [TestClass]
    public class DateTimeExtensionsTest
    {
        [TestMethod]
        public void TestToIso8601()
        {
            var a = new DateTime(2024, 3, 5);
            Assert.AreEqual("2024-03-05", a.ToIso8601());
        }

        [TestMethod]
        public void TestIsBetween()
        {
            var d1 = new DateTime(2024, 1, 1);
            var d2 = new DateTime(2024, 12, 31);

            Assert.IsTrue(new DateTime(2024, 6, 15).IsBetween(d1, d2));
            Assert.IsFalse(new DateTime(2025, 1, 1).IsBetween(d1, d2));

            Assert.IsFalse(new DateTime(2023, 12, 31).IsBetween(d1, d2));
        }

        [TestMethod]
        public void TestIsWeekDay()
        {
            Assert.IsTrue(new DateTime(2024, 1, 5).IsWeekDay());
            Assert.IsFalse(new DateTime(2024, 1, 6).IsWeekDay());
        }

        [TestMethod]
        public void TestIsWeekEnd()
        {
            Assert.IsTrue(new DateTime(2024, 1, 6).IsWeekEnd());
            Assert.IsTrue(new DateTime(2024, 1, 7).IsWeekEnd());

            Assert.IsFalse(new DateTime(2024, 1, 8).IsWeekEnd());
        }

        [TestMethod]
        public void TestIsLeapYear()
        {
            Assert.IsTrue(new DateTime(2024, 1, 1).IsLeapYear());

            Assert.IsTrue(new DateTime(2000, 1, 1).IsLeapYear());
            Assert.IsFalse(new DateTime(1900, 1, 1).IsLeapYear());
            Assert.IsFalse(new DateTime(2023, 1, 1).IsLeapYear());
        }
    }
}