using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Core.Domain
{
    public class Product
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public float Price { get; protected set; }
        public int ProductCategoryId { get; protected set; }
        public ProductCategory ProductCategory { get; protected set; }
        public bool Active { get; protected set; }
        public DateTime DateCreated { get; set; }

        public Product(int id, string name, float price, ProductCategory productCategory)
        {
            Id = id;
            Name = name;
            Price = price;
            ProductCategory = productCategory;
            Active = true;
            DateCreated = DateTime.UtcNow;
        }
    }
}
