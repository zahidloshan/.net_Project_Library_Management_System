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
    public partial class LibrarianUserControl1 : UserControl
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public LibrarianUserControl1()
        {
            InitializeComponent();
            string sql = "select * from librarianinfo;";
            this.PopulateGridView(sql);
            this.GenerateLibrarianId();
        }
        private void PopulateGridView(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvLibrarian.AutoGenerateColumns = false;
            this.dgvLibrarian.DataSource = this.Ds.Tables[0];

        }

        private void txtLibrarianSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from librarianinfo where CONCAT(librarianid,librarianname,joiningdate) like '%" + this.txtLibrarianSearch.Text + "%';";
                this.PopulateGridView(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Librarian Search\n" + exc.Message);
            }
        }

        private void btnLibrarianSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from librarianinfo where librarianid='" + this.txtLibrarianId.Text + "';";
                this.Ds = DataAccess.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    if (this.txtLibrarianId.Text != "" && this.txtLibrarianName.Text != "" )
                    {

                        this.Sql = @"update librarianinfo
                                     set librarianname='"+this.txtLibrarianName.Text+@"',
                                     joiningdate='"+this.dtpJoiningDate.Text+@"'
                                     where librarianid='"+this.txtLibrarianId.Text+"';";
                        int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show("Data updated");
                            string sql = "select * from librarianinfo;";
                            this.PopulateGridView(sql);
                            this.GenerateLibrarianId();
                        }
                        else
                        {
                            MessageBox.Show("Data update failed");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please insert information");
                    }
                }

                else
                {
                    if (this.txtLibrarianId.Text != "" && this.txtPassword.Text != "" && this.txtLibrarianName.Text != "" )
                    {
                        this.Sql = @"insert into librarianinfo
                             values ('" + this.txtLibrarianId.Text + "','" + this.txtLibrarianName.Text + "','" + this.dtpJoiningDate.Text + "');";

                        string sql = @"insert into logininfo
                             values ('" + this.txtLibrarianId.Text + "','librarian','" + this.txtPassword.Text + "');";
                        DataAccess.ExecuteUpdateQuery(sql);
                        int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                        if (count == 1)
                        {
                            MessageBox.Show("Data added properly");
                            this.GenerateLibrarianId();
                        }
                        else
                        {
                            MessageBox.Show("Data insertion failed");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please insert information");
                    }
                }

                this.PopulateGridView("select * from librarianinfo;");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the data\n\n" + exc.Message);
            }
        }

        private void dgvLibrarian_DoubleClick(object sender, EventArgs e)
        {
            this.txtLibrarianId.Text = this.dgvLibrarian.CurrentRow.Cells[0].Value.ToString();
            this.txtLibrarianName.Text = this.dgvLibrarian.CurrentRow.Cells["librarianname"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvLibrarian.CurrentRow.Cells["joiningdate"].Value.ToString();
        }

        private void btnLibrarianDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to Delete the Librarian !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    string librarianId = this.dgvLibrarian.CurrentRow.Cells[0].Value.ToString();
                    string librarianName = this.dgvLibrarian.CurrentRow.Cells["librarianname"].Value.ToString();


                    this.Sql = @"delete from librarianinfo
                                 where librarianid ='" + librarianId + "';";

                    string sql = @"delete from logininfo
                                   where id ='" + librarianId + "';";
                    DataAccess.ExecuteUpdateQuery(sql);
                    int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(librarianName + " has been deleted");
                    }
                    else
                    {
                        MessageBox.Show("Data deletion failed");
                    }

                    this.PopulateGridView("select * from librarianinfo;");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();

        }

        private void ClearAll()
        {
            //this.txtLibrarianId.Clear();
            this.txtPassword.Clear();
            this.dtpJoiningDate.Text = "";
            this.txtLibrarianName.Clear();
        }

        private void GenerateLibrarianId()
        {
            try
            {
                this.Sql = "select * from librarianinfo order by librarianid desc;";
                DataTable dt = DataAccess.ExecuteQueryTable(this.Sql);
                string id = dt.Rows[0]["librarianid"].ToString();
                string[] str = id.Split('a');
                int number = Convert.ToInt32(str[1]);
                string newId = "a" + (++number).ToString("d3");
                this.txtLibrarianId.Text = newId;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Generate Librarian Id\n" + exc.Message);
            }

        }
    }
}
