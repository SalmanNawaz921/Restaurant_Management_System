using Restaurant_Mangement_System.BL;
using Restaurant_Mangement_System.Win_Forms.Cashier_Forms;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();

        }

        private void lil_signUP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frm_signup signup = new frm_signup();
            signup.FormClosed += (s, args) => this.Close();
            signup.Show();
        }

        private void btn_login_Click(object sender, System.EventArgs e)
        {
            string name = txt_name.Text;
            string password = txt_pass.Text;

            Credentials creds = new Credentials(name, password);
            string role = Credentials.validUser(creds);
            if (name == "" || password == "")
            {
                MessageBox.Show("Fill The Details");
            }
            else if (role.ToUpper() == "MANAGER")
            {
                ShowManagerForm(name);
            }
            else if (role.ToUpper() == "CASHIER")
            {
                ShowCashierForm(name);
            }
            else
            {
                MessageBox.Show("User Not Exists");

            }

        }

        private void pB_Eye_Click(object sender, System.EventArgs e)
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

        private void ShowManagerForm(string name)
        {
            this.Hide();
            frm_Manager manager = new frm_Manager(name);
            manager.FormClosed += (s, args) => this.Close();
            manager.Show();
        }

        private void ShowCashierForm(string name)
        {
            this.Hide();
            frm_Cashier cashier = new frm_Cashier(name);
            cashier.FormClosed += (s, args) => this.Close();
            cashier.Show();
        }
    }
}
