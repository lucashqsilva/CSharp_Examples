using Exercice_Exception.Entities;
using Exercice_Exception.Entities.Exceptions;
using System;
using System.Globalization;

namespace Exercice_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder Name: ");
                string name = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw Limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, name, balance, limit);

                Console.WriteLine();

                Console.Write("Enter Amount fot Withdraw: ");
                double w = double.Parse(Console.ReadLine());
                acc.Withdraw(w);

            }catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
