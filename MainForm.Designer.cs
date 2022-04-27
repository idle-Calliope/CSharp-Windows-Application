namespace AfroMed
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LblGreeting = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGreeting
            // 
            this.LblGreeting.AutoSize = true;
            this.LblGreeting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGreeting.ForeColor = System.Drawing.Color.Beige;
            this.LblGreeting.Image = ((System.Drawing.Image)(resources.GetObject("LblGreeting.Image")));
            this.LblGreeting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblGreeting.Location = new System.Drawing.Point(16, 135);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(587, 39);
            this.LblGreeting.TabIndex = 0;
            this.LblGreeting.Text = "Welcome to AfroMed Private Clinic";
            this.LblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogIn.Location = new System.Drawing.Point(273, 279);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(84, 34);
            this.BtnLogIn.TabIndex = 1;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 378);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.LblGreeting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AfroMed In-patient Private Clinic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.Button BtnLogIn;
    }
}

