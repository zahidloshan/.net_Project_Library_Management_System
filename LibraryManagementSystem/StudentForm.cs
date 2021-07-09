using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class StudentForm : Form
    {
       
        private DataSet Ds { get; set; }
        private string Sql{ get; set; }
        private LoginForm Lfrm{get; set;}
        private string currentId;
        private string bookAmount;
        public StudentForm()
        {
            InitializeComponent();
            string sql = "select * from bookinfo;";
            this.PupolateGridView(sql);
        }
        public StudentForm(string studentId,LoginForm lfrm): this()
        {
            this.currentId = studentId;
            this.Lfrm = lfrm;
        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PupolateGridView(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvBook.AutoGenerateColumns = false;
            this.dgvBook.DataSource = this.Ds.Tables[0];

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from bookinfo where CONCAT(bookid,booktitle,authorname,publishername) like '%" + this.txtSearch.Text + "%';";
                this.PupolateGridView(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Search\n" + exc.Message);
            }
        }

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            this.bookAmount = this.dgvBook.CurrentRow.Cells["quantity"].Value.ToString();
            this.txtStudentId.Text = currentId;
            this.txtBookId.Text = this.dgvBook.CurrentRow.Cells["bookid"].Value.ToString();
            this.txtBookTitle.Text = this.dgvBook.CurrentRow.Cells["booktitle"].Value.ToString();
            
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                this.PupolateGridView("select * from bookinfo;");


                this.Sql = "select * from borrowinfo where studentid='" + currentId + "' and bookid = '" + txtBookId.Text + "';";
                this.Ds = DataAccess.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Already Borrow this Book");
                }
                else
                {


                    if (txtBookId.Text != "" && txtBookTitle.Text != "" && txtStudentId.Text != "")
                    {

                        
                        int n = Convert.ToInt32(this.bookAmount);
                        if (n == 0)
                        {
                            MessageBox.Show("Book is Unavailable");
                        }
                        else
                        {
                            this.Sql = @"insert into borrowinfo
                                       values ('" + this.txtStudentId.Text + "','" + this.txtBookId.Text + "','" + this.txtBookTitle.Text + "','" + this.dtpBorrowDate.Text + "');";
                            
                            DataAccess.ExecuteUpdateQuery(this.Sql);
                            n--;
                            this.Sql = @"update bookinfo
                             set quantity =" + n + @"
                             where bookid='" + this.txtBookId.Text + "';";
                            DataAccess.ExecuteUpdateQuery(this.Sql);
                            this.PupolateGridView("select * from bookinfo;");
                            MessageBox.Show("Successfully Borrow the Book");

                        }


                    }

                    else
                    {

                        MessageBox.Show("Please Select a Book");
                    }


                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Borrow Book\n" + exc.Message);
            }

            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from borrowinfo where studentid='" + currentId + "';";
                this.PupolateGridViewReturn(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Return Book\n" + exc.Message);
            }
        }
        private void PupolateGridViewReturn(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvReturn.AutoGenerateColumns = false;
            this.dgvReturn.DataSource = this.Ds.Tables[0];

        }

        private void dgvReturn_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to return the book !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string bid = this.dgvReturn.CurrentRow.Cells[0].Value.ToString();
                    string btitle = this.dgvReturn.CurrentRow.Cells[1].Value.ToString();

                    this.Sql = @"insert into returninfo
                      values ('" + currentId + "','" + bid + "','" + btitle + "','" + this.dtpBorrowDate.Text + "');";
                    DataAccess.ExecuteUpdateQuery(this.Sql);

                    string sqldelete = @"delete from borrowinfo
                         where studentid = '" + currentId + "'and bookid='" + bid + "';";
                    DataAccess.ExecuteUpdateQuery(sqldelete);
                    MessageBox.Show("Successfully Return the Book");

                    string sql = "select * from borrowinfo where studentid='" + currentId + "';";
                    this.PupolateGridViewReturn(sql);

                    string sql1 = "select * from bookinfo where bookid='" + bid + "';";

                    DataTable dt1 = DataAccess.ExecuteQueryTable(sql1);
                    string bookcount = dt1.Rows[0]["quantity"].ToString();
                    
                    int n = Convert.ToInt32(bookcount);
                    
                    n++;
                    this.Sql = @"update bookinfo
                             set quantity =" + n + @"
                             where bookid='" + bid + "';";
                    DataAccess.ExecuteUpdateQuery(this.Sql);
                    this.PupolateGridView("select * from bookinfo;");
                }

                else
                {
                    MessageBox.Show("Return not completed");

                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Return Book\n" + exc.Message);
            }
        
        }

        private void btnStudentLogOut_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are want to Log Out !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                this.Lfrm.Show();
            }
            else {
                MessageBox.Show("LogOut is canceled");
            }
        }
        
    }
}
