using System;
using System.Windows.Forms;
using Hotel_Management_System_2.Models;
using Hotel_Management_System_2.Services;

namespace Hotel_Management_System_2.Forms
{
    public partial class EditReservationForm : Form
    {
        private readonly GuestManager _guestManager;
        private readonly ReservationManager _reservationManager;
        private readonly Reservation _reservation;

        public EditReservationForm(
            GuestManager guestManager,
            ReservationManager reservationManager,
            Reservation reservation)
        {
            InitializeComponent();

            _guestManager = guestManager;
            _reservationManager = reservationManager;
            _reservation = reservation;

            LoadGuests();
            LoadRooms();
            LoadPaymentStatuses();
            LoadReservationData();
        }

        private void LoadGuests()
        {
            var guests = _guestManager.GetAllGuests();
            cmbGuest.DataSource = guests;
            cmbGuest.DisplayMember = "LastName";
        }

        private void LoadRooms()
        {
            cmbRoom.Items.Clear();
            cmbRoom.Items.AddRange(new object[] { 101, 102, 103, 201, 202 });
        }

        private void LoadPaymentStatuses()
        {
            cmbPaymentStatus.DataSource = Enum.GetValues(typeof(PaymentStatus));
        }

        private void LoadReservationData()
        {
            txtReservationId.Text = _reservation.ReservationID.ToString();
            txtReservationId.ReadOnly = true;

            dateCheckIn.Value = _reservation.CheckInDate;
            dateCheckOut.Value = _reservation.CheckOutDate;

            cmbRoom.SelectedItem = _reservation.RoomNumber;
            cmbPaymentStatus.SelectedItem = _reservation.PaymentStatus;

            // guest selection by ID
            foreach (Guest g in cmbGuest.Items)
            {
                if (g.GuestID == _reservation.GuestID)
                {
                    cmbGuest.SelectedItem = g;
                    break;
                }
            }
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

                var guest = (Guest)cmbGuest.SelectedItem;

                _reservation.GuestID = guest.GuestID;
                _reservation.RoomNumber = Convert.ToInt32(cmbRoom.SelectedItem);
                _reservation.CheckInDate = dateCheckIn.Value;
                _reservation.CheckOutDate = dateCheckOut.Value;
                _reservation.PaymentStatus = (PaymentStatus)cmbPaymentStatus.SelectedItem;

                bool updated = _reservationManager.EditReservation(_reservation);

                if (updated)
                {
                    MessageBox.Show("Reservation updated successfully!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to update reservation.");
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

        private void EditReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
