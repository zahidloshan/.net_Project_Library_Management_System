namespace LibraryManagementSystem
{
    partial class LibrarianForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLibrarianOperation = new System.Windows.Forms.Button();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnBookInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.librarianUserControl11 = new LibraryManagementSystem.LibrarianUserControl1();
            this.studentUserControl1 = new LibraryManagementSystem.StudentUserControl();
            this.bookUserControl1 = new LibraryManagementSystem.BookUserControl();
            this.btnLibrarianLogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLibrarianLogOut);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLibrarianOperation);
            this.panel1.Controls.Add(this.btnStudentInfo);
            this.panel1.Controls.Add(this.btnBookInfo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 434);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.imgpsh_fullsize__1_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLibrarianOperation
            // 
            this.btnLibrarianOperation.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLibrarianOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarianOperation.Location = new System.Drawing.Point(3, 139);
            this.btnLibrarianOperation.Name = "btnLibrarianOperation";
            this.btnLibrarianOperation.Size = new System.Drawing.Size(176, 44);
            this.btnLibrarianOperation.TabIndex = 2;
            this.btnLibrarianOperation.Text = "Librarian Operation";
            this.btnLibrarianOperation.UseVisualStyleBackColor = false;
            this.btnLibrarianOperation.Click += new System.EventHandler(this.btnLibrarianOperation_Click);
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfo.Location = new System.Drawing.Point(3, 79);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(176, 44);
            this.btnStudentInfo.TabIndex = 1;
            this.btnStudentInfo.Text = "Student Operation";
            this.btnStudentInfo.UseVisualStyleBackColor = false;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookInfo.Location = new System.Drawing.Point(3, 20);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Size = new System.Drawing.Size(176, 44);
            this.btnBookInfo.TabIndex = 0;
            this.btnBookInfo.Text = "Book Operation";
            this.btnBookInfo.UseVisualStyleBackColor = false;
            this.btnBookInfo.Click += new System.EventHandler(this.btnBookInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.librarianUserControl11);
            this.panel2.Controls.Add(this.studentUserControl1);
            this.panel2.Controls.Add(this.bookUserControl1);
            this.panel2.Location = new System.Drawing.Point(210, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 434);
            this.panel2.TabIndex = 1;
            // 
            // librarianUserControl11
            // 
            this.librarianUserControl11.Location = new System.Drawing.Point(3, 3);
            this.librarianUserControl11.Name = "librarianUserControl11";
            this.librarianUserControl11.Size = new System.Drawing.Size(641, 431);
            this.librarianUserControl11.TabIndex = 2;
            // 
            // studentUserControl1
            // 
            this.studentUserControl1.Location = new System.Drawing.Point(3, 3);
            this.studentUserControl1.Name = "studentUserControl1";
            this.studentUserControl1.Size = new System.Drawing.Size(641, 431);
            this.studentUserControl1.TabIndex = 1;
            // 
            // bookUserControl1
            // 
            this.bookUserControl1.Location = new System.Drawing.Point(3, 3);
            this.bookUserControl1.Name = "bookUserControl1";
            this.bookUserControl1.Size = new System.Drawing.Size(641, 434);
            this.bookUserControl1.TabIndex = 0;
            // 
            // btnLibrarianLogOut
            // 
            this.btnLibrarianLogOut.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLibrarianLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarianLogOut.Location = new System.Drawing.Point(3, 195);
            this.btnLibrarianLogOut.Name = "btnLibrarianLogOut";
            this.btnLibrarianLogOut.Size = new System.Drawing.Size(176, 44);
            this.btnLibrarianLogOut.TabIndex = 4;
            this.btnLibrarianLogOut.Text = "Log Out";
            this.btnLibrarianLogOut.UseVisualStyleBackColor = false;
            this.btnLibrarianLogOut.Click += new System.EventHandler(this.btnLibrarianLogOut_Click);
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "LibrarianForm";
            this.Text = "Librarian";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibrarianForm_FormClosed);
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBookInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStudentInfo;
        private StudentUserControl studentUserControl1;
        private BookUserControl bookUserControl1;
        private System.Windows.Forms.Button btnLibrarianOperation;
        private LibrarianUserControl1 librarianUserControl11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLibrarianLogOut;
    }
}