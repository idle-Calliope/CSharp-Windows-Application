namespace AfroMed
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookAppointmentForPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostRecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.earliestEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBookingRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllNursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblPatients = new System.Windows.Forms.Label();
            this.DgvPatients = new System.Windows.Forms.DataGridView();
            this.LblBookings = new System.Windows.Forms.Label();
            this.DgvBookings = new System.Windows.Forms.DataGridView();
            this.LblDoctors = new System.Windows.Forms.Label();
            this.DgvDoctors = new System.Windows.Forms.DataGridView();
            this.DgvNurses = new System.Windows.Forms.DataGridView();
            this.LblNurses = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNurses)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.doctorsToolStripMenuItem,
            this.nursesToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerPatientsToolStripMenuItem,
            this.viewPatientsToolStripMenuItem});
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.patientsToolStripMenuItem.Text = "Patients";
            // 
            // registerPatientsToolStripMenuItem
            // 
            this.registerPatientsToolStripMenuItem.Name = "registerPatientsToolStripMenuItem";
            this.registerPatientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registerPatientsToolStripMenuItem.Text = "Register Patient";
            this.registerPatientsToolStripMenuItem.Click += new System.EventHandler(this.registerPatientsToolStripMenuItem_Click);
            // 
            // viewPatientsToolStripMenuItem
            // 
            this.viewPatientsToolStripMenuItem.Name = "viewPatientsToolStripMenuItem";
            this.viewPatientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewPatientsToolStripMenuItem.Text = "View All Patients";
            this.viewPatientsToolStripMenuItem.Click += new System.EventHandler(this.viewPatientsToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookAppointmentForPatientToolStripMenuItem,
            this.viewAllBookingsToolStripMenuItem,
            this.updateBookingRecordToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            this.bookingsToolStripMenuItem.Click += new System.EventHandler(this.bookingsToolStripMenuItem_Click);
            // 
            // bookAppointmentForPatientToolStripMenuItem
            // 
            this.bookAppointmentForPatientToolStripMenuItem.Name = "bookAppointmentForPatientToolStripMenuItem";
            this.bookAppointmentForPatientToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.bookAppointmentForPatientToolStripMenuItem.Text = "Book Appointment For Patient";
            this.bookAppointmentForPatientToolStripMenuItem.Click += new System.EventHandler(this.bookAppointmentForPatientToolStripMenuItem_Click);
            // 
            // viewAllBookingsToolStripMenuItem
            // 
            this.viewAllBookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostRecentToolStripMenuItem,
            this.earliestEntryToolStripMenuItem});
            this.viewAllBookingsToolStripMenuItem.Name = "viewAllBookingsToolStripMenuItem";
            this.viewAllBookingsToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.viewAllBookingsToolStripMenuItem.Text = "View All Bookings";
            this.viewAllBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewAllBookingsToolStripMenuItem_Click);
            // 
            // mostRecentToolStripMenuItem
            // 
            this.mostRecentToolStripMenuItem.Name = "mostRecentToolStripMenuItem";
            this.mostRecentToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.mostRecentToolStripMenuItem.Text = "Most Recent";
            this.mostRecentToolStripMenuItem.Click += new System.EventHandler(this.mostRecentToolStripMenuItem_Click);
            // 
            // earliestEntryToolStripMenuItem
            // 
            this.earliestEntryToolStripMenuItem.Name = "earliestEntryToolStripMenuItem";
            this.earliestEntryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.earliestEntryToolStripMenuItem.Text = "Earliest Entry";
            this.earliestEntryToolStripMenuItem.Click += new System.EventHandler(this.earliestEntryToolStripMenuItem_Click);
            // 
            // updateBookingRecordToolStripMenuItem
            // 
            this.updateBookingRecordToolStripMenuItem.Name = "updateBookingRecordToolStripMenuItem";
            this.updateBookingRecordToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.updateBookingRecordToolStripMenuItem.Text = "Update Booking Record";
            this.updateBookingRecordToolStripMenuItem.Click += new System.EventHandler(this.updateBookingRecordToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllDoctorsToolStripMenuItem});
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // viewAllDoctorsToolStripMenuItem
            // 
            this.viewAllDoctorsToolStripMenuItem.Name = "viewAllDoctorsToolStripMenuItem";
            this.viewAllDoctorsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAllDoctorsToolStripMenuItem.Text = "View All Doctors";
            this.viewAllDoctorsToolStripMenuItem.Click += new System.EventHandler(this.viewAllDoctorsToolStripMenuItem_Click);
            // 
            // nursesToolStripMenuItem
            // 
            this.nursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllNursesToolStripMenuItem});
            this.nursesToolStripMenuItem.Name = "nursesToolStripMenuItem";
            this.nursesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.nursesToolStripMenuItem.Text = "Nurses";
            this.nursesToolStripMenuItem.Click += new System.EventHandler(this.nursesToolStripMenuItem_Click);
            // 
            // viewAllNursesToolStripMenuItem
            // 
            this.viewAllNursesToolStripMenuItem.Name = "viewAllNursesToolStripMenuItem";
            this.viewAllNursesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAllNursesToolStripMenuItem.Text = "View All Nurses";
            this.viewAllNursesToolStripMenuItem.Click += new System.EventHandler(this.viewAllNursesToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click_1);
            // 
            // LblPatients
            // 
            this.LblPatients.AutoSize = true;
            this.LblPatients.BackColor = System.Drawing.Color.Peru;
            this.LblPatients.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatients.ForeColor = System.Drawing.Color.White;
            this.LblPatients.Location = new System.Drawing.Point(31, 44);
            this.LblPatients.Name = "LblPatients";
            this.LblPatients.Size = new System.Drawing.Size(93, 21);
            this.LblPatients.TabIndex = 8;
            this.LblPatients.Text = "PATIENTS";
            // 
            // DgvPatients
            // 
            this.DgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPatients.Location = new System.Drawing.Point(35, 80);
            this.DgvPatients.Name = "DgvPatients";
            this.DgvPatients.Size = new System.Drawing.Size(1297, 105);
            this.DgvPatients.TabIndex = 9;
            // 
            // LblBookings
            // 
            this.LblBookings.AutoSize = true;
            this.LblBookings.BackColor = System.Drawing.Color.Peru;
            this.LblBookings.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookings.ForeColor = System.Drawing.Color.White;
            this.LblBookings.Location = new System.Drawing.Point(31, 207);
            this.LblBookings.Name = "LblBookings";
            this.LblBookings.Size = new System.Drawing.Size(101, 21);
            this.LblBookings.TabIndex = 10;
            this.LblBookings.Text = "BOOKINGS";
            // 
            // DgvBookings
            // 
            this.DgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBookings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBookings.Location = new System.Drawing.Point(35, 248);
            this.DgvBookings.Name = "DgvBookings";
            this.DgvBookings.Size = new System.Drawing.Size(1297, 105);
            this.DgvBookings.TabIndex = 11;
            this.DgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBookings_CellContentClick);
            // 
            // LblDoctors
            // 
            this.LblDoctors.AutoSize = true;
            this.LblDoctors.BackColor = System.Drawing.Color.Peru;
            this.LblDoctors.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDoctors.ForeColor = System.Drawing.Color.White;
            this.LblDoctors.Location = new System.Drawing.Point(30, 376);
            this.LblDoctors.Name = "LblDoctors";
            this.LblDoctors.Size = new System.Drawing.Size(94, 21);
            this.LblDoctors.TabIndex = 12;
            this.LblDoctors.Text = "DOCTORS";
            // 
            // DgvDoctors
            // 
            this.DgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoctors.Location = new System.Drawing.Point(34, 418);
            this.DgvDoctors.Name = "DgvDoctors";
            this.DgvDoctors.Size = new System.Drawing.Size(1298, 105);
            this.DgvDoctors.TabIndex = 13;
            // 
            // DgvNurses
            // 
            this.DgvNurses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvNurses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvNurses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNurses.Location = new System.Drawing.Point(34, 590);
            this.DgvNurses.Name = "DgvNurses";
            this.DgvNurses.Size = new System.Drawing.Size(1298, 105);
            this.DgvNurses.TabIndex = 14;
            // 
            // LblNurses
            // 
            this.LblNurses.AutoSize = true;
            this.LblNurses.BackColor = System.Drawing.Color.Peru;
            this.LblNurses.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNurses.ForeColor = System.Drawing.Color.White;
            this.LblNurses.Location = new System.Drawing.Point(30, 545);
            this.LblNurses.Name = "LblNurses";
            this.LblNurses.Size = new System.Drawing.Size(77, 21);
            this.LblNurses.TabIndex = 15;
            this.LblNurses.Text = "NURSES";
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.LblNurses);
            this.Controls.Add(this.DgvNurses);
            this.Controls.Add(this.DgvDoctors);
            this.Controls.Add(this.LblDoctors);
            this.Controls.Add(this.DgvBookings);
            this.Controls.Add(this.LblBookings);
            this.Controls.Add(this.DgvPatients);
            this.Controls.Add(this.LblPatients);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNurses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPatientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookAppointmentForPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllNursesToolStripMenuItem;
        private System.Windows.Forms.Label LblPatients;
        private System.Windows.Forms.DataGridView DgvPatients;
        private System.Windows.Forms.Label LblBookings;
        private System.Windows.Forms.DataGridView DgvBookings;
        private System.Windows.Forms.Label LblDoctors;
        private System.Windows.Forms.DataGridView DgvDoctors;
        private System.Windows.Forms.DataGridView DgvNurses;
        private System.Windows.Forms.Label LblNurses;
        private System.Windows.Forms.ToolStripMenuItem mostRecentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem earliestEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBookingRecordToolStripMenuItem;
    }
}