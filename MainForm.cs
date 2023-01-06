using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignmment7
{
    public partial class MainForm : Form
    {
        GuestManager guestManager;

        public MainForm()
        {
            InitializeComponent();
            IntializeGui();
        }

        /// <summary>
        /// show this when the gui starts
        /// </summary>
        private void IntializeGui()
        {
           guestManager = new GuestManager();

            this.Text = "Sha Hotel Boking System designed by Aisha";

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            cmbGender.Items.AddRange(Enum.GetNames(typeof(Gender)));
            cmbGender.SelectedIndex = (int)Gender.Female;

            cmbNumberOfGuest.DataSource = Enum.GetValues(typeof(NumberOfGuest))
                            .Cast<NumberOfGuest>()
                            .Select(x => (int)x)
                            .ToList();

            Console.WriteLine(cmbNumberOfGuest.SelectedIndex);
            cmbNumberOfChildren.DataSource = Enum.GetValues(typeof(NumberOfChildren))
                            .Cast<NumberOfChildren>()
                            .Select(x => (int)x)
                            .ToList();

            cmbRoomType.Items.AddRange(Enum.GetNames(typeof(RoomTypes)));
            cmbRoomType.SelectedIndex = (int)RoomTypes.Single;

            cmbFloor.Items.AddRange(Enum.GetNames(typeof(Floors)));
            cmbFloor.SelectedIndex = (int)Floors.One;

            btnCalculateBill.Enabled = false;
            btnEditBooking.Enabled = false;
            btnDelete.Enabled = false;
        }

        /// <summary>
        /// update gui
        /// </summary>
        private void UpdateGui()
        {

            string[] infoStrings = guestManager.GetInfoStringsList();
            if (infoStrings != null)
            {
                lstGuest.Items.Clear();
                lstGuest.Items.AddRange(infoStrings);
            }
        }
        /// <summary>
        /// read guest first name, last name,  email and phone number
        /// </summary>
        /// <returns></returns>
        private Guest ReadGuestInput()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                return null;
            }

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

            return guest;
        }
        /// <summary>
        /// method to read address input
        /// </summary>
        /// <returns></returns>
        private Address ReadAdressInput()
        {
            if (string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtCity.Text) ||
                string.IsNullOrEmpty(txtPostCode.Text))
            {
                return null;
            }

            Address address = new Address();

            address.Street = txtAddress.Text;
            address.City = txtCity.Text;
            address.PostCode = txtPostCode.Text;

            return address;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// add guest to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddGuest_Click_1(object sender, EventArgs e)
        {
            Address address =  ReadAdressInput();
            Guest guest = ReadGuestInput();

            if ((address == null) || (guest == null))
            {
                MessageBox.Show("Please answer all questions");
                return;
            }

            if (guestManager.AddGuest(guest))
                UpdateGui();

            btnCalculateBill.Enabled = true;
            btnEditBooking.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// method to calculate the total payment for guest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBill_Click(object sender, EventArgs e)
        {
            Guest guest = ReadGuestInput();
            lblShowPrice.Text = guest.CalculateTotalPrice().ToString( "SEK: " + "0.00");
        }

        private void lstGuest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstGuest_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// edit button to change booking
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditBooking_Click(object sender, EventArgs e)
        {
            int index = lstGuest.SelectedIndex;
            if (index >= 0) ;
            Guest guest = ReadGuestInput();
            bool ok = guestManager.ChangeGuestAt(guest, index);
            if (ok)
                UpdateGui();
        }

        /// <summary>
        /// select and guest in the list box if  it's lees than zero
        /// display a message
        /// return -1
        /// otherwise return idex
        /// </summary>
        /// <returns></returns>
        private int lstBoxItemSelected()
        {
            int index = lstGuest.SelectedIndex;
            if (lstGuest.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item from the list");
                return -1;
            }
            else
                return index;
        }

        /// <summary>
        /// delete guest info from  list box
        /// display a message to make sure the user is satisfied to delete or not
        /// if so update the gui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstBoxItemSelected();
            string MessageBoxTitle = "";
            string MessageBoxContent = "Are you sure you want to delete this guest info?";
            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);


            if (index < 0)
            {
                return;
            }
            if (dialogResult == DialogResult.Yes)
            {
                guestManager.DeleteGuestAt(index);

                UpdateGui();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
