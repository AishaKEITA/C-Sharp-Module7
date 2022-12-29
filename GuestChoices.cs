using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment7
{
    internal class GuestChoices
    {
        private int numberOfRooms;
        public int floors;
        private RoomTypes roomType;
        private Guest guest;
        private DateTime _checkIn;
        private DateTime _checkOut;
        /// <summary>
        /// constructor GuestChoices which uses the guest class
        /// </summary>
        public GuestChoices()
        {
            guest = new Guest();
        }

        /// <summary>
        /// guest choices parameters
        /// </summary>
        /// <param name="numberOfRooms"></param>
        /// <param name="floors"></param>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        /// <param name="roomType"></param>
        /// <param name="guest"></param>
        public  GuestChoices(int numberOfRooms, int floors,
            DateTime checkIn, DateTime checkOut, RoomTypes roomType, Guest guest)
        {
            this.numberOfRooms = numberOfRooms;
            this.floors = floors;
            _checkIn = checkIn;
            _checkOut = checkOut;
            this.roomType = roomType;

            if (guest != null)
                this.guest = guest;
            else
                guest = new Guest();
        }
        /// <summary>
        /// method to create a copy of guest choices
        /// </summary>
        /// <param name="theOther"></param>
        public GuestChoices(GuestChoices theOther)
        {
            this.numberOfRooms = theOther.numberOfRooms;
            this.floors = theOther.floors;
            _checkIn = theOther._checkIn;
            _checkOut = theOther._checkOut;
            this.roomType = theOther.roomType;
            this.guest = new Guest(theOther.guest);
        }

        /// <summary>
        /// getter and setter for guest
        /// </summary>
        public Guest Guest
        {
            get { return this.guest; }
            set { this.guest = value; }
        }

        /// <summary>
        /// geter for number of rooms
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfRooms()
        {
            return numberOfRooms;
        }

        /// <summary>
        /// setter fot number of rooms
        /// </summary>
        /// <param name="numberOfRooms"></param>
        public void SetNumberOfRooms(int numberOfRooms)
        {
            if (numberOfRooms >= 0)
            this.numberOfRooms = numberOfRooms;
        }
    }
}
