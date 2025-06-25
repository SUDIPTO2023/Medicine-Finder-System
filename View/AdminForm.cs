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
    public partial class AdminForm : Form
    {
        Login currentadmin;
        public AdminForm(Login admin)
        {
            InitializeComponent();
            currentadmin = admin;

        }




        private void ManagerListLable_Click(object sender, EventArgs e)
        {
            ManagerController mc = new ManagerController();
            dataGridView2.DataSource = mc.GetAllManager();
            dataGridView2.Refresh();

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PharmacyListLabel_Click(object sender, EventArgs e)
        {
            PharmacyController pc = new PharmacyController();
            dataGridView2.DataSource = pc.GetAllPharmacy();
            dataGridView2.Refresh();
        }

        private void ClientLIstLabel_Click(object sender, EventArgs e)
        {
            ClientController cc = new ClientController();
            dataGridView2.DataSource = cc.GetAllCLient();
            dataGridView2.Refresh();
        }

        private void ManagerManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManagersControl amc = new AdminManagersControl(currentadmin);
            amc.Show();


        }

        private void PharmacyManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPharmacyControl apc = new AdminPharmacyControl(currentadmin);
            apc.Show();
        }

        private void ClientManagementButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminClientControl ac = new AdminClientControl(currentadmin);
            ac.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
        }
    }
}
