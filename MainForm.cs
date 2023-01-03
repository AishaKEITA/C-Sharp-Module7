using System;
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
            cmbNumberOfGuest.Items.AddRange(Enum.GetNames(typeof(NumberOfGuest)));
            cmbNumberOfGuest.SelectedIndex = (int)NumberOfGuest.Adult0;

            cmbNumberOfChildren.Items.AddRange(Enum.GetNames(typeof(NumberOfChildren)));
            cmbNumberOfChildren.SelectedIndex = (int)NumberOfChildren.child0;


            cmbRoomType.Items.AddRange(Enum.GetNames(typeof(RoomTypes)));
            cmbRoomType.SelectedIndex = (int)RoomTypes.Single;

            cmbFloor.Items.AddRange(Enum.GetNames(typeof(Floors)));
            cmbFloor.SelectedIndex = (int)Floors.One;
        }
        /// <summary>
        /// read guest first name, last name,  email and phone number
        /// </summary>
        /// <returns></returns>
        private Guest ReadGuestInput()
        {
            Guest guest = new Guest();
            guest.BirthdayDate = dateTimePicker3.Value;
            guest.CheckIn = dateTimePicker1.Value;
            guest.CheckOut = dateTimePicker2.Value;

            guest.Gender = (Gender)cmbGender.SelectedIndex;
            guest.NumberOfGuest = (NumberOfGuest)cmbNumberOfGuest.SelectedIndex;
            guest.NumberOfChildren = (NumberOfChildren)cmbNumberOfChildren.SelectedIndex;
            guest.RoomTypes = (RoomTypes)cmbRoomType.SelectedIndex;
            guest.Floors = (Floors)cmbFloor.SelectedIndex;
            guest.FirstName = txtFirstName.Text;
            guest.LastName = txtLastName.Text;
            guest.Email = txtEmail.Text;

            guest.PhoneNumber = txtPhoneNumber.Text;

            Console.WriteLine(txtFirstName.Text);
            Console.WriteLine(txtLastName.Text);
            Console.WriteLine(txtPhoneNumber.Text);

            Console.WriteLine(txtEmail.Text);
            Console.WriteLine(dateTimePicker3.Value);
            Console.WriteLine(guest.Gender);
            Console.WriteLine(guest.NumberOfGuest);
            Console.WriteLine(guest.NumberOfChildren);
            Console.WriteLine(guest.RoomTypes);
            Console.WriteLine(guest.Floors);
            Console.WriteLine(dateTimePicker1.Value);
            Console.WriteLine(dateTimePicker2.Value);
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
            //cmbNumberOfGuest.SelectedIndex = c;
            Console.WriteLine("Btn click");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
