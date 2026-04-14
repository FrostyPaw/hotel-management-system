using System;
using System.Windows.Forms;
using Hotel_Management_System_2.Services;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Forms
{
    public partial class AddGuestForm : Form
    {
        private GuestManager _guestManager;

        public AddGuestForm(GuestManager guestManager)
        {
            InitializeComponent();
            _guestManager = guestManager;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var newGuest = new Guest
                {
                    GuestID = int.Parse(txtID.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    CheckInDate = dateCheckIn.Value,
                    CheckOutDate = dateCheckOut.Value,
                    RoomNumber = int.Parse(txtRoom.Text)
                };

                _guestManager.AddGuest(newGuest);

                MessageBox.Show("Guest added successfully!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please check the entered data.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
