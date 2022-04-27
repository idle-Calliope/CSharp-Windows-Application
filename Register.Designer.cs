namespace AfroMed
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblPatientID = new System.Windows.Forms.Label();
            this.LblPatientRegister = new System.Windows.Forms.Label();
            this.BtnRegisterPatient = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPhoneNum = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.CBoxCardName = new System.Windows.Forms.ComboBox();
            this.CBoxType = new System.Windows.Forms.ComboBox();
            this.TxtAccountNum = new System.Windows.Forms.TextBox();
            this.LblAccountNum = new System.Windows.Forms.Label();
            this.LblCardCompany = new System.Windows.Forms.Label();
            this.LblCardType = new System.Windows.Forms.Label();
            this.LblEmailAddress = new System.Windows.Forms.Label();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.LblPatientName = new System.Windows.Forms.Label();
            this.BtnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtID
            // 
            this.TxtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtID.Location = new System.Drawing.Point(272, 131);
            this.TxtID.MaximumSize = new System.Drawing.Size(300, 100);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(228, 26);
            this.TxtID.TabIndex = 12;
            // 
            // LblPatientID
            // 
            this.LblPatientID.BackColor = System.Drawing.Color.Tan;
            this.LblPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientID.ForeColor = System.Drawing.Color.White;
            this.LblPatientID.Location = new System.Drawing.Point(95, 131);
            this.LblPatientID.Name = "LblPatientID";
            this.LblPatientID.Size = new System.Drawing.Size(180, 26);
            this.LblPatientID.TabIndex = 11;
            this.LblPatientID.Text = "PatientID";
            // 
            // LblPatientRegister
            // 
            this.LblPatientRegister.AutoSize = true;
            this.LblPatientRegister.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientRegister.Location = new System.Drawing.Point(198, 79);
            this.LblPatientRegister.Name = "LblPatientRegister";
            this.LblPatientRegister.Size = new System.Drawing.Size(213, 27);
            this.LblPatientRegister.TabIndex = 10;
            this.LblPatientRegister.Text = "Register Patient";
            // 
            // BtnRegisterPatient
            // 
            this.BtnRegisterPatient.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnRegisterPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRegisterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegisterPatient.Location = new System.Drawing.Point(227, 445);
            this.BtnRegisterPatient.Name = "BtnRegisterPatient";
            this.BtnRegisterPatient.Size = new System.Drawing.Size(95, 34);
            this.BtnRegisterPatient.TabIndex = 9;
            this.BtnRegisterPatient.Text = "Register";
            this.BtnRegisterPatient.UseVisualStyleBackColor = false;
            this.BtnRegisterPatient.Click += new System.EventHandler(this.BtnRegisterPatient_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(272, 275);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(228, 26);
            this.TxtEmail.TabIndex = 8;
            // 
            // TxtPhoneNum
            // 
            this.TxtPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneNum.Location = new System.Drawing.Point(272, 225);
            this.TxtPhoneNum.Name = "TxtPhoneNum";
            this.TxtPhoneNum.Size = new System.Drawing.Size(228, 26);
            this.TxtPhoneNum.TabIndex = 7;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFullName.Location = new System.Drawing.Point(272, 176);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(228, 26);
            this.TxtFullName.TabIndex = 6;
            // 
            // CBoxCardName
            // 
            this.CBoxCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxCardName.FormattingEnabled = true;
            this.CBoxCardName.Items.AddRange(new object[] {
            "VISA",
            "FNB",
            "Standard Bank Lesotho",
            "Post Bank"});
            this.CBoxCardName.Location = new System.Drawing.Point(272, 362);
            this.CBoxCardName.Name = "CBoxCardName";
            this.CBoxCardName.Size = new System.Drawing.Size(228, 28);
            this.CBoxCardName.TabIndex = 11;
            // 
            // CBoxType
            // 
            this.CBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxType.FormattingEnabled = true;
            this.CBoxType.Items.AddRange(new object[] {
            "Credit Card",
            "Debit Card"});
            this.CBoxType.Location = new System.Drawing.Point(272, 322);
            this.CBoxType.Name = "CBoxType";
            this.CBoxType.Size = new System.Drawing.Size(228, 28);
            this.CBoxType.TabIndex = 10;
            // 
            // TxtAccountNum
            // 
            this.TxtAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAccountNum.Location = new System.Drawing.Point(272, 400);
            this.TxtAccountNum.Name = "TxtAccountNum";
            this.TxtAccountNum.Size = new System.Drawing.Size(228, 26);
            this.TxtAccountNum.TabIndex = 9;
            // 
            // LblAccountNum
            // 
            this.LblAccountNum.BackColor = System.Drawing.Color.Chocolate;
            this.LblAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAccountNum.ForeColor = System.Drawing.Color.White;
            this.LblAccountNum.Location = new System.Drawing.Point(97, 400);
            this.LblAccountNum.Name = "LblAccountNum";
            this.LblAccountNum.Size = new System.Drawing.Size(178, 23);
            this.LblAccountNum.TabIndex = 2;
            this.LblAccountNum.Text = "Account Number";
            this.LblAccountNum.Click += new System.EventHandler(this.LblAccountNum_Click);
            // 
            // LblCardCompany
            // 
            this.LblCardCompany.BackColor = System.Drawing.Color.Firebrick;
            this.LblCardCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardCompany.ForeColor = System.Drawing.Color.White;
            this.LblCardCompany.Location = new System.Drawing.Point(97, 362);
            this.LblCardCompany.Name = "LblCardCompany";
            this.LblCardCompany.Size = new System.Drawing.Size(179, 19);
            this.LblCardCompany.TabIndex = 1;
            this.LblCardCompany.Text = "Card Name";
            // 
            // LblCardType
            // 
            this.LblCardType.BackColor = System.Drawing.Color.Maroon;
            this.LblCardType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCardType.ForeColor = System.Drawing.Color.White;
            this.LblCardType.Location = new System.Drawing.Point(97, 322);
            this.LblCardType.Name = "LblCardType";
            this.LblCardType.Size = new System.Drawing.Size(178, 19);
            this.LblCardType.TabIndex = 0;
            this.LblCardType.Text = "Card Type";
            // 
            // LblEmailAddress
            // 
            this.LblEmailAddress.BackColor = System.Drawing.Color.Chocolate;
            this.LblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmailAddress.ForeColor = System.Drawing.Color.White;
            this.LblEmailAddress.Location = new System.Drawing.Point(97, 275);
            this.LblEmailAddress.Name = "LblEmailAddress";
            this.LblEmailAddress.Size = new System.Drawing.Size(180, 26);
            this.LblEmailAddress.TabIndex = 3;
            this.LblEmailAddress.Text = "Email Address";
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.BackColor = System.Drawing.Color.DarkRed;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.LblPhoneNumber.Location = new System.Drawing.Point(97, 225);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(179, 26);
            this.LblPhoneNumber.TabIndex = 2;
            this.LblPhoneNumber.Text = "Phone Number";
            // 
            // LblPatientName
            // 
            this.LblPatientName.BackColor = System.Drawing.Color.Sienna;
            this.LblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientName.ForeColor = System.Drawing.Color.White;
            this.LblPatientName.Location = new System.Drawing.Point(96, 176);
            this.LblPatientName.Name = "LblPatientName";
            this.LblPatientName.Size = new System.Drawing.Size(180, 26);
            this.LblPatientName.TabIndex = 1;
            this.LblPatientName.Text = "Full Name";
            this.LblPatientName.Click += new System.EventHandler(this.LblPatientName_Click);
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.DimGray;
            this.BtnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoBack.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoBack.ForeColor = System.Drawing.Color.White;
            this.BtnGoBack.Location = new System.Drawing.Point(0, 0);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(104, 23);
            this.BtnGoBack.TabIndex = 21;
            this.BtnGoBack.Text = "<< Go Back";
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(617, 507);
            this.Controls.Add(this.BtnRegisterPatient);
            this.Controls.Add(this.TxtAccountNum);
            this.Controls.Add(this.CBoxCardName);
            this.Controls.Add(this.LblAccountNum);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.CBoxType);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblCardCompany);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.TxtPhoneNum);
            this.Controls.Add(this.LblEmailAddress);
            this.Controls.Add(this.LblCardType);
            this.Controls.Add(this.LblPatientID);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.LblPhoneNumber);
            this.Controls.Add(this.LblPatientRegister);
            this.Controls.Add(this.LblPatientName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfroMed In-patient Private Clinic - Register Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblPatientName;
        private System.Windows.Forms.Label LblEmailAddress;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.Label LblAccountNum;
        private System.Windows.Forms.Label LblCardCompany;
        private System.Windows.Forms.Label LblCardType;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPhoneNum;
        private System.Windows.Forms.TextBox TxtAccountNum;
        private System.Windows.Forms.Button BtnRegisterPatient;
        private System.Windows.Forms.ComboBox CBoxCardName;
        private System.Windows.Forms.ComboBox CBoxType;
        private System.Windows.Forms.Label LblPatientRegister;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblPatientID;
        private System.Windows.Forms.Button BtnGoBack;
    }
}