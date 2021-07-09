using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookUserControl : UserControl
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public BookUserControl()
        {
            InitializeComponent();
            string sql = "select * from bookinfo;";
            this.PopulateGridView(sql);
            this.GenerateBookId();
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvLiBook.AutoGenerateColumns = false;
            this.dgvLiBook.DataSource = this.Ds.Tables[0];

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from bookinfo where CONCAT(bookid,booktitle,authorname,publishername,publisheddate,quantity) like '%" + txtSearch.Text + "%';";
                this.PopulateGridView(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Search Book\n" + exc.Message);
            }
        }

        private void btnBookSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookId.Text != "" && txtBookTitle.Text != "" && this.txtAuthor.Text != "" && this.txtPublisher.Text != "" && this.nudQuantity.Text != "0")
                {


                    this.Sql = "select * from bookinfo where bookid='" + this.txtBookId.Text + "';";
                    this.Ds = DataAccess.ExecuteQuery(this.Sql);
                    if (this.Ds.Tables[0].Rows.Count == 1)
                    {
                        this.Sql = @"update bookinfo 
                           set booktitle='" + this.txtBookTitle.Text + @"',
                           authorname='" + this.txtAuthor.Text + @"',
                           publishername='" + this.txtPublisher.Text + "',publisheddate='" + this.dtpPublishedDate.Text + "',quantity=" + this.nudQuantity.Text + " where bookid='" + this.txtBookId.Text + "';";
                        int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show("Data updated");
                            string sql = "select * from bookinfo;";
                            this.PopulateGridView(sql);
                            this.GenerateBookId();
                        }
                        else
                        {
                            MessageBox.Show("Data update failed");
                        }
                    }

                    else
                    {
                        this.Sql = @"insert into bookinfo
                    values ('" + this.txtBookId.Text + "','" + this.txtBookTitle.Text + "','" + this.txtAuthor.Text + "','" + this.txtPublisher.Text + "','" + this.dtpPublishedDate.Text + "'," + this.nudQuantity.Text + ");";

                        int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show("Data added properly");
                            this.GenerateBookId();
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed");
                        }
                    }
                }

                else {
                    MessageBox.Show("Please insert information");
                }
                
                this.PopulateGridView("select * from bookinfo;");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the data\n\n" + exc.Message);
            }

        }

        private void dgvLiBook_DoubleClick(object sender, EventArgs e)
        {

            this.txtBookId.Text = this.dgvLiBook.CurrentRow.Cells["bookid"].Value.ToString();
            this.txtBookTitle.Text = this.dgvLiBook.CurrentRow.Cells["booktitle"].Value.ToString();
            this.txtAuthor.Text = this.dgvLiBook.CurrentRow.Cells["authorname"].Value.ToString();
            this.txtPublisher.Text = this.dgvLiBook.CurrentRow.Cells["publishername"].Value.ToString();
            this.dtpPublishedDate.Text = this.dgvLiBook.CurrentRow.Cells["publisheddate"].Value.ToString();
            this.nudQuantity.Text = this.dgvLiBook.CurrentRow.Cells["quantity"].Value.ToString();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to Delete the book !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    string bookId = this.dgvLiBook.CurrentRow.Cells[0].Value.ToString();
                    string bookTitle = this.dgvLiBook.CurrentRow.Cells["booktitle"].Value.ToString();
                   

                    this.Sql = @"delete from bookinfo
                        where bookid = '" + bookId + "';";
                    int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(bookTitle + " has been deleted");
                    }
                    else
                    {
                        MessageBox.Show("Data deletion failed");
                    }

                    this.PopulateGridView("select * from bookinfo;");
                }

                else
                {
                    MessageBox.Show("Delete not completed");

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        
        }

        private void btnBookClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            //this.txtBookId.Clear();
            this.txtBookTitle.Clear();
            this.txtAuthor.Clear();
            this.txtPublisher.Clear();
            this.dtpPublishedDate.Text = "";
            this.nudQuantity.Text = "0";
        }

        private void GenerateBookId()
        {
            try
            {
                this.Sql = "select * from bookinfo order by bookid desc;";
                DataTable dt = DataAccess.ExecuteQueryTable(this.Sql);
                string id = dt.Rows[0]["bookid"].ToString();
                string[] str = id.Split('b');
                int number = Convert.ToInt32(str[1]);
                string newId = "b" + (++number).ToString("d3");
                this.txtBookId.Text = newId;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Generate Book Id\n" + exc.Message);
            }
        
        }
    }
}
