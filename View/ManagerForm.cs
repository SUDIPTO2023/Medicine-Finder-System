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
    public partial class ManagerForm : Form
    {
        Login currentManager;
        public ManagerForm(Login manager)
        {
            InitializeComponent();
            currentManager = manager;
        }



        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManaagerEditForm mef = new ManaagerEditForm(currentManager);
            mef.Show();
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MedicineForm mf = new MedicineForm(currentManager);
            mf.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
