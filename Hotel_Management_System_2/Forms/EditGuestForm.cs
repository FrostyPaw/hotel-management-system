using Hotel_Management_System_2.Services;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Forms
{
    public partial class EditGuestForm : Form
    {
        private GuestManager _guestManager;
        private Guest _guest;

        public EditGuestForm(GuestManager guestManager, Guest guest)
        {
            InitializeComponent();
            _guestManager = guestManager;
            _guest = guest;

            // Load guest data into fields
            LoadGuestData();
        }

        private void LoadGuestData()
        {
            txtID.Text = _guest.GuestID.ToString();
            txtFirstName.Text = _guest.FirstName;
            txtLastName.Text = _guest.LastName;
            dateCheckIn.Value = _guest.CheckInDate;
            dateCheckOut.Value = _guest.CheckOutDate;
            txtRoom.Text = _guest.RoomNumber.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateCheckOut.Value.Date < dateCheckIn.Value.Date)
                {
                    MessageBox.Show("Check-out date cannot be earlier than check-in date.");
                    return;
                }

                _guest.FirstName = txtFirstName.Text;
                _guest.LastName = txtLastName.Text;
                _guest.CheckInDate = dateCheckIn.Value;
                _guest.CheckOutDate = dateCheckOut.Value;
                _guest.RoomNumber = int.Parse(txtRoom.Text);

                bool updated = _guestManager.EditGuest(_guest);

                if (updated)
                {
                    MessageBox.Show("Guest updated successfully!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update guest.");
                }
            }
            catch
            {
                MessageBox.Show("Invalid input data.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
