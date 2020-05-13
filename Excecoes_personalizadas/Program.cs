using System;
using Excecoes_personalizadas.Entities;
using Excecoes_personalizadas.Entities.Exceptions;

namespace Excecoes_personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date(dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date(dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter data to update reservation: ");
                Console.Write("Check-in Date: ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out Date: ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
