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
    public partial class LibrarianForm : Form
    {
        private LoginForm Frm { get; set; }
        public LibrarianForm()
        {
            InitializeComponent();
        }
        public LibrarianForm(LoginForm frm): this()
        {
            this.Frm = frm;
        }

        private void btnBookInfo_Click(object sender, EventArgs e)
        {
            bookUserControl1.Show();
            studentUserControl1.Hide();
            librarianUserControl11.Hide();

        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            bookUserControl1.Show();
            studentUserControl1.Hide();
            librarianUserControl11.Hide();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            studentUserControl1.Show();
            bookUserControl1.Hide();
            librarianUserControl11.Hide();
        }

        private void LibrarianForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLibrarianOperation_Click(object sender, EventArgs e)
        {
            studentUserControl1.Hide();
            bookUserControl1.Hide();
            librarianUserControl11.Show();
        }

        private void btnLibrarianLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are want to Log Out !", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                this.Frm.Show();
            }
            else
            {
                MessageBox.Show("LogOut is canceled");
            }
        }
    }
}
