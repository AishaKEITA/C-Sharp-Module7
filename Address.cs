using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment7
{
    internal class Address
    {
        //fields
        private string city;
        private string postCode;
        private string street;
        private Address address;
        /// <summary>
        /// constructor contact info
        /// </summary>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        public Address(string city, string postCode, string street)
        {
            this.city = city;
            this.postCode = postCode;
            this.street = street;
        }
         /// <summary>
        /// contact constructor
        /// </summary>
        public Address()
        {
        }
        /// <summary>
        /// getter and setter for city
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// getter and setter for post code
        /// </summary>
        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }


        /// <summary>
        /// address constructor with a parameter
        /// </summary>
        /// <param name="address"></param>
        public Address(Address address)
        {
            this.address = address;
        }

        /// <summary>
        /// method to check so city is not empty or null string
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public bool Validate()
        {
            if (string.IsNullOrEmpty(city))
            {
                return false;
            }

            return true;
        }
    }
}
