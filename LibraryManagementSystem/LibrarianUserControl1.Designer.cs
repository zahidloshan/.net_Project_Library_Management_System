namespace LibraryManagementSystem
{
    partial class LibrarianUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLibrarianDelete = new System.Windows.Forms.Button();
            this.btnLibrarianSave = new System.Windows.Forms.Button();
            this.txtLibrarianSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.txtLibrarianName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLibrarianId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLibrarian = new System.Windows.Forms.DataGridView();
            this.librariantid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librarianname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joiningdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(377, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 37);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLibrarianDelete
            // 
            this.btnLibrarianDelete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLibrarianDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarianDelete.Location = new System.Drawing.Point(377, 66);
            this.btnLibrarianDelete.Name = "btnLibrarianDelete";
            this.btnLibrarianDelete.Size = new System.Drawing.Size(101, 37);
            this.btnLibrarianDelete.TabIndex = 51;
            this.btnLibrarianDelete.Text = "Delete";
            this.btnLibrarianDelete.UseVisualStyleBackColor = false;
            this.btnLibrarianDelete.Click += new System.EventHandler(this.btnLibrarianDelete_Click);
            // 
            // btnLibrarianSave
            // 
            this.btnLibrarianSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLibrarianSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarianSave.Location = new System.Drawing.Point(377, 14);
            this.btnLibrarianSave.Name = "btnLibrarianSave";
            this.btnLibrarianSave.Size = new System.Drawing.Size(101, 37);
            this.btnLibrarianSave.TabIndex = 50;
            this.btnLibrarianSave.Text = "Save";
            this.btnLibrarianSave.UseVisualStyleBackColor = false;
            this.btnLibrarianSave.Click += new System.EventHandler(this.btnLibrarianSave_Click);
            // 
            // txtLibrarianSearch
            // 
            this.txtLibrarianSearch.Location = new System.Drawing.Point(85, 173);
            this.txtLibrarianSearch.Name = "txtLibrarianSearch";
            this.txtLibrarianSearch.Size = new System.Drawing.Size(214, 20);
            this.txtLibrarianSearch.TabIndex = 49;
            this.txtLibrarianSearch.TextChanged += new System.EventHandler(this.txtLibrarianSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Search";
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "dd-MM-yy";
            this.dtpJoiningDate.Location = new System.Drawing.Point(173, 121);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(155, 20);
            this.dtpJoiningDate.TabIndex = 47;
            // 
            // txtLibrarianName
            // 
            this.txtLibrarianName.Location = new System.Drawing.Point(173, 83);
            this.txtLibrarianName.Name = "txtLibrarianName";
            this.txtLibrarianName.Size = new System.Drawing.Size(155, 20);
            this.txtLibrarianName.TabIndex = 46;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 20);
            this.txtPassword.TabIndex = 45;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLibrarianId
            // 
            this.txtLibrarianId.Location = new System.Drawing.Point(173, 18);
            this.txtLibrarianId.Name = "txtLibrarianId";
            this.txtLibrarianId.ReadOnly = true;
            this.txtLibrarianId.Size = new System.Drawing.Size(155, 20);
            this.txtLibrarianId.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Joining Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Librarian Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Librarian Id";
            // 
            // dgvLibrarian
            // 
            this.dgvLibrarian.AllowUserToAddRows = false;
            this.dgvLibrarian.AllowUserToDeleteRows = false;
            this.dgvLibrarian.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrarian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.librariantid,
            this.librarianname,
            this.joiningdate});
            this.dgvLibrarian.Location = new System.Drawing.Point(3, 199);
            this.dgvLibrarian.Name = "dgvLibrarian";
            this.dgvLibrarian.ReadOnly = true;
            this.dgvLibrarian.Size = new System.Drawing.Size(641, 233);
            this.dgvLibrarian.TabIndex = 38;
            this.dgvLibrarian.DoubleClick += new System.EventHandler(this.dgvLibrarian_DoubleClick);
            // 
            // librariantid
            // 
            this.librariantid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.librariantid.DataPropertyName = "librarianid";
            this.librariantid.HeaderText = "Librarian Id";
            this.librariantid.Name = "librariantid";
            this.librariantid.ReadOnly = true;
            // 
            // librarianname
            // 
            this.librarianname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.librarianname.DataPropertyName = "librarianname";
            this.librarianname.HeaderText = "Librarian Name";
            this.librarianname.Name = "librarianname";
            this.librarianname.ReadOnly = true;
            // 
            // joiningdate
            // 
            this.joiningdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.joiningdate.DataPropertyName = "joiningdate";
            this.joiningdate.HeaderText = "Joining Date";
            this.joiningdate.Name = "joiningdate";
            this.joiningdate.ReadOnly = true;
            // 
            // LibrarianUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLibrarianDelete);
            this.Controls.Add(this.btnLibrarianSave);
            this.Controls.Add(this.txtLibrarianSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpJoiningDate);
            this.Controls.Add(this.txtLibrarianName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLibrarianId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLibrarian);
            this.Name = "LibrarianUserControl1";
            this.Size = new System.Drawing.Size(647, 434);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLibrarianDelete;
        private System.Windows.Forms.Button btnLibrarianSave;
        private System.Windows.Forms.TextBox txtLibrarianSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private System.Windows.Forms.TextBox txtLibrarianName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLibrarianId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLibrarian;
        private System.Windows.Forms.DataGridViewTextBoxColumn librariantid;
        private System.Windows.Forms.DataGridViewTextBoxColumn librarianname;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningdate;
    }
}
