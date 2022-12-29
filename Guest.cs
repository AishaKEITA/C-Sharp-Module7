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
        private int phoneNumber;
        private string email;
        private int year;
        private double month;
        private double day;

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
        /// guest constructor with parameter
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="email"></param>
        /// <param name="year"></param>
        public Guest(string firstName, string lastName, int phoneNumber, string email, int year, int day, int month, Gender gender, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.year = year;
            this.day = day;
            this.month = month;
            this.gender = gender;


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
            year = theOther.year;
            this.address = new Address(theOther.address);
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
        /// method to get year
        /// </summary>
        public int GetYear()
        {
            return year;
        }
        /// <summary>
        /// method to set year
        /// </summary>
        /// <param name="year"></param>
        public void SetYear(int year)
        {
            if (year >= 0.0)
                this.year = year;
        }

        /// <summary>
        /// method to get day
        /// </summary>
        public double GetDay()
        {
            return day;
        }

        /// <summary>
        /// method to set day
        /// </summary>
        /// <param name="day"></param>
        public void SetDay(double day)
        {
            if (day >= 0.0)
                this.day = day;
        }
        /// <summary>
        /// method to get month
        /// </summary>
        public double GetMonth()
        {
            return month;
        }

        /// <summary>
        /// method to set month
        /// </summary>
        /// <param name="month"></param>
        public void SetMonth(double month)
        {
            this.month = month;
        }
        /// <summary>
        /// method to get and set phone number
        /// </summary>
        ///
        public int PhoneNumber
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
    }
}
