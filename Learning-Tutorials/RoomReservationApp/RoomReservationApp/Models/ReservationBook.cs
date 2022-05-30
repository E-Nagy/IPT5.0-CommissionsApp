using RoomReservationApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class ReservationBook
    {

        private readonly List<Reservation> reservations;

        public ReservationBook()
        {
            reservations = new List<Reservation>();
        }


        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return reservations.Where(r => r.UserName == username);
        }

        public void AddReservations(Reservation reservation)
        {
            foreach (Reservation existingReservation in reservations)
            {
                if (existingReservation.ReservationConflict(reservation))
                {
                    throw new ReservationConflictException(existingReservation, reservation);
                }
            }

            reservations.Add(reservation);
        }

        
    }
}
