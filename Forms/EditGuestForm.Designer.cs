namespace Hotel_Management_System_2.Forms
{
    partial class EditGuestForm
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
            dateCheckOut = new DateTimePicker();
            dateCheckIn = new DateTimePicker();
            txtRoom = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtID = new TextBox();
            lblRoom = new Label();
            lblCheckOut = new Label();
            lblCheckIn = new Label();
            lblLast = new Label();
            lblFirst = new Label();
            lblID = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(701, 408);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(607, 408);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateCheckOut
            // 
            dateCheckOut.Location = new Point(144, 312);
            dateCheckOut.Name = "dateCheckOut";
            dateCheckOut.Size = new Size(200, 23);
            dateCheckOut.TabIndex = 25;
            // 
            // dateCheckIn
            // 
            dateCheckIn.Location = new Point(144, 237);
            dateCheckIn.Name = "dateCheckIn";
            dateCheckIn.Size = new Size(200, 23);
            dateCheckIn.TabIndex = 24;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(144, 392);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(100, 23);
            txtRoom.TabIndex = 23;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(144, 162);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 22;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(144, 88);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 21;
            // 
            // txtID
            // 
            txtID.Location = new Point(144, 19);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 20;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(24, 392);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(86, 15);
            lblRoom.TabIndex = 19;
            lblRoom.Text = "Room Number";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(24, 312);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(90, 15);
            lblCheckOut.TabIndex = 18;
            lblCheckOut.Text = "Check-out Date";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(24, 245);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(82, 15);
            lblCheckIn.TabIndex = 17;
            lblCheckIn.Text = "Check-in Date";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(24, 170);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(63, 15);
            lblLast.TabIndex = 16;
            lblLast.Text = "Last Name";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(24, 91);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(64, 15);
            lblFirst.TabIndex = 15;
            lblFirst.Text = "First Name";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(24, 19);
            lblID.Name = "lblID";
            lblID.Size = new Size(51, 15);
            lblID.TabIndex = 14;
            lblID.Text = "Guest ID";
            // 
            // EditGuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dateCheckOut);
            Controls.Add(dateCheckIn);
            Controls.Add(txtRoom);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(lblRoom);
            Controls.Add(lblCheckOut);
            Controls.Add(lblCheckIn);
            Controls.Add(lblLast);
            Controls.Add(lblFirst);
            Controls.Add(lblID);
            Name = "EditGuestForm";
            Text = "EditGuestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private DateTimePicker dateCheckOut;
        private DateTimePicker dateCheckIn;
        private TextBox txtRoom;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtID;
        private Label lblRoom;
        private Label lblCheckOut;
        private Label lblCheckIn;
        private Label lblLast;
        private Label lblFirst;
        private Label lblID;
    }
}