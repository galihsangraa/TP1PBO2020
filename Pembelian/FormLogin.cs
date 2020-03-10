using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembelian
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = tbuname.Text;
            string password = tbpass.Text;

            user.Username = Convert.ToString(username);
            user.Password = Convert.ToString(password);

            if (username.Trim() == string.Empty || password.Trim() == string.Empty)
            {
                MessageBox.Show("Harap isi Username/Password");
            }
            else
            {
                if (password == "pbo123")
                {
                    FormHome FormHome = new FormHome();
                    FormHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Maaf Password Salah");
                }
            }
        }
    }
}
