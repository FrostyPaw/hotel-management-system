using System;
using System.Windows.Forms;
using Hotel_Management_System_2.Services;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Forms
{
    public partial class GuestsForm : Form
    {
        private GuestManager _guestManager;

        public GuestsForm(GuestManager guestManager)
        {
            InitializeComponent();
            _guestManager = guestManager;

            // Loading data into a table when opening a form
            LoadGuestsToGrid();
        }


        // Loading guests into the table

        private void LoadGuestsToGrid()
        {
            var guests = _guestManager.GetAllGuests();
            dataGridGuests.DataSource = null;   // clear the table before updating
            dataGridGuests.DataSource = guests; // loading guest list
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddGuestForm(_guestManager);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadGuestsToGrid(); // updating the table
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridGuests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest to delete.");
                return;
            }

            // Get the selected string
            var selectedRow = dataGridGuests.SelectedRows[0];

            // Guest object bound to a string
            var guest = selectedRow.DataBoundItem as Guest;

            if (guest == null)
            {
                MessageBox.Show("Unable to determine selected guest.");
                return;
            }

            // Confirmation of deletion
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete guest {guest.FirstName} {guest.LastName} (ID: {guest.GuestID})?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                bool deleted = _guestManager.DeleteGuest(guest.GuestID);

                if (deleted)
                {
                    MessageBox.Show("Guest deleted successfully.");
                    LoadGuestsToGrid(); // updating the table
                }
                else
                {
                    MessageBox.Show("Error: guest was not found.");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // If the field is empty, reload the entire list.
                LoadGuestsToGrid();
                return;
            }

            var results = _guestManager.SearchGuests(keyword);

            dataGridGuests.DataSource = null;
            dataGridGuests.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("No guests found.");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var sortedGuests = _guestManager.SortByLastName();

            dataGridGuests.DataSource = null;
            dataGridGuests.DataSource = sortedGuests;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";      // clear the search field
            LoadGuestsToGrid();       // reload the full list
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridGuests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest to edit.");
                return;
            }

            var selectedRow = dataGridGuests.SelectedRows[0];
            var guest = selectedRow.DataBoundItem as Guest;

            if (guest == null)
            {
                MessageBox.Show("Unable to determine selected guest.");
                return;
            }

            var editForm = new EditGuestForm(_guestManager, guest);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadGuestsToGrid();
            }
        }
    }
}
