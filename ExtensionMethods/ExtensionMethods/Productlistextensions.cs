using System.Collections.Generic;

namespace ExtensionMethods
{
    public static class ProductListExtensions
    {
        public static decimal AveragePrice(this List<Product> list)
        {
            if (list.Count == 0) return 0;
            decimal total = 0;
            foreach (Product p in list)
            {
                total += p.Price;
            }
            return total / list.Count;
        }

        public static decimal MaxPrice(this List<Product> list)
        {
            if (list.Count == 0) return 0;
            decimal max = list[0].Price;
            foreach (Product p in list)
            {
                if (p.Price > max) max = p.Price;
            }
            return max;
        }
        public static decimal MinPrice(this List<Product> list)
        {
            if (list.Count == 0) return 0;
            decimal min = list[0].Price;
            foreach (Product p in list)
            {
                if (p.Price < min) min = p.Price;
            }
            return min;
        }

        public static int StockQuantity(this List<Product> list)
        {
            int total = 0;
            foreach (Product p in list)
            {
                total += p.Quantity;
            }
            return total;
        }
        public static decimal StockValue(this List<Product> list)
        {
            decimal total = 0;
            foreach (Product p in list)
            {
                total += p.Price * p.Quantity;
            }
            return total;
        }
    }
}