using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ex_Heranca_Poli_Aula132.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return ($"Product Name: {Name}, Price: $ {Price.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
