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

namespace MedicineLocator.View
{
    public partial class ManaagerEditForm : Form
    {
        Login currentManager;
        public ManaagerEditForm(Login manager)
        {
            InitializeComponent();
            currentManager = manager;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm mf = new ManagerForm(currentManager);
            mf.Show();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                MessageBox.Show("Please Give a Valid phone Number");
                return null;
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                string number = validPhoneCheck(PhoneTextBox.Text);
                if(number!=null)
                {
                    string managerId = IdTextbox.Text;
                    string managerName = NameTextBox.Text;
                    int managerNumber = Convert.ToInt32(PhoneTextBox.Text);
                    string adminId = "A-25";
                    Manager manager = new Manager(managerId, managerName, managerNumber, adminId);
                    ManagerController mc = new ManagerController();
                    mc.UpdateManager(manager);
                    MessageBox.Show("Well " + managerName + " Your Information Successfully Updated");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

        }

        private void ManaagerEditForm_Load(object sender, EventArgs e)
        {
            string currentManagerId = currentManager.User_Id;
            ManagerController mc = new ManagerController();
            Manager manager = mc.GetManagerByUserId(currentManagerId);

            IdTextbox.Text = manager.M_Id;
            NameTextBox.Text = manager.M_Name;
            PhoneTextBox.Text = Convert.ToString(manager.M_Number);
            IdTextbox.Enabled = false;
            MessageBox.Show("Welcome: " +manager.M_Name);
        }
    }
}
