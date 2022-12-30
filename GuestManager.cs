using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

        /// <summary>
        /// method to add a guest
        /// </summary>
        /// <param name="GuestIn"></param>
        /// <returns></returns>
        public bool AddGuest (Guest GuestIn)
        {
            if (guests == null)
                return false;
            guests.Add(GuestIn);
            return true ;
        }

        /// <summary>
        /// return the position of the and see if is greater and equal 0
        /// and less than the number of guest
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < guests.Count);
        }

        /// <summary>
        /// method to get participant at a certain position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Guest GetGuest(int index)
        {
            if (CheckIndex(index))
                return guests[index];

            return null;
        }

        /// <summary>
        /// method to change participant
        /// </summary>
        /// <param name="GuestIn"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool ChangeGuestAt(Guest GuestIn, int index)
        {
            if ((GuestIn == null) || !CheckIndex(index))
                return false;
             guests[index] = GuestIn;
            return true;
        }
    }

}
