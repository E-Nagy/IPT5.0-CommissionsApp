using RoomReservationApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Exceptions
{
    internal class ReservationConflictException : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncomingReservation { get; }

        public ReservationConflictException(Reservation existingreservation, Reservation incomingreservation)
        {
            ExistingReservation = existingreservation;
            IncomingReservation = incomingreservation;
        }

        public ReservationConflictException(string message, Reservation existingreservation, Reservation incomingreservation)
        {
            ExistingReservation = existingreservation;
            IncomingReservation = incomingreservation;
        }

        public ReservationConflictException(string message, Exception innerException, Reservation existingreservation, Reservation incomingreservation)
        {
            ExistingReservation = existingreservation;
            IncomingReservation = incomingreservation;
        }


    }
}
