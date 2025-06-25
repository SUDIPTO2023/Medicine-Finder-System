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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MedicineLocator.Model;
using MedicineLocator.Controller;

namespace MedicineLocator.View
{
    public partial class MedicineFullInformation : Form
    {
        Login currentUser;
        
        public MedicineFullInformation(Login client,string id, string name, string salt, string companyName, string price, string quantity, string type, string pharmacyName)
        {
            InitializeComponent();
            IdTextbox.Enabled = false;
            IdTextbox.Text = id;
            NameTextBox.Text = name;
            SaltTextBox.Text = salt;
            CompanyTextBox.Text = companyName;
            PriceTextBox.Text = price;
            TypeComboBox.Text = type;
            pharmacyTextBox.Text = pharmacyName;
            currentUser = client;


        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientMedicineSearchForm cmsf = new ClientMedicineSearchForm(currentUser);
            cmsf.Show();
        }
    }
}
 