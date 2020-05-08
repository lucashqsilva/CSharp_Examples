using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Encodings.Web;
using AbstractClass_Exercice.Entities;

namespace AbstractClass_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();

            Console.Write("Enter the number of Tax Payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or Company (i / c) ? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Payer Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double aincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {    
                    Console.Write("Healty Tax: ");
                    double hTax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, aincome, hTax));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, aincome, employees));
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double sum = 0.0;
            
            foreach (Payer payer in list)
            {
                double tx = payer.Tax();
                Console.WriteLine("tax payer: " + payer.Name + ", Taxes Paid: $ " + tx.ToString("F2", CultureInfo.InvariantCulture));
                sum += tx;
            }

            Console.Write("TOTAL TAXES PAID: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
