using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicineLocator.Model;
using MedicineLocator.Controller;
using System.Security;

namespace MedicineLocator.View
{
    public partial class ClientRegisterForm : Form
    {
        public ClientRegisterForm()
        {
            InitializeComponent();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
        public string GenerateClientId()
        {
            return "MFS-" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper() +"-C";
        }
        public string ValidEmailCheck(string email)
        {
            string mail = EmailTextBox.Text;
            if (! mail.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Enter A vailid Email");
                return null;

            }
            else
            {
                return mail;
            }
        }
        public string validPhoneCheck(string phoneNo)
        {
            string pn = PhoneTextBox.Text;
            if (pn.StartsWith("01")&&pn.Length==11&&pn.All(char.IsDigit))
            {
                return pn;
            }
            else
            {
                MessageBox.Show("Please Give a Valid phone Number");
                return null;
            }
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = validPhoneCheck(PhoneTextBox.Text);
                string email = ValidEmailCheck(EmailTextBox.Text);
                if (phoneNumber!=null && email!=null)
                {
                    string id = GenerateClientId();
                    IdTextbox.Text = id;
                    string adminId = "A-652023-25";

                    string name = NameTextBox.Text;
                    string gender = "";
                    if (MaleRadioButton.Checked)
                    {
                        gender = "Male";
                    }
                    else if (FemalRadioButton.Checked)
                    {
                        gender = "Female";
                    }
                    else
                    {
                        MessageBox.Show("Please Select One");
                    }

                    string securityAnswer = SecurityTextBox.Text;
                    string password = passwordTextbox.Text;
                    int role = 3;
                    int phoneNumberr = Convert.ToInt32(PhoneTextBox.Text);
                    Client client = new Client(id, name, gender, phoneNumberr, adminId);
                    Login login = new Login(id, email, role, securityAnswer, password);


                    ClientController clnc = new ClientController();
                    clnc.AddClient(client);
                    LoginController lgnc = new LoginController();
                    lgnc.AddLogin(login);
                    MessageBox.Show("Client Added Successfully");
                    MessageBox.Show("Your user Id Number: " + id);
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {



            if (passwordCheckBox.Checked == true)
            {
                passwordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextbox.UseSystemPasswordChar = true;
            }

        }

        private void ClientRegisterForm_Load(object sender, EventArgs e)
        {
            IdTextbox.Enabled = false;
        }
    }
}
