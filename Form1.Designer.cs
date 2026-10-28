namespace UmmaGateManagement
{
    partial class btnclear
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
            label1 = new Label();
            btnstaff = new Button();
            btnstudent = new Button();
            btnvisitor = new Button();
            btnvehicle = new Button();
            lblactivity = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFullName = new TextBox();
            txtIDNumber = new TextBox();
            txtVehicleNumber = new TextBox();
            txtPurpose = new TextBox();
            cmbCategory = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            cmbMovement = new ComboBox();
            btnregister = new Button();
            button1 = new Button();
            dgvRecords = new DataGridView();
            colFullName = new DataGridViewTextBoxColumn();
            colIDNumber = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colVehicleNumber = new DataGridViewTextBoxColumn();
            colMovement = new DataGridViewTextBoxColumn();
            colDateTime = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 100);
            label1.TabIndex = 0;
            label1.Text = "UMMA UNIVERSITY\r\nGATE MANAGEMENT SYSTEM\r\n\r\nSecurity Control Dashboard";
            label1.Click += label1_Click;
            // 
            // btnstaff
            // 
            btnstaff.BackColor = Color.Yellow;
            btnstaff.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstaff.Location = new Point(59, 121);
            btnstaff.Name = "btnstaff";
            btnstaff.Size = new Size(115, 99);
            btnstaff.TabIndex = 1;
            btnstaff.Text = "Staff Management\r\n";
            btnstaff.UseVisualStyleBackColor = false;
            // 
            // btnstudent
            // 
            btnstudent.BackColor = Color.Yellow;
            btnstudent.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnstudent.Location = new Point(210, 121);
            btnstudent.Name = "btnstudent";
            btnstudent.Size = new Size(115, 99);
            btnstudent.TabIndex = 2;
            btnstudent.Text = "Student Management\r\n";
            btnstudent.UseVisualStyleBackColor = false;
            // 
            // btnvisitor
            // 
            btnvisitor.BackColor = Color.Yellow;
            btnvisitor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvisitor.Location = new Point(367, 121);
            btnvisitor.Name = "btnvisitor";
            btnvisitor.Size = new Size(115, 99);
            btnvisitor.TabIndex = 3;
            btnvisitor.Text = "Visitors Management\r\n";
            btnvisitor.UseVisualStyleBackColor = false;
            // 
            // btnvehicle
            // 
            btnvehicle.BackColor = Color.Yellow;
            btnvehicle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvehicle.Location = new Point(505, 121);
            btnvehicle.Name = "btnvehicle";
            btnvehicle.Size = new Size(115, 99);
            btnvehicle.TabIndex = 4;
            btnvehicle.Text = "Vehicle Management\r\n";
            btnvehicle.UseVisualStyleBackColor = false;
            // 
            // lblactivity
            // 
            lblactivity.AutoSize = true;
            lblactivity.BackColor = Color.Olive;
            lblactivity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblactivity.ForeColor = SystemColors.ControlText;
            lblactivity.Location = new Point(180, 232);
            lblactivity.Name = "lblactivity";
            lblactivity.Size = new Size(287, 25);
            lblactivity.TabIndex = 5;
            lblactivity.Text = "GATE ACTIVITY REGISTRATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cyan;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 283);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 6;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 312);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 7;
            label3.Text = "ID Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Cyan;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 341);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 8;
            label4.Text = "Vehicle Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Cyan;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 370);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 9;
            label5.Text = "Purpose of Visit:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(152, 275);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(183, 23);
            txtFullName.TabIndex = 10;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(152, 304);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(183, 23);
            txtIDNumber.TabIndex = 11;
            // 
            // txtVehicleNumber
            // 
            txtVehicleNumber.Location = new Point(152, 333);
            txtVehicleNumber.Name = "txtVehicleNumber";
            txtVehicleNumber.Size = new Size(183, 23);
            txtVehicleNumber.TabIndex = 12;
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(152, 362);
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(183, 23);
            txtPurpose.TabIndex = 13;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Staff", "Student", "Visitor", "Vehicle" });
            cmbCategory.Location = new Point(554, 283);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(165, 23);
            cmbCategory.TabIndex = 14;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Cyan;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 401);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 15;
            label6.Text = "Category";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 16;
            // 
            // cmbMovement
            // 
            cmbMovement.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovement.FormattingEnabled = true;
            cmbMovement.Location = new Point(378, 283);
            cmbMovement.Name = "cmbMovement";
            cmbMovement.Size = new Size(139, 23);
            cmbMovement.TabIndex = 17;
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.Red;
            btnregister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregister.Location = new Point(39, 448);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(102, 65);
            btnregister.TabIndex = 18;
            btnregister.Text = "REGISTER ENTRY";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(210, 448);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(102, 65);
            button1.TabIndex = 19;
            button1.Text = "CLEAR FIELDS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Columns.AddRange(new DataGridViewColumn[] { colFullName, colIDNumber, colCategory, colVehicleNumber, colMovement, colDateTime });
            dgvRecords.Location = new Point(378, 333);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(430, 180);
            dgvRecords.TabIndex = 20;
            // 
            // colFullName
            // 
            colFullName.HeaderText = "Full Name";
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colIDNumber
            // 
            colIDNumber.HeaderText = "ID Number";
            colIDNumber.Name = "colIDNumber";
            colIDNumber.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colVehicleNumber
            // 
            colVehicleNumber.HeaderText = "Vehicle Number";
            colVehicleNumber.Name = "colVehicleNumber";
            colVehicleNumber.ReadOnly = true;
            // 
            // colMovement
            // 
            colMovement.HeaderText = "Movement";
            colMovement.Name = "colMovement";
            colMovement.ReadOnly = true;
            // 
            // colDateTime
            // 
            colDateTime.HeaderText = "Date & Time";
            colDateTime.Name = "colDateTime";
            colDateTime.ReadOnly = true;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 64, 0);
            btnSearch.Font = new Font("Times New Roman", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(630, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(178, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "SEARCH RECORD";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(630, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(178, 23);
            txtSearch.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(0, 192, 0);
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(131, 549);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 71);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "DELETE RECORD";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnclear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(885, 632);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvRecords);
            Controls.Add(button1);
            Controls.Add(btnregister);
            Controls.Add(cmbMovement);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(cmbCategory);
            Controls.Add(txtPurpose);
            Controls.Add(txtVehicleNumber);
            Controls.Add(txtIDNumber);
            Controls.Add(txtFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblactivity);
            Controls.Add(btnvehicle);
            Controls.Add(btnvisitor);
            Controls.Add(btnstudent);
            Controls.Add(btnstaff);
            Controls.Add(label1);
            Name = "btnclear";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UMMA Gate Management System";
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnstaff;
        private Button btnstudent;
        private Button btnvisitor;
        private Button btnvehicle;
        private Label lblactivity;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFullName;
        private TextBox txtIDNumber;
        private TextBox txtVehicleNumber;
        private TextBox txtPurpose;
        private ComboBox cmbCategory;
        private Label label6;
        private TextBox textBox1;
        private ComboBox cmbMovement;
        private Button btnregister;
        private Button button1;
        private DataGridView dgvRecords;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colIDNumber;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colVehicleNumber;
        private DataGridViewTextBoxColumn colMovement;
        private DataGridViewTextBoxColumn colDateTime;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnDelete;
    }
}
