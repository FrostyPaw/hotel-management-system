namespace Hotel_Management_System_2.Forms
{
    partial class AddGuestForm
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
            lblID = new Label();
            lblFirst = new Label();
            lblLast = new Label();
            lblCheckIn = new Label();
            lblCheckOut = new Label();
            lblRoom = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtRoom = new TextBox();
            dateCheckIn = new DateTimePicker();
            dateCheckOut = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(36, 26);
            lblID.Name = "lblID";
            lblID.Size = new Size(51, 15);
            lblID.TabIndex = 0;
            lblID.Text = "Guest ID";
            // 
            // lblFirst
            // 
            lblFirst.AutoSize = true;
            lblFirst.Location = new Point(36, 98);
            lblFirst.Name = "lblFirst";
            lblFirst.Size = new Size(64, 15);
            lblFirst.TabIndex = 1;
            lblFirst.Text = "First Name";
            // 
            // lblLast
            // 
            lblLast.AutoSize = true;
            lblLast.Location = new Point(36, 177);
            lblLast.Name = "lblLast";
            lblLast.Size = new Size(63, 15);
            lblLast.TabIndex = 2;
            lblLast.Text = "Last Name";
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Location = new Point(36, 252);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(82, 15);
            lblCheckIn.TabIndex = 3;
            lblCheckIn.Text = "Check-in Date";
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Location = new Point(36, 319);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(90, 15);
            lblCheckOut.TabIndex = 4;
            lblCheckOut.Text = "Check-out Date";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(36, 399);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(86, 15);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Room Number";
            // 
            // txtID
            // 
            txtID.Location = new Point(156, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(156, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(156, 169);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtRoom
            // 
            txtRoom.Location = new Point(156, 399);
            txtRoom.Name = "txtRoom";
            txtRoom.Size = new Size(100, 23);
            txtRoom.TabIndex = 9;
            // 
            // dateCheckIn
            // 
            dateCheckIn.Location = new Point(156, 244);
            dateCheckIn.Name = "dateCheckIn";
            dateCheckIn.Size = new Size(200, 23);
            dateCheckIn.TabIndex = 10;
            // 
            // dateCheckOut
            // 
            dateCheckOut.Location = new Point(156, 319);
            dateCheckOut.Name = "dateCheckOut";
            dateCheckOut.Size = new Size(200, 23);
            dateCheckOut.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(619, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(713, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddGuestForm
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
            Name = "AddGuestForm";
            Text = "AddGuestForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblFirst;
        private Label lblLast;
        private Label lblCheckIn;
        private Label lblCheckOut;
        private Label lblRoom;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtRoom;
        private DateTimePicker dateCheckIn;
        private DateTimePicker dateCheckOut;
        private Button btnSave;
        private Button btnCancel;
    }
}