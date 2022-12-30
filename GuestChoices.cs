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
        private Guest guest;
        private DateTime _checkIn;
        private DateTime _checkOut;
        private double totalPrice;
        private Floors floor;
        private RoomTypes roomType;
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
        public GuestChoices(int numberOfRooms, int floors,
            DateTime checkIn, DateTime checkOut, RoomTypes roomType, Floors floor, Guest guest)
        {
            this.numberOfRooms = numberOfRooms;
            this.floor = floor;
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
            this.floor = theOther.floor;
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

        /// <summary>
        /// method to get and set room types
        /// </summary>
        public RoomTypes RoomTypes
        {
            get { return roomType; }
            set { roomType = value; }
        }

        /// <summary>
        /// method to get and sett floors
        /// </summary>
        public Floors Floors
        {
            get { return floor; }
            set { floor = value; }
        }

        /// <summary>
        /// method to check in
        /// </summary>
        private DateTime CheckIn
        {
            get { return _checkIn; }
            set
            {
                if (value != _checkIn && value < _checkOut)
                {
                    _checkIn = value;
                }
                //Ui update for totalprice
                totalPrice = CalculateTotalPrice();
            }
        }

        /// <summary>
        /// method to checkout
        /// </summary>
        private DateTime CheckOut
        {
            get { return _checkOut; }
            set
            {
                if (value != _checkOut && value < _checkIn)
                {
                    _checkOut = value;
                }
                //ui update for totalprice
                totalPrice = CalculateTotalPrice();
            }
        }

        /// <summary>
        /// method to get total price
        /// </summary>
        /// <returns></returns>
        public double GetTotalPrice()
        {
                return totalPrice;
        }

        /// <summary>
        /// method to set total price
        /// </summary>
        /// <param name="totalPrice"></param>
        public void SetTotalPrice(double totalPrice)
        {
            if (totalPrice != 0.0)
                this.totalPrice = totalPrice;
        }

        /// <summary>
        /// method to calculate total price
        /// </summary>
        /// <returns></returns>
        private double CalculateTotalPrice()
        {
            double amountPerDay = 1500;
            return (CheckOut - CheckIn).TotalDays * amountPerDay;
        }
    }
}
