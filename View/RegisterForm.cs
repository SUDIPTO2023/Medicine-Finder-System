using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineLocator.View
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterAccountLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserListCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
             
             
            if (UserListCombobox.Text=="Client")
            {
                ClientRegisterForm clientRegisterform = new ClientRegisterForm();
                this.Hide();
                clientRegisterform.Show();
                
            }
            else if(UserListCombobox.Text=="Manager")
            {
                ManagerRegisterForm managerRegistrationForm = new ManagerRegisterForm();
                this.Hide();
                managerRegistrationForm.Show();
            }
            else
            {
                MessageBox.Show("Please select");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
