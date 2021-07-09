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
    public partial class StudentUserControl : UserControl
    {
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public StudentUserControl()
        {
            InitializeComponent();
            string sql = "select * from studentinfo;";
            this.PopulateGridView(sql);
            this.GenerateStudentId();
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = DataAccess.ExecuteQuery(sql);

            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.DataSource = this.Ds.Tables[0];

        }

        private void txtStudentSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.Sql = "select * from studentinfo where CONCAT(studentid,studentname,sdepartment,joiningdate) like '%" + this.txtStudentSearch.Text + "%';";
                this.PopulateGridView(this.Sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Search Book\n" + exc.Message);
            }
        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {
            try
            {
            this.Sql = "select * from studentinfo where studentid='" + this.txtStudentId.Text + "';";
            this.Ds = DataAccess.ExecuteQuery(this.Sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                if (this.txtStudentId.Text != "" &&this.txtStudentName.Text != "" && this.cbDepartment.Text != "")
                {

                    this.Sql = @"update studentinfo 
                           set studentname='" + this.txtStudentName.Text + @"',
                           sdepartment ='" + this.cbDepartment.Text + @"',
                           joiningdate='" + this.dtpJoiningDate.Text + @"'
                           where studentid='" + this.txtStudentId.Text + "';";
                    int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data updated");
                        string sql = "select * from studentinfo;";
                        this.PopulateGridView(sql);
                        this.GenerateStudentId();
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
                if (this.txtStudentId.Text != "" && this.txtPassword.Text != "" && this.txtStudentName.Text != "" && this.cbDepartment.Text != "")
                {
                    this.Sql = @"insert into studentinfo
                             values ('" + this.txtStudentId.Text + "','" + this.txtStudentName.Text + "','" + this.cbDepartment.Text + "','" + this.dtpJoiningDate.Text + "');";

                    string sql = @"insert into logininfo
                             values ('" + this.txtStudentId.Text + "','student','" + this.txtPassword.Text + "');";
                    DataAccess.ExecuteUpdateQuery(sql);
                    int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Data added properly");
                        this.GenerateStudentId();
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

            this.PopulateGridView("select * from studentinfo;");
            this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during saving the data\n\n" + exc.Message);
            }
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            this.txtStudentId.Text = this.dgvStudent.CurrentRow.Cells["studentid"].Value.ToString();
            this.txtStudentName.Text = this.dgvStudent.CurrentRow.Cells["studentname"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvStudent.CurrentRow.Cells["joiningdate"].Value.ToString();
            this.cbDepartment.Text = this.dgvStudent.CurrentRow.Cells["sdepartment"].Value.ToString();
           
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to Delete the Student !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    string studentId = this.dgvStudent.CurrentRow.Cells[0].Value.ToString();
                    string studentName = this.dgvStudent.CurrentRow.Cells["studentname"].Value.ToString();


                    this.Sql = @"delete from studentinfo
                                 where studentid ='"+studentId+"';";

                    string sql = @"delete from logininfo
                                   where id ='" +studentId+ "';";
                    DataAccess.ExecuteUpdateQuery(sql);
                    int count = DataAccess.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(studentName + " has been deleted");
                    }
                    else
                    {
                        MessageBox.Show("Data deletion failed");
                    }

                    this.PopulateGridView("select * from studentinfo;");
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
            //this.txtStudentId.Clear();
            this.txtPassword.Clear();
            this.txtStudentName.Clear();
            this.cbDepartment.Text="";
            this.dtpJoiningDate.Text = "";
        }


        private void GenerateStudentId()
        {
            try
            {
                this.Sql = "select * from studentinfo order by studentid desc;";
                DataTable dt = DataAccess.ExecuteQueryTable(this.Sql);
                string id = dt.Rows[0]["studentid"].ToString();
                string[] str = id.Split('s');
                int number = Convert.ToInt32(str[1]);
                string newId = "s" + (++number).ToString("d3");
                this.txtStudentId.Text = newId;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Generate Student Id\n" + exc.Message);
            }

        }


    }
}
