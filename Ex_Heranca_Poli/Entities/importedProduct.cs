using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

namespace Ex_Heranca_Poli_Aula132.Entities
{
    class importedProduct : Product
    {
        public double customsFee { get; set; }

        public importedProduct()
        {
        }

        public importedProduct(string name, double price, double CustomsFee) : base (name, price)
        {
            customsFee = CustomsFee;
        }

        public double totalPrice()
        {
            return Price + customsFee;
        }

        public override string priceTag()
        {
            return ($"Product Name: {Name}, " +
                $"Price: $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"(Customs Fee: {customsFee.ToString("F2", CultureInfo.InvariantCulture)})");
        }
    }
}
