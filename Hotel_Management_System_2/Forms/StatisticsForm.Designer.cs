namespace Hotel_Management_System_2.Forms
{
    partial class StatisticsForm
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
            lblTotalGuests = new Label();
            lblTotalReservations = new Label();
            lblPaid = new Label();
            lblPending = new Label();
            lblCancelled = new Label();
            SuspendLayout();
            // 
            // lblTotalGuests
            // 
            lblTotalGuests.AutoSize = true;
            lblTotalGuests.Location = new Point(12, 57);
            lblTotalGuests.Name = "lblTotalGuests";
            lblTotalGuests.Size = new Size(83, 15);
            lblTotalGuests.TabIndex = 0;
            lblTotalGuests.Text = "Total Guests: 0";
            // 
            // lblTotalReservations
            // 
            lblTotalReservations.AutoSize = true;
            lblTotalReservations.Location = new Point(12, 109);
            lblTotalReservations.Name = "lblTotalReservations";
            lblTotalReservations.Size = new Size(114, 15);
            lblTotalReservations.TabIndex = 1;
            lblTotalReservations.Text = "Total Reservations: 0";
            // 
            // lblPaid
            // 
            lblPaid.AutoSize = true;
            lblPaid.Location = new Point(12, 153);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(111, 15);
            lblPaid.TabIndex = 2;
            lblPaid.Text = "Paid Reservations: 0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(12, 198);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(132, 15);
            lblPending.TabIndex = 3;
            lblPending.Text = "Pending Reservations: 0";
            // 
            // lblCancelled
            // 
            lblCancelled.AutoSize = true;
            lblCancelled.Location = new Point(12, 246);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Size = new Size(140, 15);
            lblCancelled.TabIndex = 4;
            lblCancelled.Text = "Cancelled Reservations: 0";
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCancelled);
            Controls.Add(lblPending);
            Controls.Add(lblPaid);
            Controls.Add(lblTotalReservations);
            Controls.Add(lblTotalGuests);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalGuests;
        private Label lblTotalReservations;
        private Label lblPaid;
        private Label lblPending;
        private Label lblCancelled;
    }
}