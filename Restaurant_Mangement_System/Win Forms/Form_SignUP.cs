using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.DL;
using System;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    public partial class frm_signup : Form
    {
        public frm_signup()
        {
            InitializeComponent();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_pass.Text;
            string role = txt_role.Text;
            Credentials newUser = new Credentials(name, password, role);
            bool flag = CredentialsDL.addUser(newUser, Program.path4);

            if (name == "" || password == "" || role == "")
            {

                MessageBox.Show("Fill Your Details");
            }
            else if (role.ToUpper() != "CASHIER" || role.ToUpper() != "MANAGER")
            {
                MessageBox.Show("Wrong Credentials");
            }
            else if (flag == true)
            {
                MessageBox.Show("User Added");
                this.Close();
            }

            else
            {
                MessageBox.Show("User Already Exists");
            }
        }


        private void lil_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_login login = new frm_login();
            login.FormClosed += (s, args) => this.Close(); // Close the signup form when login form is closed
            login.Show();

        }


        private void frm_signup_Load(object sender, EventArgs e)
        {

        }
        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.integerValidation(e);
        }


        private void pB_Eye_Click(object sender, EventArgs e)
        {
            char passCharacter = txt_pass.PasswordChar;
            if (passCharacter == '*')
            {
                txt_pass.PasswordChar = '\0';
                pB_Eye.Image = Properties.Resources.eye;
            }
            else
            {
                txt_pass.PasswordChar = '*';
                pB_Eye.Image = Properties.Resources.hidden;

            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.stringValidation(e);
        }
    }
}
