using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Hotel_Management_System_2.Models;

namespace Hotel_Management_System_2.Modules.ReservationCreation
{
    public class ReservationCreationForm : Form
    {
        private readonly ReservationCreationService _service;

        private readonly List<Guest> _guests;
        private readonly List<Room> _rooms;
        private readonly List<Reservation> _reservations;

        private TextBox guestIdInput;
        private TextBox roomIdInput;
        private DateTimePicker checkInPicker;
        private DateTimePicker checkOutPicker;
        private Label resultLabel;

        public ReservationCreationForm(
            List<Guest> guests,
            List<Room> rooms,
            List<Reservation> reservations)
        {
            _service = new ReservationCreationService();
            _guests = guests;
            _rooms = rooms;
            _reservations = reservations;

            InitializeUi();
        }

        private void InitializeUi()
        {
            Text = "Create Reservation";
            Width = 420;
            Height = 360;
            BackColor = ColorTranslator.FromHtml("#F8FAFC");
            Font = new Font("Segoe UI", 10);
            Padding = new Padding(16);

            Label title = new Label
            {
                Text = "Create Reservation",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#0F172A"),
                AutoSize = true,
                Top = 16,
                Left = 16
            };

            Label guestLabel = CreateLabel("Guest ID", 60);
            guestIdInput = CreateTextBox(90);

            Label roomLabel = CreateLabel("Room ID", 120);
            roomIdInput = CreateTextBox(150);

            Label checkInLabel = CreateLabel("Check-in Date", 180);
            checkInPicker = CreateDatePicker(210);

            Label checkOutLabel = CreateLabel("Check-out Date", 240);
            checkOutPicker = CreateDatePicker(270);

            Button validateButton = new Button
            {
                Text = "Validate Reservation",
                Width = 180,
                Height = 36,
                Left = 16,
                Top = 305,
                BackColor = ColorTranslator.FromHtml("#2563EB"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            validateButton.Click += ValidateButton_Click;

            resultLabel = new Label
            {
                Text = "",
                AutoSize = true,
                Left = 210,
                Top = 312,
                ForeColor = ColorTranslator.FromHtml("#0F172A")
            };

            Controls.Add(title);
            Controls.Add(guestLabel);
            Controls.Add(guestIdInput);
            Controls.Add(roomLabel);
            Controls.Add(roomIdInput);
            Controls.Add(checkInLabel);
            Controls.Add(checkInPicker);
            Controls.Add(checkOutLabel);
            Controls.Add(checkOutPicker);
            Controls.Add(validateButton);
            Controls.Add(resultLabel);
        }

        private Label CreateLabel(string text, int top)
        {
            return new Label
            {
                Text = text,
                Left = 16,
                Top = top,
                Width = 160,
                ForeColor = ColorTranslator.FromHtml("#0F172A")
            };
        }

        private TextBox CreateTextBox(int top)
        {
            return new TextBox
            {
                Left = 16,
                Top = top,
                Width = 360
            };
        }

        private DateTimePicker CreateDatePicker(int top)
        {
            return new DateTimePicker
            {
                Left = 16,
                Top = top,
                Width = 360,
                Format = DateTimePickerFormat.Short
            };
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(guestIdInput.Text, out int guestId) ||
                !int.TryParse(roomIdInput.Text, out int roomId))
            {
                ShowResult("Guest ID and Room ID must be valid numbers.", false);
                return;
            }

            ReservationRequest request = new ReservationRequest
            {
                GuestId = guestId,
                RoomId = roomId,
                CheckInDate = checkInPicker.Value.Date,
                CheckOutDate = checkOutPicker.Value.Date
            };

            ReservationResult result = _service.ValidateReservation(
                request,
                _guests,
                _rooms,
                _reservations
            );

            ShowResult(result.Message, result.Success);
        }

        private void ShowResult(string message, bool success)
        {
            resultLabel.Text = message;
            resultLabel.ForeColor = success
                ? ColorTranslator.FromHtml("#16A34A")
                : ColorTranslator.FromHtml("#DC2626");
        }
    }
}
