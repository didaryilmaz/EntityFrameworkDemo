using System;
namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; } //primary key
        public int CategoryId { get; set; } //foreign key(diger tablolarla iliskilendiren)
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
