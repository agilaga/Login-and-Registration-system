using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Registration_system
{
    public partial class Form1 : Form
    {
        private string captcha = "";
        private Random random = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtpassword.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Registration failed" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsername.Text == Class.login1 || txtUsername.Text == Class.login2)
            {
                MessageBox.Show("Account with this username has already created! ,Please, choose another username", "Registration failed", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else if ((txtpassword.Text == txtConPassword.Text) && txtUsername.Text != Class.login1)
            {

                Class.login2 = txtUsername.Text;
                Class.pass2 = txtpassword.Text;



                txtUsername.Text = "";
                txtpassword.Text = "";
                txtConPassword.Text = "";

                MessageBox.Show("Your account has successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords are not match", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtConPassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtConPassword.Text = "";
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmLogincs f = new FrmLogincs();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}