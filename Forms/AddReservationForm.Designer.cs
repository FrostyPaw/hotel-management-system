namespace Hotel_Management_System_2.Forms
{
    partial class AddReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblReservationID = new Label();
            lblGuest = new Label();
            lblRoom = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            lblPayment = new Label();
            txtReservationId = new TextBox();
            cmbGuest = new ComboBox();
            cmbRoom = new ComboBox();
            dateCheckIn = new DateTimePicker();
            dateCheckOut = new DateTimePicker();
            cmbPaymentStatus = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblReservationID
            // 
            lblReservationID.AutoSize = true;
            lblReservationID.Location = new Point(16, 27);
            lblReservationID.Name = "lblReservationID";
            lblReservationID.Size = new Size(82, 15);
            lblReservationID.TabIndex = 13;
            lblReservationID.Text = "Reservation ID";
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Location = new Point(16, 87);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(37, 15);
            lblGuest.TabIndex = 11;
            lblGuest.Text = "Guest";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(16, 155);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(86, 15);
            lblRoom.TabIndex = 9;
            lblRoom.Text = "Room Number";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(12, 227);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(82, 15);
            lblCheckIn.TabIndex = 7;
            lblCheckIn.Text = "Check-in Date";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(16, 298);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(90, 15);
            lblCheckOut.TabIndex = 5;
            lblCheckOut.Text = "Check-out Date";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(16, 365);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(89, 15);
            lblPayment.TabIndex = 3;
            lblPayment.Text = "Payment Status";
            // 
            // txtReservationId
            // 
            txtReservationId.Location = new Point(153, 27);
            txtReservationId.Name = "txtReservationId";
            txtReservationId.Size = new Size(150, 23);
            txtReservationId.TabIndex = 12;
            // 
            // cmbGuest
            // 
            cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuest.Location = new Point(153, 79);
            cmbGuest.Name = "cmbGuest";
            cmbGuest.Size = new Size(200, 23);
            cmbGuest.TabIndex = 10;
            // 
            // cmbRoom
            // 
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.Location = new Point(153, 147);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(200, 23);
            cmbRoom.TabIndex = 8;
            // 
            // dateCheckIn
            // 
            dateCheckIn.Location = new Point(153, 219);
            dateCheckIn.Name = "dateCheckIn";
            dateCheckIn.Size = new Size(200, 23);
            dateCheckIn.TabIndex = 6;
            // 
            // dateCheckOut
            // 
            dateCheckOut.Location = new Point(153, 292);
            dateCheckOut.Name = "dateCheckOut";
            dateCheckOut.Size = new Size(200, 23);
            dateCheckOut.TabIndex = 4;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.Location = new Point(153, 357);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(200, 23);
            cmbPaymentStatus.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(524, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(605, 400);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // AddReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 435);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(lblPayment);
            Controls.Add(dateCheckOut);
            Controls.Add(lblCheckOut);
            Controls.Add(dateCheckIn);
            Controls.Add(lblCheckIn);
            Controls.Add(cmbRoom);
            Controls.Add(lblRoom);
            Controls.Add(cmbGuest);
            Controls.Add(lblGuest);
            Controls.Add(txtReservationId);
            Controls.Add(lblReservationID);
            Name = "AddReservationForm";
            Text = "Add Reservation";
            Load += AddReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReservationID;
        private Label lblGuest;
        private Label lblRoom;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Label lblPayment;
        private TextBox txtReservationId;
        private ComboBox cmbGuest;
        private ComboBox cmbRoom;
        private DateTimePicker dateCheckIn;
        private DateTimePicker dateCheckOut;
        private ComboBox cmbPaymentStatus;
        private Button btnSave;
        private Button btnCancel;
    }
}
