using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_Heranca_Poli_Aula132.Entities
{
    class UsedProduct : Product
    {
        public DateTime manufacturedDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime ManufacturedDate) : base (name, price)
        {
            manufacturedDate = ManufacturedDate;
        }

        public override string priceTag()
        {
            return base.priceTag() + $", Manufactured Date: {manufacturedDate.ToShortDateString()}";
        }
    }
}
