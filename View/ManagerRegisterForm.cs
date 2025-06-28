using MedicineLocator.Controller;
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

namespace MedicineLocator.View
{
    public partial class ManagerRegisterForm : Form
    {
        public ManagerRegisterForm()
        {
            InitializeComponent();
        }

        private void SecurityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
        public string GenerateManagerId()
        {
            return "MFS-" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper() +"-M";
        }
        public string GeneratePharmacyId()
        {
            return "MFS-" + Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper() +"-P";
        }
        public string ValidEmailCheck(string email)
        {
            string mail = EmailTextBox.Text;
            if (!mail.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Please fill up your information and give valid email");
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
            if (pn.StartsWith("01") && pn.Length == 11 && pn.All(char.IsDigit))
            {
                return pn;
            }
            else
            {
                MessageBox.Show("Please fill up your information and give valid phonenumber");
                return null;
            }
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {

            string phoneNumber = validPhoneCheck(PhoneTextBox.Text);
            string email = ValidEmailCheck(EmailTextBox.Text);
            try
            {
                if (phoneNumber != null && email != null)
                {
                    string managerId = GenerateManagerId();
                    IdTextbox.Text = managerId;

                    string managerName = NameTextBox.Text;
                    int managerNumber = Convert.ToInt32(PhoneTextBox.Text);
                    string adminId = "A-25";
                    int role = 2;

                    string pharmacyId = GeneratePharmacyId();
                    PharmacyTextBox.Text = pharmacyId;
                    string pharmacyName = PharmacyNameTextBox.Text;
                    string location = LocationTextBox.Text;
                    string lisenceNumber = LisenceTextBox.Text;
                    email = EmailTextBox.Text;
                    string securityAnswer = SecurityTextBox.Text;
                    string password = passwordTextbox.Text;

                    Manager manager = new Manager(managerId, managerName, managerNumber, adminId);
                    Login login = new Login(managerId, email, role, securityAnswer, password);
                    Pharmacy pharmacy = new Pharmacy(pharmacyId, pharmacyName, location, lisenceNumber, managerId);

                    ManagerController mc = new ManagerController();
                    mc.AddManager(manager);
                    LoginController lgnc = new LoginController();
                    lgnc.AddLogin(login);
                    PharmacyController pc = new PharmacyController();
                    pc.AddPharmacy(pharmacy);
                    MessageBox.Show("Manager Added Successfull");
                    MessageBox.Show("Your Id number:" + managerId);
                    MessageBox.Show("Pharmacy Id number: " + pharmacyId);

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

        private void ManagerRegisterForm_Load(object sender, EventArgs e)
        {
            IdTextbox.Enabled = false;
            PharmacyTextBox.Enabled = false;
        }
    }
}
