namespace Hotel_Management_System_2.Forms
{
    partial class ReservationsForm
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
            dataGridReservations = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridReservations).BeginInit();
            SuspendLayout();
            // 
            // dataGridReservations
            // 
            dataGridReservations.AllowUserToAddRows = false;
            dataGridReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReservations.Location = new Point(12, 62);
            dataGridReservations.MultiSelect = false;
            dataGridReservations.Name = "dataGridReservations";
            dataGridReservations.ReadOnly = true;
            dataGridReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridReservations.Size = new Size(776, 335);
            dataGridReservations.TabIndex = 0;
            dataGridReservations.CellContentClick += dataGridReservations_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(614, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(632, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(683, 403);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Reservation";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(557, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Reservation";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(446, 403);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Reservation";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(713, 32);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // ReservationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridReservations);
            Name = "ReservationsForm";
            Text = "ReservationsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridReservations;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnReset;
    }
}