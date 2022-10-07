using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_creational_pattern
{
    public class Product : IPrototype<Product>
    {
        public Guid Id => Guid.NewGuid();  

        public ProductType Type { get; set; }

        public string Name { get; set; }
        
        /// <summary>
        /// Returns copy of itself
        /// </summary>
        /// <returns></returns>
        public Product? Clone()
        {
            return this.MemberwiseClone() as Product;
        }
    }

    public enum ProductType
    {
        XRange,
        Series
    }
}
