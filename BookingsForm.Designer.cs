namespace AfroMed
{
    partial class BookingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingsForm));
            this.GBoxBookings = new System.Windows.Forms.GroupBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.DtpDateBooked = new System.Windows.Forms.DateTimePicker();
            this.LblDateBooked = new System.Windows.Forms.Label();
            this.TxtCheckOut = new System.Windows.Forms.TextBox();
            this.TxtCheckIN = new System.Windows.Forms.TextBox();
            this.TxtBookingID = new System.Windows.Forms.TextBox();
            this.LblBookingID = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
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
            this.GBoxBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBoxBookings
            // 
            this.GBoxBookings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GBoxBookings.BackgroundImage")));
            this.GBoxBookings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GBoxBookings.Controls.Add(this.TxtDescription);
            this.GBoxBookings.Controls.Add(this.DtpDateBooked);
            this.GBoxBookings.Controls.Add(this.LblDateBooked);
            this.GBoxBookings.Controls.Add(this.TxtCheckOut);
            this.GBoxBookings.Controls.Add(this.TxtCheckIN);
            this.GBoxBookings.Controls.Add(this.TxtBookingID);
            this.GBoxBookings.Controls.Add(this.LblBookingID);
            this.GBoxBookings.Controls.Add(this.BtnReset);
            this.GBoxBookings.Controls.Add(this.BtnSubmit);
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
            this.GBoxBookings.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxBookings.Location = new System.Drawing.Point(37, 29);
            this.GBoxBookings.Name = "GBoxBookings";
            this.GBoxBookings.Size = new System.Drawing.Size(569, 563);
            this.GBoxBookings.TabIndex = 0;
            this.GBoxBookings.TabStop = false;
            this.GBoxBookings.Text = "Bookings";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(209, 239);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(332, 30);
            this.TxtDescription.TabIndex = 26;
            // 
            // DtpDateBooked
            // 
            this.DtpDateBooked.Location = new System.Drawing.Point(209, 109);
            this.DtpDateBooked.Name = "DtpDateBooked";
            this.DtpDateBooked.Size = new System.Drawing.Size(332, 30);
            this.DtpDateBooked.TabIndex = 25;
            // 
            // LblDateBooked
            // 
            this.LblDateBooked.Location = new System.Drawing.Point(42, 114);
            this.LblDateBooked.Name = "LblDateBooked";
            this.LblDateBooked.Size = new System.Drawing.Size(171, 23);
            this.LblDateBooked.TabIndex = 24;
            this.LblDateBooked.Text = "Date Booked";
            // 
            // TxtCheckOut
            // 
            this.TxtCheckOut.Location = new System.Drawing.Point(209, 193);
            this.TxtCheckOut.Name = "TxtCheckOut";
            this.TxtCheckOut.Size = new System.Drawing.Size(118, 30);
            this.TxtCheckOut.TabIndex = 23;
            this.TxtCheckOut.Text = "HH:MM:SS";
            // 
            // TxtCheckIN
            // 
            this.TxtCheckIN.Location = new System.Drawing.Point(209, 152);
            this.TxtCheckIN.Name = "TxtCheckIN";
            this.TxtCheckIN.Size = new System.Drawing.Size(118, 30);
            this.TxtCheckIN.TabIndex = 22;
            this.TxtCheckIN.Text = "HH:MM:SS";
            // 
            // TxtBookingID
            // 
            this.TxtBookingID.Location = new System.Drawing.Point(209, 28);
            this.TxtBookingID.Name = "TxtBookingID";
            this.TxtBookingID.Size = new System.Drawing.Size(332, 30);
            this.TxtBookingID.TabIndex = 21;
            // 
            // LblBookingID
            // 
            this.LblBookingID.Location = new System.Drawing.Point(42, 30);
            this.LblBookingID.Name = "LblBookingID";
            this.LblBookingID.Size = new System.Drawing.Size(171, 28);
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
            this.BtnReset.Location = new System.Drawing.Point(323, 511);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(90, 28);
            this.BtnReset.TabIndex = 19;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.BtnSubmit.FlatAppearance.BorderSize = 2;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.White;
            this.BtnSubmit.Location = new System.Drawing.Point(215, 512);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(90, 28);
            this.BtnSubmit.TabIndex = 18;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(209, 467);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(332, 30);
            this.TxtStatus.TabIndex = 15;
            // 
            // TxtBill
            // 
            this.TxtBill.Location = new System.Drawing.Point(209, 424);
            this.TxtBill.Name = "TxtBill";
            this.TxtBill.Size = new System.Drawing.Size(332, 30);
            this.TxtBill.TabIndex = 14;
            // 
            // TxtRoom
            // 
            this.TxtRoom.Location = new System.Drawing.Point(209, 380);
            this.TxtRoom.Name = "TxtRoom";
            this.TxtRoom.Size = new System.Drawing.Size(332, 30);
            this.TxtRoom.TabIndex = 13;
            // 
            // TxtNurseID
            // 
            this.TxtNurseID.Location = new System.Drawing.Point(209, 337);
            this.TxtNurseID.Name = "TxtNurseID";
            this.TxtNurseID.Size = new System.Drawing.Size(332, 30);
            this.TxtNurseID.TabIndex = 12;
            // 
            // TxtDoctorID
            // 
            this.TxtDoctorID.Location = new System.Drawing.Point(209, 292);
            this.TxtDoctorID.Name = "TxtDoctorID";
            this.TxtDoctorID.Size = new System.Drawing.Size(332, 30);
            this.TxtDoctorID.TabIndex = 11;
            // 
            // TxtPatientID
            // 
            this.TxtPatientID.Location = new System.Drawing.Point(209, 67);
            this.TxtPatientID.Name = "TxtPatientID";
            this.TxtPatientID.Size = new System.Drawing.Size(332, 30);
            this.TxtPatientID.TabIndex = 10;
            // 
            // LblBill
            // 
            this.LblBill.Location = new System.Drawing.Point(42, 429);
            this.LblBill.Name = "LblBill";
            this.LblBill.Size = new System.Drawing.Size(171, 23);
            this.LblBill.TabIndex = 8;
            this.LblBill.Text = "Bill";
            // 
            // LblStatus
            // 
            this.LblStatus.Location = new System.Drawing.Point(42, 471);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(171, 23);
            this.LblStatus.TabIndex = 7;
            this.LblStatus.Text = "Status";
            // 
            // LblRoom
            // 
            this.LblRoom.Location = new System.Drawing.Point(42, 385);
            this.LblRoom.Name = "LblRoom";
            this.LblRoom.Size = new System.Drawing.Size(171, 23);
            this.LblRoom.TabIndex = 6;
            this.LblRoom.Text = "Room No";
            // 
            // LblNurseID
            // 
            this.LblNurseID.Location = new System.Drawing.Point(42, 341);
            this.LblNurseID.Name = "LblNurseID";
            this.LblNurseID.Size = new System.Drawing.Size(171, 23);
            this.LblNurseID.TabIndex = 5;
            this.LblNurseID.Text = "Nurse Assigned";
            // 
            // LblDoctorID
            // 
            this.LblDoctorID.Location = new System.Drawing.Point(42, 296);
            this.LblDoctorID.Name = "LblDoctorID";
            this.LblDoctorID.Size = new System.Drawing.Size(171, 23);
            this.LblDoctorID.TabIndex = 4;
            this.LblDoctorID.Text = "Doctor Assigned";
            this.LblDoctorID.Click += new System.EventHandler(this.LblDoctorID_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(42, 242);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(171, 23);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description";
            // 
            // LblCheckOut
            // 
            this.LblCheckOut.Location = new System.Drawing.Point(42, 197);
            this.LblCheckOut.Name = "LblCheckOut";
            this.LblCheckOut.Size = new System.Drawing.Size(171, 23);
            this.LblCheckOut.TabIndex = 2;
            this.LblCheckOut.Text = "Check-Out";
            // 
            // LblCheckIN
            // 
            this.LblCheckIN.Location = new System.Drawing.Point(42, 155);
            this.LblCheckIN.Name = "LblCheckIN";
            this.LblCheckIN.Size = new System.Drawing.Size(171, 23);
            this.LblCheckIN.TabIndex = 1;
            this.LblCheckIN.Text = "Check-In";
            // 
            // LblPatientID
            // 
            this.LblPatientID.Location = new System.Drawing.Point(42, 69);
            this.LblPatientID.Name = "LblPatientID";
            this.LblPatientID.Size = new System.Drawing.Size(171, 28);
            this.LblPatientID.TabIndex = 0;
            this.LblPatientID.Text = "Patient ID";
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.DimGray;
            this.BtnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoBack.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoBack.ForeColor = System.Drawing.Color.White;
            this.BtnGoBack.Location = new System.Drawing.Point(1, 0);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(104, 23);
            this.BtnGoBack.TabIndex = 20;
            this.BtnGoBack.Text = "<< Go Back";
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // BookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 629);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.GBoxBookings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookings Form";
            this.Load += new System.EventHandler(this.BookingsForm_Load);
            this.GBoxBookings.ResumeLayout(false);
            this.GBoxBookings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxBookings;
        private System.Windows.Forms.Label LblBill;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblRoom;
        private System.Windows.Forms.Label LblNurseID;
        private System.Windows.Forms.Label LblDoctorID;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblCheckOut;
        private System.Windows.Forms.Label LblCheckIN;
        private System.Windows.Forms.Label LblPatientID;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox TxtBill;
        private System.Windows.Forms.TextBox TxtRoom;
        private System.Windows.Forms.TextBox TxtNurseID;
        private System.Windows.Forms.TextBox TxtDoctorID;
        private System.Windows.Forms.TextBox TxtPatientID;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnGoBack;
        private System.Windows.Forms.TextBox TxtBookingID;
        private System.Windows.Forms.Label LblBookingID;
        private System.Windows.Forms.TextBox TxtCheckOut;
        private System.Windows.Forms.TextBox TxtCheckIN;
        private System.Windows.Forms.DateTimePicker DtpDateBooked;
        private System.Windows.Forms.Label LblDateBooked;
        private System.Windows.Forms.TextBox TxtDescription;
    }
}