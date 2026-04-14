using System;
using System.Linq;
using System.Windows.Forms;
using Hotel_Management_System_2.Services;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Forms
{
    public partial class StatisticsForm : Form
    {
        private readonly GuestManager _guestManager;
        private readonly ReservationManager _reservationManager;

        public StatisticsForm(
            GuestManager guestManager,
            ReservationManager reservationManager)
        {
            InitializeComponent();

            _guestManager = guestManager;
            _reservationManager = reservationManager;

            LoadStatistics();
        }

        private void LoadStatistics()
        {
            var guests = _guestManager.GetAllGuests();
            var reservations = _reservationManager.GetAllReservations();

            lblTotalGuests.Text = $"Total Guests: {guests.Count}";
            lblTotalReservations.Text = $"Total Reservations: {reservations.Count}";

            lblPaid.Text =
                $"Paid Reservations: {reservations.Count(r => r.PaymentStatus == PaymentStatus.Paid)}";

            lblPending.Text =
                $"Pending Reservations: {reservations.Count(r => r.PaymentStatus == PaymentStatus.Pending)}";

            lblCancelled.Text =
                $"Cancelled Reservations: {reservations.Count(r => r.PaymentStatus == PaymentStatus.Cancelled)}";
        }
    }
}
