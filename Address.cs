using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmment7
{
    internal class ContactInfo
    {
        //fields
        private string city;
        private string postCode;
        private ContactInfo contact;
        private Gender gender;
        /// <summary>
        /// constructor contact info
        /// </summary>
        /// <param name="city"></param>
        /// <param name="postCode"></param>
        public ContactInfo(string city, string postCode, Gender gender)
        {
            this.city = city;
            this.postCode = postCode;
            this.gender = gender;
        }
         /// <summary>
        /// contact constructor
        /// </summary>
        public ContactInfo()
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

        /// <summary>
        /// address constructor with a parameter
        /// </summary>
        /// <param name="address"></param>
        public ContactInfo(ContactInfo address)
        {
            this.contact = address;
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
