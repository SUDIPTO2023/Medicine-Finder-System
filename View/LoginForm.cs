using MedicineLocator.Controller;
using MedicineLocator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MedicineLocator.Model;
using MedicineLocator.Controller;
using Microsoft.Data.SqlClient;

namespace MedicineLocator.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userId = idTextbox.Text;
            string password = passwordTextbox.Text;
            LoginController loginController = new LoginController();
            Login login = loginController.SearchLogin(userId, password);

            if (login != null)
            {
                if (login.User_Id.Equals(userId) && login.Password.Equals(password) && login.Role == 1)
                {
                    AdminForm adminForm = new AdminForm(login);
                    MessageBox.Show("Login Successfull");
                    this.Hide();
                    adminForm.Show();

                }
                else if (login.User_Id.Equals(userId) && login.Password.Equals(password) && login.Role == 2)
                {

                    ManagerForm mf = new ManagerForm(login);
                    MessageBox.Show("Manager Login Successfull");
                    this.Hide();
                    mf.Show();

                }
                else if (login.User_Id.Equals(userId) && login.Password.Equals(password) && login.Role == 3)
                {
                    ClientForm clientForm = new ClientForm(login);
                    MessageBox.Show("Client Login Successfull");
                    this.Hide();
                    clientForm.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Id or Password");
                }
            }
            else
            {
                MessageBox.Show("Invalid Id or Password Carefully Fill Up");
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

        private void ForgetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm fpf = new ForgotPasswordForm();
            fpf.Show();
        }
    }
}
