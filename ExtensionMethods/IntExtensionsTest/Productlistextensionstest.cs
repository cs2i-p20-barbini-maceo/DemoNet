using ExtensionMethods;
using System.Collections.Generic;

namespace ProductListExtensionsTest
{
    [TestClass]
    public class ProductListExtensionsTest
    {
        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product(1, "Stylo", 10, 2),
                new Product(2, "Cahier", 20, 3),
                new Product(3, "Sac", 30, 1)
            };
        }

        [TestMethod]
        public void TestAveragePrice()
        {
            Assert.AreEqual(20m, GetProducts().AveragePrice());
        }

        [TestMethod]
        public void TestMaxPrice()
        {
            Assert.AreEqual(30m, GetProducts().MaxPrice());
        }
        [TestMethod]
        public void TestMinPrice()
        {
            Assert.AreEqual(10m, GetProducts().MinPrice());
        }

        [TestMethod]
        public void TestStockQuantity()
        {
            Assert.AreEqual(6, GetProducts().StockQuantity());
        }
        [TestMethod]
        public void TestStockValue()
        {
            Assert.AreEqual(110m, GetProducts().StockValue());
        }
    }
}