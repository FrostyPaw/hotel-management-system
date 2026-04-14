namespace Hotel_Management_System_2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuests = new Button();
            btnRooms = new Button();
            btnReservations = new Button();
            btnStats = new Button();
            SuspendLayout();
            // 
            // btnGuests
            // 
            btnGuests.Location = new Point(243, 153);
            btnGuests.Name = "btnGuests";
            btnGuests.Size = new Size(129, 23);
            btnGuests.TabIndex = 0;
            btnGuests.Text = "Manage Guests";
            btnGuests.UseVisualStyleBackColor = true;
            btnGuests.Click += btnGuests_Click;
            // 
            // btnRooms
            // 
            btnRooms.Location = new Point(409, 153);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(129, 23);
            btnRooms.TabIndex = 1;
            btnRooms.Text = "Manage Rooms";
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnReservations
            // 
            btnReservations.Location = new Point(243, 212);
            btnReservations.Name = "btnReservations";
            btnReservations.Size = new Size(129, 23);
            btnReservations.TabIndex = 2;
            btnReservations.Text = "Manage Reservations";
            btnReservations.UseVisualStyleBackColor = true;
            btnReservations.Click += btnReservations_Click;
            // 
            // btnStats
            // 
            btnStats.Location = new Point(409, 212);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(129, 23);
            btnStats.TabIndex = 3;
            btnStats.Text = "Statistics";
            btnStats.UseVisualStyleBackColor = true;
            btnStats.Click += btnStats_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStats);
            Controls.Add(btnReservations);
            Controls.Add(btnRooms);
            Controls.Add(btnGuests);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuests;
        private Button btnRooms;
        private Button btnReservations;
        private Button btnStats;
    }
}
