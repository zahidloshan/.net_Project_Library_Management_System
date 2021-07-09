namespace LibraryManagementSystem
{
    partial class BookUserControl
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
            this.dgvLiBook = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.dtpPublishedDate = new System.Windows.Forms.DateTimePicker();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBookSave = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookClear = new System.Windows.Forms.Button();
            this.bookid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisheddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLiBook
            // 
            this.dgvLiBook.AllowUserToAddRows = false;
            this.dgvLiBook.AllowUserToDeleteRows = false;
            this.dgvLiBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLiBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookid,
            this.booktitle,
            this.authorname,
            this.publishername,
            this.publisheddate,
            this.quantity});
            this.dgvLiBook.Location = new System.Drawing.Point(3, 223);
            this.dgvLiBook.Name = "dgvLiBook";
            this.dgvLiBook.ReadOnly = true;
            this.dgvLiBook.Size = new System.Drawing.Size(641, 208);
            this.dgvLiBook.TabIndex = 0;
            this.dgvLiBook.DoubleClick += new System.EventHandler(this.dgvLiBook_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Author Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Published Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(161, 20);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(155, 20);
            this.txtBookId.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(161, 49);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(155, 20);
            this.txtBookTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(161, 85);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(155, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(161, 121);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(155, 20);
            this.txtPublisher.TabIndex = 10;
            // 
            // dtpPublishedDate
            // 
            this.dtpPublishedDate.CustomFormat = "dd-MM-yy";
            this.dtpPublishedDate.Location = new System.Drawing.Point(161, 159);
            this.dtpPublishedDate.Name = "dtpPublishedDate";
            this.dtpPublishedDate.Size = new System.Drawing.Size(155, 20);
            this.dtpPublishedDate.TabIndex = 13;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(161, 192);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(84, 20);
            this.nudQuantity.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(323, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(405, 201);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBookSave
            // 
            this.btnBookSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBookSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSave.Location = new System.Drawing.Point(354, 20);
            this.btnBookSave.Name = "btnBookSave";
            this.btnBookSave.Size = new System.Drawing.Size(101, 37);
            this.btnBookSave.TabIndex = 17;
            this.btnBookSave.Text = "Save";
            this.btnBookSave.UseVisualStyleBackColor = false;
            this.btnBookSave.Click += new System.EventHandler(this.btnBookSave_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBookDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookDelete.Location = new System.Drawing.Point(354, 68);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(101, 37);
            this.btnBookDelete.TabIndex = 18;
            this.btnBookDelete.Text = "Delete";
            this.btnBookDelete.UseVisualStyleBackColor = false;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnBookClear
            // 
            this.btnBookClear.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBookClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookClear.Location = new System.Drawing.Point(354, 121);
            this.btnBookClear.Name = "btnBookClear";
            this.btnBookClear.Size = new System.Drawing.Size(101, 37);
            this.btnBookClear.TabIndex = 19;
            this.btnBookClear.Text = "Clear";
            this.btnBookClear.UseVisualStyleBackColor = false;
            this.btnBookClear.Click += new System.EventHandler(this.btnBookClear_Click);
            // 
            // bookid
            // 
            this.bookid.DataPropertyName = "bookid";
            this.bookid.HeaderText = "Book Id";
            this.bookid.Name = "bookid";
            this.bookid.ReadOnly = true;
            // 
            // booktitle
            // 
            this.booktitle.DataPropertyName = "booktitle";
            this.booktitle.HeaderText = "Book Title";
            this.booktitle.Name = "booktitle";
            this.booktitle.ReadOnly = true;
            // 
            // authorname
            // 
            this.authorname.DataPropertyName = "authorname";
            this.authorname.HeaderText = "Author Name";
            this.authorname.Name = "authorname";
            this.authorname.ReadOnly = true;
            // 
            // publishername
            // 
            this.publishername.DataPropertyName = "publishername";
            this.publishername.HeaderText = "Publisher Name";
            this.publishername.Name = "publishername";
            this.publishername.ReadOnly = true;
            // 
            // publisheddate
            // 
            this.publisheddate.DataPropertyName = "publisheddate";
            this.publisheddate.HeaderText = "Published Date";
            this.publisheddate.Name = "publisheddate";
            this.publisheddate.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Book Amount";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // BookUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBookClear);
            this.Controls.Add(this.btnBookDelete);
            this.Controls.Add(this.btnBookSave);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.dtpPublishedDate);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLiBook);
            this.Name = "BookUserControl";
            this.Size = new System.Drawing.Size(647, 434);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLiBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.DateTimePicker dtpPublishedDate;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBookSave;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookid;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishername;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisheddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}
