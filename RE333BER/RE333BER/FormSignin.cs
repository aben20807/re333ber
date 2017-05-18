using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RE333BER
{
    public partial class FormSignin : Form
    {
        //public FormUser formUser;
        //public FormSupervisor formSupervisor;
        //public FormSignup formSignup;
        const string SUPERVISOR_USERNAME = "ADMIN";
        const string SUPERVISOR_PASSWORD = "0000";
        public FormSignin()
        {
            InitializeComponent();
        }
        private void FormSignin_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            //button init
            Image imgSignup = Image.FromFile("../../pic/btn/btn_signUp.png");
            btnSignup.Text = "";
            btnSignup.Image = imgSignup;
            btnSignup.Height = imgSignup.Height + 4;
            btnSignup.Width = imgSignup.Width + 4;
            btnSignup.Cursor = Cursors.Hand;

            Image imgSignin = Image.FromFile("../../pic/btn/btn_signIn.png");
            btnSignin.Text = "";
            btnSignin.Image = imgSignin;
            btnSignin.Height = imgSignin.Height + 4;
            btnSignin.Width = imgSignin.Width + 4;
            btnSignin.Cursor = Cursors.Hand;

            btnCancel.Cursor = Cursors.Hand;
            //textbox init
            textboxUsername.Text = "username";
            textboxUsername.ForeColor = Color.Gray;

            textboxPassword.Text = "password";
            textboxPassword.ForeColor = Color.Gray;
            textboxPassword.UseSystemPasswordChar = false;
            //member data init
            Member.memberData.Add(new Member("TOM", "123"));
            Member.memberData.Add(new Member("BEN", "456"));
            Member.memberData.Add(new Member("EVA", "789"));
        }

        private void textboxUsername_Leave(object sender, EventArgs e)
        {
            if (textboxUsername.Text == "")
            {
                textboxUsername.Text = "username";
                textboxUsername.ForeColor = Color.Gray;
            }
        }

        private void textboxUsername_Enter(object sender, EventArgs e)
        {
            if (textboxUsername.Text == "username")
            {
                textboxUsername.Text = "";
                textboxUsername.ForeColor = Color.Black;
            }
        }

        private void textboxPassword_Leave(object sender, EventArgs e)
        {
            if (textboxPassword.Text == "")
            {
                textboxPassword.Text = "password";
                textboxPassword.ForeColor = Color.Gray;
                textboxPassword.UseSystemPasswordChar = false;
            }
        }

        private void textboxPassword_Enter(object sender, EventArgs e)
        {
            if (textboxPassword.Text == "password")
            {
                textboxPassword.Text = "";
                textboxPassword.ForeColor = Color.Black;
                textboxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            signin();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //formSignup = new FormSignup(this);
            //formSignup.Show();
            this.Hide();
        }

        private void FormSignin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit this program
            Application.Exit();
            Environment.Exit(0);
        }

        private void FormSignin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }
        private void textboxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }

        private void textboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signin();
            }
        }

        private void signin()
        {
            if (textboxUsername.Text == SUPERVISOR_USERNAME && textboxPassword.Text == SUPERVISOR_PASSWORD)
            {//sign in as supervisor
                //Member.signinMember = null;
                textboxPassword.Text = "password";
                textboxPassword.ForeColor = Color.Gray;
                textboxPassword.UseSystemPasswordChar = false;
                textboxUsername.Text = "username";
                textboxUsername.ForeColor = Color.Gray;
                //open form to manage
                //formSupervisor = new FormSupervisor(this);
                //formSupervisor.Show();
                this.Hide();
            }
            else
            {
                bool isFind = false;
                foreach (Member i in Member.memberData)
                {//find member
                    if (i.Username == textboxUsername.Text && i.Password == Member.hashSHA512(textboxPassword.Text))
                    {
                        //textBox init
                        isFind = true;
                        Member.signinMember = i;
                        textboxPassword.Text = "password";
                        textboxPassword.ForeColor = Color.Gray;
                        textboxPassword.UseSystemPasswordChar = false;
                        textboxUsername.Text = "username";
                        textboxUsername.ForeColor = Color.Gray;
                        //open form to book film
                        //formUser = new FormUser(this);
                        //formUser.Show();
                        //this.Hide();
                        MessageBox.Show("Sign in success");
                    }
                }
                if (isFind == false)
                {
                    MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
