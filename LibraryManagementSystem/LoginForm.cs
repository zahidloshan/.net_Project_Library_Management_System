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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from logininfo where id='" + this.txtUserId.Text + "' and password='" + this.txtPassword.Text + "';";

                DataSet ds = DataAccess.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    if (ds.Tables[0].Rows[0][1].ToString() == "student")
                    {
                        MessageBox.Show("Login approved for student");
                        StudentForm sf = new StudentForm(this.txtUserId.Text,this);
                        sf.Visible = true;
                        this.Visible = false;
                    }
                    else if (ds.Tables[0].Rows[0][1].ToString() == "librarian")
                    {
                        MessageBox.Show("Login approved for librarian");
                        LibrarianForm lf = new LibrarianForm(this);
                        lf.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Login Invalid");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during Login\n" + exc.Message);
            }
        }
        

    }
}
