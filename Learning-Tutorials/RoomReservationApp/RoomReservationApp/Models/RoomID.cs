using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservationApp.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }

        public int RoomNumber { get; }


        public RoomID(int floornumber, int roomnumber)
        {
            FloorNumber = floornumber;
            RoomNumber = roomnumber;
        }

        //Turning the RoomID into string for the View
        public override string ToString()
        {
            return $"{FloorNumber} {RoomNumber}";
        }

        //override so ReservationBook can compare Key
        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID
                && FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        //Hashcode will combine Properties into unique hashcode
        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if(roomID1 is null && roomID2 is null)
            {
                return true;
            }

            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }
    }
}
