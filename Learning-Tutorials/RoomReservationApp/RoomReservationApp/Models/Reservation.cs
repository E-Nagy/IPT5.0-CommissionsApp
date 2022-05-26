using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class Reservation
    {
        
        public RoomID RoomID { get;}
        public string UserName { get;}
        public DateTime ReservationStart { get;}
        public DateTime ReservationEnd { get;}

        public TimeSpan ReservationTime => ReservationEnd.Subtract(ReservationStart);


        public Reservation(RoomID roomID, string username, DateTime reservationStart, DateTime reservationEnd)
        {
            RoomID = roomID;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
        }

       

        internal bool ReservationConflict(Reservation reservation)
        {
            if (reservation.RoomID != RoomID)
            {
                return false;
            }

            return reservation.ReservationStart < ReservationEnd || reservation.ReservationEnd > ReservationStart;
        }
    }
}
