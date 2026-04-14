namespace Hotel_Management_System_2.Forms
{
    partial class RoomsForm
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
            dataGridRooms = new DataGridView();
            cmbStatus = new ComboBox();
            btnUpdateStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridRooms).BeginInit();
            SuspendLayout();
            // 
            // dataGridRooms
            // 
            dataGridRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridRooms.Location = new Point(98, 111);
            dataGridRooms.Name = "dataGridRooms";
            dataGridRooms.Size = new Size(544, 311);
            dataGridRooms.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "", "", "Occupied", "", "", "Maintenance" });
            cmbStatus.Location = new Point(418, 73);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 1;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(545, 73);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(97, 23);
            btnUpdateStatus.TabIndex = 2;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbStatus);
            Controls.Add(dataGridRooms);
            Name = "RoomsForm";
            Text = "RoomsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridRooms).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridRooms;
        private ComboBox cmbStatus;
        private Button btnUpdateStatus;
    }
}