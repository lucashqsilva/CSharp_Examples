using Ex_Heranca_Poli_Aula132.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Ex_Heranca_Poli_Aula132
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, Used or Imported? (c / u / i): ");
                char type = char.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Product Name: ");
                string name = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'u')
                {
                    Console.Write("Manufactured Date (DD/MM/YYYY): ");
                    DateTime Mdate = DateTime.Parse(Console.ReadLine());
                    //string date = Mdate.ToShortDateString();
                    Console.WriteLine();

                    productList.Add(new UsedProduct(name, price, Mdate));
                }
                else if (type == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();

                    productList.Add(new importedProduct(name, price, customsFee));
                }
                else
                {
                    Console.WriteLine();
                    productList.Add(new Product(name, price));
                }
            }

            Console.WriteLine();

            foreach (Product product in productList)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
