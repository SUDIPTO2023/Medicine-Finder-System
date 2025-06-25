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
using MedicineLocator.Model;
using MedicineLocator.Controller;

namespace MedicineLocator.View
{
    public partial class ClientEditForm : Form
    {
        Login currentClient;
        
        public ClientEditForm(Login ClientId)
        {
            InitializeComponent();
            currentClient = ClientId;

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm cf = new ClientForm(currentClient);
            cf.Show();
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
                string clientNumber = validPhoneCheck(PhoneTextBox.Text);
                if(clientNumber!=null)
                {
                    string clientId = IdTextbox.Text;
                    string clientName = NameTextBox.Text;
                    string gender = "";

                    if (MaleRadioButton.Checked)
                    {
                        gender = MaleRadioButton.Text;
                    }
                    else if (FemalRadioButton.Checked)
                    {
                        gender = FemalRadioButton.Text;
                    }
                    int number = Convert.ToInt32(PhoneTextBox.Text);
                    string adminId = "A-652023-25";
                    Client client = new Client(clientId, clientName, gender, number, adminId);
                    ClientController cc = new ClientController();
                    cc.UpdateClient(client);
                    MessageBox.Show("Well " + clientName + " Your Information Updated Successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void ClientEditForm_Load(object sender, EventArgs e)
        {
            string currentClientId = currentClient.User_Id;
            ClientController cc = new ClientController();
            Client c = cc.GetClientFromUserId(currentClientId);
           
            IdTextbox.Text = c.C_Id;
            NameTextBox.Text = c.C_Name;
           
            if (c.Gender == "Male")
            {
                MaleRadioButton.Checked = true;
            }
            else if (c.Gender == "Female")
            {
                 FemalRadioButton.Checked = true;
            }
            PhoneTextBox.Text = Convert.ToString(c.C_Number);
            IdTextbox.Enabled = false;
            MessageBox.Show("Welcome: " + c.C_Name);
        }
    }
}
