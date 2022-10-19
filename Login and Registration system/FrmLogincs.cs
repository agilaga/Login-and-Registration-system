using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration_system
{
    public partial class FrmLogincs : Form
    {
        public FrmLogincs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Class.login1 && txtpassword.Text == Class.pass1)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == Class.login2 && txtpassword.Text == Class.pass2)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogincs_Load(object sender, EventArgs e)
        {

        }
    }
}
