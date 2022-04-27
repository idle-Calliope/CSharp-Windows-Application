namespace AfroMed
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.DgvRecords = new System.Windows.Forms.DataGridView();
            this.LblSearch = new System.Windows.Forms.Label();
            this.GBoxSearch = new System.Windows.Forms.GroupBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblTable = new System.Windows.Forms.Label();
            this.CBoxTable = new System.Windows.Forms.ComboBox();
            this.BtnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            this.GBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvRecords
            // 
            this.DgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecords.Location = new System.Drawing.Point(17, 214);
            this.DgvRecords.Name = "DgvRecords";
            this.DgvRecords.Size = new System.Drawing.Size(988, 59);
            this.DgvRecords.TabIndex = 10;
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.BackColor = System.Drawing.Color.SaddleBrown;
            this.LblSearch.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSearch.ForeColor = System.Drawing.Color.White;
            this.LblSearch.Location = new System.Drawing.Point(20, 33);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(242, 28);
            this.LblSearch.TabIndex = 11;
            this.LblSearch.Text = "SEARCH RECORDS";
            // 
            // GBoxSearch
            // 
            this.GBoxSearch.Controls.Add(this.CBoxTable);
            this.GBoxSearch.Controls.Add(this.LblSearch);
            this.GBoxSearch.Controls.Add(this.LblTable);
            this.GBoxSearch.Controls.Add(this.BtnSearch);
            this.GBoxSearch.Controls.Add(this.TxtID);
            this.GBoxSearch.Controls.Add(this.LblID);
            this.GBoxSearch.Location = new System.Drawing.Point(17, 35);
            this.GBoxSearch.Name = "GBoxSearch";
            this.GBoxSearch.Size = new System.Drawing.Size(988, 163);
            this.GBoxSearch.TabIndex = 12;
            this.GBoxSearch.TabStop = false;
            // 
            // LblID
            // 
            this.LblID.BackColor = System.Drawing.Color.SaddleBrown;
            this.LblID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.Color.White;
            this.LblID.Location = new System.Drawing.Point(353, 37);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(106, 21);
            this.LblID.TabIndex = 9;
            this.LblID.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(453, 37);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(149, 20);
            this.TxtID.TabIndex = 10;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(530, 117);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(72, 27);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblTable
            // 
            this.LblTable.BackColor = System.Drawing.Color.SaddleBrown;
            this.LblTable.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTable.ForeColor = System.Drawing.Color.White;
            this.LblTable.Location = new System.Drawing.Point(353, 76);
            this.LblTable.Name = "LblTable";
            this.LblTable.Size = new System.Drawing.Size(106, 21);
            this.LblTable.TabIndex = 12;
            this.LblTable.Text = "Table";
            // 
            // CBoxTable
            // 
            this.CBoxTable.FormattingEnabled = true;
            this.CBoxTable.Items.AddRange(new object[] {
            "Patients",
            "Bookings",
            "Doctors",
            "Nurses"});
            this.CBoxTable.Location = new System.Drawing.Point(453, 76);
            this.CBoxTable.Name = "CBoxTable";
            this.CBoxTable.Size = new System.Drawing.Size(149, 21);
            this.CBoxTable.TabIndex = 13;
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
            this.BtnGoBack.TabIndex = 22;
            this.BtnGoBack.Text = "<< Go Back";
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1022, 285);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.GBoxSearch);
            this.Controls.Add(this.DgvRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            this.GBoxSearch.ResumeLayout(false);
            this.GBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRecords;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.GroupBox GBoxSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.ComboBox CBoxTable;
        private System.Windows.Forms.Label LblTable;
        private System.Windows.Forms.Button BtnGoBack;
    }
}