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

namespace MedicineLocator.View
{
    public partial class ClientForm : Form
    {
        Login currentClient;
        public ClientForm(Login clientId)
        {
            InitializeComponent();
            currentClient = clientId;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientEditForm cef = new ClientEditForm(currentClient);
            cef.Show();

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientMedicineSearchForm cms = new ClientMedicineSearchForm(currentClient);
            cms.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
