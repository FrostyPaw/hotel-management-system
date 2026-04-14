using System;
using System.Windows.Forms;
using Hotel_Management_System_2.Services;
using Hotel_Management_System_2.Forms;

namespace Hotel_Management_System_2
{
    public partial class MainForm : Form
    {
        private GuestManager _guestManager;
        private ReservationManager _reservationManager;

        public MainForm(GuestManager guestManager)
        {
            InitializeComponent();
            _guestManager = guestManager;
            _reservationManager = new ReservationManager();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            var guestsForm = new GuestsForm(_guestManager);
            guestsForm.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            var roomsForm = new RoomsForm();
            roomsForm.ShowDialog();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            var form = new ReservationsForm(_guestManager, _reservationManager);
            form.ShowDialog();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var statsForm = new StatisticsForm(_guestManager, _reservationManager);
            statsForm.ShowDialog();
        }
    }
}
