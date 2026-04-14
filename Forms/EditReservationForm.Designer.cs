namespace Hotel_Management_System_2.Forms
{
    partial class EditReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSave = new Button();
            cmbPaymentStatus = new ComboBox();
            lblPayment = new Label();
            dateCheckOut = new DateTimePicker();
            lblCheckOut = new Label();
            dateCheckIn = new DateTimePicker();
            lblCheckIn = new Label();
            cmbRoom = new ComboBox();
            lblRoom = new Label();
            cmbGuest = new ComboBox();
            lblGuest = new Label();
            txtReservationId = new TextBox();
            lblReservationID = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(713, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(632, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatus.Location = new Point(154, 351);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(200, 23);
            cmbPaymentStatus.TabIndex = 16;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(17, 359);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(89, 15);
            lblPayment.TabIndex = 17;
            lblPayment.Text = "Payment Status";
            // 
            // dateCheckOut
            // 
            dateCheckOut.Location = new Point(154, 286);
            dateCheckOut.Name = "dateCheckOut";
            dateCheckOut.Size = new Size(200, 23);
            dateCheckOut.TabIndex = 18;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(17, 292);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(90, 15);
            lblCheckOut.TabIndex = 19;
            lblCheckOut.Text = "Check-out Date";
            // 
            // dateCheckIn
            // 
            dateCheckIn.Location = new Point(154, 213);
            dateCheckIn.Name = "dateCheckIn";
            dateCheckIn.Size = new Size(200, 23);
            dateCheckIn.TabIndex = 20;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(13, 221);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(82, 15);
            lblCheckIn.TabIndex = 21;
            lblCheckIn.Text = "Check-in Date";
            // 
            // cmbRoom
            // 
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.Location = new Point(154, 141);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(200, 23);
            cmbRoom.TabIndex = 22;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(17, 149);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(86, 15);
            lblRoom.TabIndex = 23;
            lblRoom.Text = "Room Number";
            // 
            // cmbGuest
            // 
            cmbGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuest.Location = new Point(154, 73);
            cmbGuest.Name = "cmbGuest";
            cmbGuest.Size = new Size(200, 23);
            cmbGuest.TabIndex = 24;
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Location = new Point(17, 81);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(37, 15);
            lblGuest.TabIndex = 25;
            lblGuest.Text = "Guest";
            // 
            // txtReservationId
            // 
            txtReservationId.Location = new Point(154, 21);
            txtReservationId.Name = "txtReservationId";
            txtReservationId.ReadOnly = true;
            txtReservationId.Size = new Size(150, 23);
            txtReservationId.TabIndex = 26;
            // 
            // lblReservationID
            // 
            lblReservationID.AutoSize = true;
            lblReservationID.Location = new Point(17, 21);
            lblReservationID.Name = "lblReservationID";
            lblReservationID.Size = new Size(82, 15);
            lblReservationID.TabIndex = 27;
            lblReservationID.Text = "Reservation ID";
            // 
            // EditReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "EditReservationForm";
            Text = "EditReservationForm";
            Load += EditReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private ComboBox cmbPaymentStatus;
        private Label lblPayment;
        private DateTimePicker dateCheckOut;
        private Label lblCheckOut;
        private DateTimePicker dateCheckIn;
        private Label lblCheckIn;
        private ComboBox cmbRoom;
        private Label lblRoom;
        private ComboBox cmbGuest;
        private Label lblGuest;
        private TextBox txtReservationId;
        private Label lblReservationID;
    }
}