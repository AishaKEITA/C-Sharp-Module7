using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmment7
{
    public partial class MainForm : Form
    {
        private GuestManager guestManager;
        private Guest guest;

        public MainForm()
        {
            InitializeComponent();
            IntializeGui();
        }

        private void IntializeGui()
        {
            this.Text = "Sha Hotel Boking system designed by Aisha";
            cmbGender.Items.AddRange(Enum.GetNames(typeof(Gender)));
            cmbGender.SelectedIndex = (int)Gender.Female;
        }

        private void ReadGuestInput()
        {
            ReadFirstName();
            ReadLastName();
            ReadPhoneNumber();
            ReadEmailInput();
            ReadStreetInput();
            guest.BirthdayDate = dateTimePicker3.Value;
            guest.Gender = (Gender)cmbGender.SelectedIndex;
            Console.WriteLine(dateTimePicker3.Value);
            Console.WriteLine(guest.Gender);
        }

        /// <summary>
        /// read first name of the guest
        /// </summary>
        private void ReadFirstName()
        {
            guest = new Guest();
            string name;
            name = txtFirstName.Text;
            name = name.Trim();
            if (!string.IsNullOrEmpty(name))
                guest.FirstName = name;

            Console.WriteLine(name);
        }

        /// <summary>
        /// read last name of the guest
        /// </summary>
        private void ReadLastName()
        {
            guest = new Guest();
            string lastName;
            lastName = txtLastName.Text;
            lastName = lastName.Trim();
            if (!string.IsNullOrEmpty(lastName))
                guest.LastName = lastName;

            Console.WriteLine(lastName);
        }
        /// <summary>
        /// method to read phone number from the guest
        /// </summary>
        private void ReadPhoneNumber()
        {
            int phoneNumber;
            phoneNumber = Convert.ToInt32(txtPhoneNumber.Text);
            Console.WriteLine(phoneNumber);
        }

        /// <summary>
        /// method to read guest email
        /// </summary>
        private void ReadEmailInput()
        {
            string email;
            email = txtEmail.Text;
            email = email.Trim();
            if (string.IsNullOrEmpty(email)) ;
            Console.WriteLine(email);
        }

        /// <summary>
        /// method to read guest street
        /// </summary>
        private void ReadStreetInput()
        {
            string street;
            street = txtAddress.Text;
            street = street.Trim();
            if (!string.IsNullOrEmpty(street)) ;
            Console.WriteLine(street);
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGuest_Click_1(object sender, EventArgs e)
        {
            ReadGuestInput();
            Console.WriteLine("Btn click");
        }
    }
}
