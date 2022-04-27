namespace AfroMed
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.GBAdmin = new System.Windows.Forms.GroupBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.GBAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAdmin
            // 
            this.GBAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GBAdmin.Controls.Add(this.BtnLogIn);
            this.GBAdmin.Controls.Add(this.TxtPassword);
            this.GBAdmin.Controls.Add(this.TxtID);
            this.GBAdmin.Controls.Add(this.LblPassword);
            this.GBAdmin.Controls.Add(this.LblID);
            this.GBAdmin.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBAdmin.ForeColor = System.Drawing.Color.Honeydew;
            this.GBAdmin.Location = new System.Drawing.Point(48, 47);
            this.GBAdmin.Name = "GBAdmin";
            this.GBAdmin.Size = new System.Drawing.Size(474, 191);
            this.GBAdmin.TabIndex = 0;
            this.GBAdmin.TabStop = false;
            this.GBAdmin.Text = "Admin Log In";
            this.GBAdmin.Enter += new System.EventHandler(this.GBAdmin_Enter);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogIn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.Location = new System.Drawing.Point(194, 140);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(87, 31);
            this.BtnLogIn.TabIndex = 4;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(181, 92);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(231, 27);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(181, 41);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(231, 27);
            this.TxtID.TabIndex = 2;
            this.TxtID.TextChanged += new System.EventHandler(this.TxtID_TextChanged);
            // 
            // LblPassword
            // 
            this.LblPassword.BackColor = System.Drawing.Color.Sienna;
            this.LblPassword.Location = new System.Drawing.Point(53, 92);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(146, 26);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            this.LblPassword.Click += new System.EventHandler(this.LblPassword_Click);
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.Maroon;
            this.LblID.Location = new System.Drawing.Point(53, 42);
            this.LblID.Margin = new System.Windows.Forms.Padding(3);
            this.LblID.Name = "LblID";
            this.LblID.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.LblID.Size = new System.Drawing.Size(146, 26);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            this.LblID.Click += new System.EventHandler(this.LblID_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 287);
            this.Controls.Add(this.GBAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfroMed In-patient Private Clinic - Log In Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.GBAdmin.ResumeLayout(false);
            this.GBAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAdmin;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnLogIn;
    }
}