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
    public partial class FormHome : Form
    {
        FormBeli formBeli = new FormBeli();
        User user = new User();
        public FormHome()
        {
            {
                InitializeComponent();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formBeli.TopLevel = false;
            Controls.Add(formBeli);
            formBeli.Show();
        }
    }
}
