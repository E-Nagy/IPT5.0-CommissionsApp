using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    internal class Reservation
    {
        
        public RoomID RoomID { get;}
        public DateTime ReservationStart { get;}
        public DateTime ReservationEnd { get;}

        public Reservation(RoomID roomID, DateTime reservationStart, DateTime reservationEnd)
        {
            RoomID = roomID;
            ReservationStart = reservationStart;
            ReservationEnd = reservationEnd;
        }

    }
}
