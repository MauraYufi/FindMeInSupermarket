using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMeInSupermarket
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(tbUsername.Text, tbPassword.Text);
            if (admin.Login(admin.LoginName, admin.Password))
            {
                if (rbTambah.Checked)
                {
                    this.Hide();
                    ProductInputForm prodForm1 = new ProductInputForm();
                    prodForm1.ShowDialog();
                    this.Close();
                }
                else if(rbHapus.Checked)
                {
                    this.Hide();
                    Form1 f1 = new Form1("Delete");
                    f1.ShowDialog();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Anda Bukan Admin, Dilarang Menambah Data!!!");
        }
    }
}
