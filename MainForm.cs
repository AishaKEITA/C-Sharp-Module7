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

        /// <summary>
        /// read guest first name, last name,  email and phone number
        /// </summary>
        /// <returns></returns>
        private Guest ReadGuestInput()
        {
            Guest guest = new Guest();
            string phoneNumber;
            guest.BirthdayDate = dateTimePicker3.Value;
            guest.Gender = (Gender)cmbGender.SelectedIndex;
            guest.FirstName = txtFirstName.Text;
            guest.LastName = txtLastName.Text;
            guest.Email = txtEmail.Text;

            phoneNumber = txtPhoneNumber.Text;
            guest.PhoneNumber = Convert.ToInt32(txtPhoneNumber.Text);

            Console.WriteLine(txtFirstName.Text);
            Console.WriteLine(txtLastName.Text);
            Console.WriteLine(txtPhoneNumber.Text);

            Console.WriteLine(txtEmail.Text);
            Console.WriteLine(dateTimePicker3.Value);
            Console.WriteLine(guest.Gender);

            return guest;
        }

        /// <summary>
        /// method to read address input
        /// </summary>
        /// <returns></returns>
        private Address ReadAdressInput()
        {
            Address address = new Address();
            address.City = txtAddress.Text;
            address.City = txtCity.Text;
            address.PostCode = txtPostCode.Text;

            Console.WriteLine(txtAddress.Text);
            Console.WriteLine(txtCity.Text);
            Console.WriteLine(txtPostCode.Text);
            return address;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGuest_Click_1(object sender, EventArgs e)
        {
            Guest guest = ReadGuestInput();
            Address address =  ReadAdressInput();

            Console.WriteLine("Btn click");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
