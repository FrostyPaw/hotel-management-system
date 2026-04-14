using Hotel_Management_System_2.Models;
using Hotel_Management_System_2.Services;
using System;
using System.Windows.Forms;

namespace Hotel_Management_System_2.Forms
{
    public partial class ReservationsForm : Form
    {
        private GuestManager _guestManager;
        private ReservationManager _reservationManager;

        public ReservationsForm(GuestManager guestManager, ReservationManager reservationManager)
        {
            InitializeComponent();
            _guestManager = guestManager;
            _reservationManager = reservationManager;

            LoadReservationsToGrid();
        }

        private void LoadReservationsToGrid()
        {
            dataGridReservations.DataSource = null;
            dataGridReservations.DataSource = _reservationManager.GetAllReservations();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadReservationsToGrid();
                return;
            }

            dataGridReservations.DataSource = null;
            dataGridReservations.DataSource =
                _reservationManager.SearchReservations(keyword);
        }

        private void dataGridReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddReservationForm(_guestManager, _reservationManager);

            if (addForm.ShowDialog() == DialogResult.OK)
                LoadReservationsToGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.");
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this reservation?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            int reservationId = (int)dataGridReservations
                .SelectedRows[0]
                .Cells["ReservationID"]
                .Value;

            bool deleted = _reservationManager.DeleteReservation(reservationId);

            if (deleted)
            {
                MessageBox.Show("Reservation deleted successfully.");
                LoadReservationsToGrid();
            }
            else
            {
                MessageBox.Show("Failed to delete reservation.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to edit.");
                return;
            }

            var reservation = (Reservation)dataGridReservations.SelectedRows[0].DataBoundItem;

            var editForm = new EditReservationForm(
                _guestManager,
                _reservationManager,
                reservation
            );

            if (editForm.ShowDialog() == DialogResult.OK)
                LoadReservationsToGrid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadReservationsToGrid();
        }
    }
}
