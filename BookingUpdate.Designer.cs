namespace AfroMed
{
    partial class BookingUpdate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingUpdate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.DgvBookings = new System.Windows.Forms.DataGridView();
            this.GBoxBookings = new System.Windows.Forms.GroupBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.DtpDateBooked = new System.Windows.Forms.DateTimePicker();
            this.LblDateBooked = new System.Windows.Forms.Label();
            this.TxtCheckOut = new System.Windows.Forms.TextBox();
            this.TxtCheckIN = new System.Windows.Forms.TextBox();
            this.TxtBookingID = new System.Windows.Forms.TextBox();
            this.LblBookingID = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtBill = new System.Windows.Forms.TextBox();
            this.TxtRoom = new System.Windows.Forms.TextBox();
            this.TxtNurseID = new System.Windows.Forms.TextBox();
            this.TxtDoctorID = new System.Windows.Forms.TextBox();
            this.TxtPatientID = new System.Windows.Forms.TextBox();
            this.LblBill = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblRoom = new System.Windows.Forms.Label();
            this.LblNurseID = new System.Windows.Forms.Label();
            this.LblDoctorID = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblCheckOut = new System.Windows.Forms.Label();
            this.LblCheckIN = new System.Windows.Forms.Label();
            this.LblPatientID = new System.Windows.Forms.Label();
            this.BtnGoBack = new System.Windows.Forms.Button();
            this.TxtAvail = new System.Windows.Forms.TextBox();
            this.LblAvailability = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookings)).BeginInit();
            this.GBoxBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.LblID);
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(142, 71);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 29);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(142, 27);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(149, 32);
            this.TxtID.TabIndex = 10;
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.SaddleBrown;
            this.LblID.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.White;
            this.LblID.Location = new System.Drawing.Point(39, 28);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(106, 31);
            this.LblID.TabIndex = 9;
            this.LblID.Text = "ID";
            // 
            // DgvBookings
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBookings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBookings.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBookings.Location = new System.Drawing.Point(363, 40);
            this.DgvBookings.Name = "DgvBookings";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBookings.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DgvBookings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvBookings.Size = new System.Drawing.Size(619, 105);
            this.DgvBookings.TabIndex = 12;
            // 
            // GBoxBookings
            // 
            this.GBoxBookings.BackColor = System.Drawing.Color.SaddleBrown;
            this.GBoxBookings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GBoxBookings.Controls.Add(this.LblAvailability);
            this.GBoxBookings.Controls.Add(this.TxtAvail);
            this.GBoxBookings.Controls.Add(this.TxtDescription);
            this.GBoxBookings.Controls.Add(this.DtpDateBooked);
            this.GBoxBookings.Controls.Add(this.LblDateBooked);
            this.GBoxBookings.Controls.Add(this.TxtCheckOut);
            this.GBoxBookings.Controls.Add(this.TxtCheckIN);
            this.GBoxBookings.Controls.Add(this.TxtBookingID);
            this.GBoxBookings.Controls.Add(this.LblBookingID);
            this.GBoxBookings.Controls.Add(this.BtnReset);
            this.GBoxBookings.Controls.Add(this.BtnUpdate);
            this.GBoxBookings.Controls.Add(this.TxtStatus);
            this.GBoxBookings.Controls.Add(this.TxtBill);
            this.GBoxBookings.Controls.Add(this.TxtRoom);
            this.GBoxBookings.Controls.Add(this.TxtNurseID);
            this.GBoxBookings.Controls.Add(this.TxtDoctorID);
            this.GBoxBookings.Controls.Add(this.TxtPatientID);
            this.GBoxBookings.Controls.Add(this.LblBill);
            this.GBoxBookings.Controls.Add(this.LblStatus);
            this.GBoxBookings.Controls.Add(this.LblRoom);
            this.GBoxBookings.Controls.Add(this.LblNurseID);
            this.GBoxBookings.Controls.Add(this.LblDoctorID);
            this.GBoxBookings.Controls.Add(this.LblDescription);
            this.GBoxBookings.Controls.Add(this.LblCheckOut);
            this.GBoxBookings.Controls.Add(this.LblCheckIN);
            this.GBoxBookings.Controls.Add(this.LblPatientID);
            this.GBoxBookings.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxBookings.ForeColor = System.Drawing.Color.White;
            this.GBoxBookings.Location = new System.Drawing.Point(24, 151);
            this.GBoxBookings.Name = "GBoxBookings";
            this.GBoxBookings.Size = new System.Drawing.Size(958, 312);
            this.GBoxBookings.TabIndex = 13;
            this.GBoxBookings.TabStop = false;
            this.GBoxBookings.Text = "Update";
            this.GBoxBookings.Enter += new System.EventHandler(this.GBoxBookings_Enter);
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(605, 139);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(326, 33);
            this.TxtDescription.TabIndex = 26;
            this.TxtDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // DtpDateBooked
            // 
            this.DtpDateBooked.Location = new System.Drawing.Point(605, 103);
            this.DtpDateBooked.Name = "DtpDateBooked";
            this.DtpDateBooked.Size = new System.Drawing.Size(326, 33);
            this.DtpDateBooked.TabIndex = 25;
            // 
            // LblDateBooked
            // 
            this.LblDateBooked.Location = new System.Drawing.Point(463, 111);
            this.LblDateBooked.Name = "LblDateBooked";
            this.LblDateBooked.Size = new System.Drawing.Size(138, 23);
            this.LblDateBooked.TabIndex = 24;
            this.LblDateBooked.Text = "Date Booked";
            // 
            // TxtCheckOut
            // 
            this.TxtCheckOut.Location = new System.Drawing.Point(605, 66);
            this.TxtCheckOut.Name = "TxtCheckOut";
            this.TxtCheckOut.Size = new System.Drawing.Size(110, 33);
            this.TxtCheckOut.TabIndex = 23;
            this.TxtCheckOut.Text = "HH:MM:SS";
            // 
            // TxtCheckIN
            // 
            this.TxtCheckIN.Location = new System.Drawing.Point(605, 29);
            this.TxtCheckIN.Name = "TxtCheckIN";
            this.TxtCheckIN.Size = new System.Drawing.Size(110, 33);
            this.TxtCheckIN.TabIndex = 22;
            this.TxtCheckIN.Text = "HH:MM:SS";
            // 
            // TxtBookingID
            // 
            this.TxtBookingID.Location = new System.Drawing.Point(186, 30);
            this.TxtBookingID.Name = "TxtBookingID";
            this.TxtBookingID.Size = new System.Drawing.Size(196, 33);
            this.TxtBookingID.TabIndex = 21;
            // 
            // LblBookingID
            // 
            this.LblBookingID.Location = new System.Drawing.Point(39, 33);
            this.LblBookingID.Name = "LblBookingID";
            this.LblBookingID.Size = new System.Drawing.Size(115, 28);
            this.LblBookingID.TabIndex = 20;
            this.LblBookingID.Text = "Booking ID";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Firebrick;
            this.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.BtnReset.FlatAppearance.BorderSize = 2;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(605, 221);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(90, 28);
            this.BtnReset.TabIndex = 19;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.BtnUpdate.FlatAppearance.BorderSize = 2;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(712, 220);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(90, 28);
            this.BtnUpdate.TabIndex = 18;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(187, 258);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(196, 33);
            this.TxtStatus.TabIndex = 15;
            // 
            // TxtBill
            // 
            this.TxtBill.Location = new System.Drawing.Point(187, 220);
            this.TxtBill.Name = "TxtBill";
            this.TxtBill.Size = new System.Drawing.Size(196, 33);
            this.TxtBill.TabIndex = 14;
            // 
            // TxtRoom
            // 
            this.TxtRoom.Location = new System.Drawing.Point(187, 182);
            this.TxtRoom.Name = "TxtRoom";
            this.TxtRoom.Size = new System.Drawing.Size(195, 33);
            this.TxtRoom.TabIndex = 13;
            // 
            // TxtNurseID
            // 
            this.TxtNurseID.Location = new System.Drawing.Point(187, 144);
            this.TxtNurseID.Name = "TxtNurseID";
            this.TxtNurseID.Size = new System.Drawing.Size(195, 33);
            this.TxtNurseID.TabIndex = 12;
            // 
            // TxtDoctorID
            // 
            this.TxtDoctorID.Location = new System.Drawing.Point(186, 106);
            this.TxtDoctorID.Name = "TxtDoctorID";
            this.TxtDoctorID.Size = new System.Drawing.Size(196, 33);
            this.TxtDoctorID.TabIndex = 11;
            // 
            // TxtPatientID
            // 
            this.TxtPatientID.Location = new System.Drawing.Point(186, 68);
            this.TxtPatientID.Name = "TxtPatientID";
            this.TxtPatientID.Size = new System.Drawing.Size(196, 33);
            this.TxtPatientID.TabIndex = 10;
            // 
            // LblBill
            // 
            this.LblBill.Location = new System.Drawing.Point(39, 223);
            this.LblBill.Name = "LblBill";
            this.LblBill.Size = new System.Drawing.Size(76, 23);
            this.LblBill.TabIndex = 8;
            this.LblBill.Text = "Bill";
            // 
            // LblStatus
            // 
            this.LblStatus.Location = new System.Drawing.Point(39, 261);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(81, 23);
            this.LblStatus.TabIndex = 7;
            this.LblStatus.Text = "Status";
            // 
            // LblRoom
            // 
            this.LblRoom.Location = new System.Drawing.Point(39, 185);
            this.LblRoom.Name = "LblRoom";
            this.LblRoom.Size = new System.Drawing.Size(103, 23);
            this.LblRoom.TabIndex = 6;
            this.LblRoom.Text = "Room No";
            // 
            // LblNurseID
            // 
            this.LblNurseID.Location = new System.Drawing.Point(39, 148);
            this.LblNurseID.Name = "LblNurseID";
            this.LblNurseID.Size = new System.Drawing.Size(108, 23);
            this.LblNurseID.TabIndex = 5;
            this.LblNurseID.Text = "Nurse ID";
            // 
            // LblDoctorID
            // 
            this.LblDoctorID.Location = new System.Drawing.Point(39, 109);
            this.LblDoctorID.Name = "LblDoctorID";
            this.LblDoctorID.Size = new System.Drawing.Size(115, 23);
            this.LblDoctorID.TabIndex = 4;
            this.LblDoctorID.Text = "Doctor ID";
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(463, 147);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(120, 23);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description";
            // 
            // LblCheckOut
            // 
            this.LblCheckOut.Location = new System.Drawing.Point(463, 69);
            this.LblCheckOut.Name = "LblCheckOut";
            this.LblCheckOut.Size = new System.Drawing.Size(115, 23);
            this.LblCheckOut.TabIndex = 2;
            this.LblCheckOut.Text = "Check-Out";
            // 
            // LblCheckIN
            // 
            this.LblCheckIN.Location = new System.Drawing.Point(463, 33);
            this.LblCheckIN.Name = "LblCheckIN";
            this.LblCheckIN.Size = new System.Drawing.Size(97, 23);
            this.LblCheckIN.TabIndex = 1;
            this.LblCheckIN.Text = "Check-In";
            this.LblCheckIN.Click += new System.EventHandler(this.LblCheckIN_Click);
            // 
            // LblPatientID
            // 
            this.LblPatientID.Location = new System.Drawing.Point(39, 70);
            this.LblPatientID.Name = "LblPatientID";
            this.LblPatientID.Size = new System.Drawing.Size(120, 28);
            this.LblPatientID.TabIndex = 0;
            this.LblPatientID.Text = "Patient ID";
            this.LblPatientID.Click += new System.EventHandler(this.LblPatientID_Click);
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.DimGray;
            this.BtnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoBack.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoBack.ForeColor = System.Drawing.Color.White;
            this.BtnGoBack.Location = new System.Drawing.Point(-1, -1);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(104, 23);
            this.BtnGoBack.TabIndex = 23;
            this.BtnGoBack.Text = "<< Go Back";
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // TxtAvail
            // 
            this.TxtAvail.Location = new System.Drawing.Point(605, 178);
            this.TxtAvail.Name = "TxtAvail";
            this.TxtAvail.Size = new System.Drawing.Size(326, 33);
            this.TxtAvail.TabIndex = 27;
            // 
            // LblAvailability
            // 
            this.LblAvailability.Location = new System.Drawing.Point(463, 185);
            this.LblAvailability.Name = "LblAvailability";
            this.LblAvailability.Size = new System.Drawing.Size(120, 23);
            this.LblAvailability.TabIndex = 28;
            this.LblAvailability.Text = "Availability";
            // 
            // BookingUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(998, 479);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.GBoxBookings);
            this.Controls.Add(this.DgvBookings);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookingUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingUpdate";
            this.Load += new System.EventHandler(this.BookingUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookings)).EndInit();
            this.GBoxBookings.ResumeLayout(false);
            this.GBoxBookings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.DataGridView DgvBookings;
        private System.Windows.Forms.GroupBox GBoxBookings;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.DateTimePicker DtpDateBooked;
        private System.Windows.Forms.Label LblDateBooked;
        private System.Windows.Forms.TextBox TxtCheckOut;
        private System.Windows.Forms.TextBox TxtCheckIN;
        private System.Windows.Forms.TextBox TxtBookingID;
        private System.Windows.Forms.Label LblBookingID;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox TxtBill;
        private System.Windows.Forms.TextBox TxtRoom;
        private System.Windows.Forms.TextBox TxtNurseID;
        private System.Windows.Forms.TextBox TxtDoctorID;
        private System.Windows.Forms.TextBox TxtPatientID;
        private System.Windows.Forms.Label LblBill;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblRoom;
        private System.Windows.Forms.Label LblNurseID;
        private System.Windows.Forms.Label LblDoctorID;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblCheckOut;
        private System.Windows.Forms.Label LblCheckIN;
        private System.Windows.Forms.Label LblPatientID;
        private System.Windows.Forms.Button BtnGoBack;
        private System.Windows.Forms.Label LblAvailability;
        private System.Windows.Forms.TextBox TxtAvail;
    }
}