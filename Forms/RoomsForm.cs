using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Forms
{
    public partial class RoomsForm : Form
    {
        private List<Room> _rooms = new List<Room>();

        public RoomsForm()
        {
            InitializeComponent();
            LoadRooms();
        }

        private void LoadRooms()
        {
            _rooms = new List<Room>
            {
                new Room { RoomNumber = 101, Type = RoomType.Single, Status = RoomStatus.Available, PricePerNight = 50 },
                new Room { RoomNumber = 102, Type = RoomType.Double, Status = RoomStatus.Occupied, PricePerNight = 80 },
                new Room { RoomNumber = 103, Type = RoomType.Single, Status = RoomStatus.Maintenance, PricePerNight = 45 },
                new Room { RoomNumber = 201, Type = RoomType.Double, Status = RoomStatus.Available, PricePerNight = 85 },
                new Room { RoomNumber = 202, Type = RoomType.Suite, Status = RoomStatus.Occupied, PricePerNight = 150 }
            };

            dataGridRooms.DataSource = null;
            dataGridRooms.DataSource = _rooms;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a room.");
                return;
            }

            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            var selectedRoom = dataGridRooms.SelectedRows[0].DataBoundItem as Room;

            if (selectedRoom == null)
            {
                MessageBox.Show("Error reading selected room.");
                return;
            }

            selectedRoom.Status = Enum.Parse<RoomStatus>(cmbStatus.SelectedItem.ToString());
            dataGridRooms.Refresh();

            MessageBox.Show("Room status updated!");
        }

    }
}
