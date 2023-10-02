using System;
using System.Collections.Generic;

namespace DZ4_5
{
    public class Product
    {
        public decimal Price { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Name { get; set; }
        public DateTime PackagingDate { get; set; }
        public string Description { get; set; }
    }

    public class Goods : Product
    {
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class Books : Product
    {
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }
    }
}