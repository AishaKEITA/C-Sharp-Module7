using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment7
{
    internal class GuestManager
    {
        //method to add guest
        // method to edit guest
        // method to delete guest
        private List<Guest> guests;

        public GuestManager()
        {
            guests = new List<Guest>();
        }


        /// <summary>
        /// method to count the number of guests
        /// </summary>
        public int Count
        {
            get { return guests.Count; }
        }

        /// <summary>
        /// method to add guests to checkin
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="numberOfRooms"></param>
        /// <param name="_checkIn"></param>
        /// <param name="_checkOut"></param>
        /// <param name="floor"></param>
        /// <param name="roomType"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool AddGuest(string firstName, string lastName, int phoneNumber, string email,
            int year, double month, double day, int numberOfRooms, DateTime _checkIn, DateTime _checkOut,
           Floors floor, RoomTypes roomType, Gender gender, Address address)
        {

            Guest guest = new Guest(firstName, lastName, phoneNumber, email, year, month, day,
                numberOfRooms, floor, roomType, gender, _checkIn, _checkOut, address);
            guests.Add(guest);
            return true;
        }


    }

}
