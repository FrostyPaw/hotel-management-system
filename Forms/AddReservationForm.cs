using System;
using System.Windows.Forms;
using Hotel_Management_System_2.Models;
using Hotel_Management_System_2.Services;

namespace Hotel_Management_System_2.Forms
{
    public partial class AddReservationForm : Form
    {
        private readonly GuestManager _guestManager;
        private readonly ReservationManager _reservationManager;

        public AddReservationForm(GuestManager guestManager, ReservationManager reservationManager)
        {
            InitializeComponent();
            _guestManager = guestManager;
            _reservationManager = reservationManager;

            LoadGuests();
            LoadRooms();
            LoadPaymentStatuses();
        }

        private void LoadGuests()
        {
            var guests = _guestManager.GetAllGuests();
            cmbGuest.DataSource = guests;
            cmbGuest.DisplayMember = "LastName";

            if (guests.Count > 0)
                cmbGuest.SelectedIndex = 0;
        }

        private void LoadRooms()
        {
            cmbRoom.Items.Clear();
            cmbRoom.Items.Add(101);
            cmbRoom.Items.Add(102);
            cmbRoom.Items.Add(103);
            cmbRoom.Items.Add(201);
            cmbRoom.Items.Add(202);

            if (cmbRoom.Items.Count > 0)
                cmbRoom.SelectedIndex = 0;
        }

        private void LoadPaymentStatuses()
        {
            cmbPaymentStatus.DataSource = Enum.GetValues(typeof(PaymentStatus));
        }


        private void AddReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbGuest.SelectedItem == null || cmbRoom.SelectedItem == null)
                {
                    MessageBox.Show("Please select guest and room.");
                    return;
                }

                if (dateCheckOut.Value.Date < dateCheckIn.Value.Date)
                {
                    MessageBox.Show("Check-out date cannot be earlier than check-in date.");
                    return;
                }

                int reservationId = int.Parse(txtReservationId.Text);
                var guest = (Guest)cmbGuest.SelectedItem;
                int roomNumber = Convert.ToInt32(cmbRoom.SelectedItem);

                var reservation = new Reservation
                {
                    ReservationID = reservationId,
                    GuestID = guest.GuestID,
                    RoomNumber = roomNumber,
                    CheckInDate = dateCheckIn.Value,
                    CheckOutDate = dateCheckOut.Value,
                    PaymentStatus = (PaymentStatus)cmbPaymentStatus.SelectedItem
                };

                _reservationManager.AddReservation(reservation);

                MessageBox.Show("Reservation added successfully!");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Invalid input data.");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
