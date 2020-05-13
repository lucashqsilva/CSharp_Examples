using Excecoes_personalizadas.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Excecoes_personalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out must be after check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            //utilizando timespam para conseguir calcular a diferença entre os dias
            //subtract já está fazendo o processo de subtração das datas
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            
            //utilizando casting para converter para inteiro (totaldays é double)
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            
            if(checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be futures dates");
            }
            if(checkOut <= checkIn)
            {
                throw new DomainException("Check-Out must be after check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-Out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
