namespace Hotel_Management_System_2.Forms
{
    partial class GuestsForm
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
            dataGridGuests = new DataGridView();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnSort = new Button();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridGuests).BeginInit();
            SuspendLayout();
            // 
            // dataGridGuests
            // 
            dataGridGuests.AllowUserToAddRows = false;
            dataGridGuests.AllowUserToDeleteRows = false;
            dataGridGuests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridGuests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGuests.Location = new Point(43, 102);
            dataGridGuests.Name = "dataGridGuests";
            dataGridGuests.ReadOnly = true;
            dataGridGuests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridGuests.Size = new Size(716, 292);
            dataGridGuests.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(65, 72);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(401, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(508, 400);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Guest";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(684, 400);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Guest";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(589, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Guest";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(472, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(553, 72);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(118, 23);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort by Last Name";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(677, 72);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 23);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // GuestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnSort);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(dataGridGuests);
            Name = "GuestsForm";
            Text = "GuestsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridGuests;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnSort;
        private Button btnReset;
    }
}