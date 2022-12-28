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
        private int age;

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
        /// <param name="age"></param>
        public Guest(string firstName, string lastName, int phoneNumber, string email, int age, Gender gender, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.age = age;
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
            age = theOther.age;
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
        /// method to get and set phone number
        /// </summary>
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
