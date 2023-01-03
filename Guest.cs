using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment7
{
    internal class Guest
    {
        //fields
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private DateTime _birthday;
        private DateTime _checkIn;
        private DateTime _checkOut;
        private double totalPrice;

        private NumberOfGuest numberOfGuest;
        private NumberOfChildren numberOfChildren;
        private Floors floor;
        private RoomTypes roomType;
        private Gender gender;
        private Address address;

        /// <summary>
        /// constructor guest which uses contact info
        /// </summary>
        public Guest()
        {
            address = new Address();
        }

        /// <summary>
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        /// <param name="numberOfRooms"></param>
        /// <param name="floors"></param>
        /// <param name="checkIn"></param>
        /// <param name="checkOut"></param>
        /// <param name="birthday"></param>
        /// <param name="roomType"></param>
        /// <param name="floor"></param>
        public Guest(string firstName, string lastName, string phoneNumber,
            string email, Gender gender, Address address,
            int floors,
            DateTime checkIn, DateTime checkOut, DateTime birthday,
            NumberOfGuest numberOfGuest, NumberOfChildren numberOfChildren,
            RoomTypes roomType, Floors floor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.gender = gender;
            this.floor = floor;
            this.numberOfGuest = numberOfGuest;
            this.numberOfChildren = numberOfChildren;
            _checkIn = checkIn;
            _checkOut = checkOut;
            _birthday = birthday;
            this.roomType = roomType;


            if (address != null)

                this.address = address;

            else
                address = new Address();
        }

        /// <summary>
        /// method to create a copy of guest
        /// other is another constructor
        /// </summary>
        /// <param name="theOther"></param>
        public Guest(Guest theOther)
        {
            firstName = theOther.firstName;
            lastName = theOther.lastName;
            phoneNumber = theOther.phoneNumber;
            email = theOther.email;
            this.address = new Address(theOther.address);
            this.numberOfGuest = theOther.numberOfGuest;
            this.floor = theOther.floor;
            _checkIn = theOther._checkIn;
            _checkOut = theOther._checkOut;
            _birthday = theOther._birthday;
        }

        public Guest(string firstName, string lastName, string phoneNumber,
            string email, NumberOfGuest numberOfGuest, NumberOfChildren numberOfChildren,
            Floors floor, RoomTypes roomType,
            Gender gender, DateTime checkIn, DateTime checkOut,
            DateTime birthday, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.numberOfGuest = numberOfGuest;
            this.numberOfChildren = numberOfChildren;
            this.floor = floor;
            this.roomType = roomType;
            this.gender = gender;
            CheckIn = checkIn;
            CheckOut = checkOut;
            this.address = address;
            BirthdayDate = birthday;
        }

        public Guest(string firstName, string lastName,
            string phoneNumber, string email, int year, double month,
            double day, NumberOfGuest numberOfGuest, NumberOfChildren numberOfChildren,
            Floors floor, RoomTypes roomType,
            Gender gender, DateTime checkIn,
            DateTime checkOut, DateTime birthday, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            Year = year;
            Month = month;
            Day = day;
            this.numberOfGuest = numberOfGuest;
            this.floor = floor;
            this.roomType = roomType;
            this.gender = gender;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Birthday = birthday;
            this.address = address;
        }

        /// <summary>
        /// method to get and set address
        /// </summary>
        public Address ContactInfo
        {
            get { return address; }
            set { address = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        /// <summary>
        /// method to get and set first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// method to get an set last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        /// <summary>
        /// method to get and set phone number
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
            }
        }

        /// <summary>
        /// method to get and set email
        /// </summary>
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        /// <summary>
        /// get and set birthday for the user
        /// </summary>
        public DateTime BirthdayDate
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        /// <summary>
        /// get and set for number of guest
        /// </summary>
        /// <returns></returns>
       public NumberOfGuest NumberOfGuest
        {
            get { return numberOfGuest; }
            set { numberOfGuest = value; }
        }

        /// <summary>
        /// get and set for number of children
        /// </summary>
        /// <returns></returns>
        public NumberOfChildren NumberOfChildren
        {
            get { return numberOfChildren; }
            set { numberOfChildren = value; }
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

        public int Year { get; }
        public double Month { get; }
        public double Day { get; }
        public DateTime Birthday { get; }

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
