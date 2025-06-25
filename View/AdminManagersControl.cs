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
    public partial class AdminManagersControl : Form
    {
        Login currentAdmin;
        public AdminManagersControl(Login adminId)
        {
            InitializeComponent();
            currentAdmin = adminId;
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
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string number =  validPhoneCheck(PhoneTextBox.Text);
                if (number!=null)
                {
                    string managerId = IdTextbox.Text;
                    string managerName = NameTextBox.Text;
                    int managerNumber = Convert.ToInt32(PhoneTextBox.Text);
                    string adminId = currentAdmin.User_Id;
                    Manager manager = new Manager(managerId, managerName, managerNumber, adminId);
                    ManagerController mc = new ManagerController();
                    mc.UpdateManager(manager);
                    MessageBox.Show("Manager Update Successfully");
                    BindingSource bs = new BindingSource();
                    bs.DataSource = mc.GetManagers(adminId);
                    dataGridView3.DataSource = bs;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string managerId = IdTextbox.Text;

                ManagerController mc = new ManagerController();
                mc.RemoveManager(managerId);
                MessageBox.Show("Remove a Manager Successfull");
                string adminId = currentAdmin.User_Id;
                BindingSource bs = new BindingSource();
                bs.DataSource = mc.GetManagers(adminId);
                dataGridView3.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }


        }
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string managerId = IdTextbox.Text;
                ManagerController mc = new ManagerController();
                Manager m = mc.SearchManager(managerId);
                if (m != null)
                {
                    IdTextbox.Text = m.M_Id;
                    NameTextBox.Text = m.M_Name;
                    PhoneTextBox.Text = Convert.ToString(m.M_Number);

                    MessageBox.Show("Manager Found");

                }
                else
                {
                    MessageBox.Show("Manager not found");
                }

                string adminId = currentAdmin.User_Id;

                BindingSource bs = new BindingSource();
                bs.DataSource = mc.GetManagers(adminId);
                dataGridView3.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            IdTextbox.Clear();
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            IdTextbox.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(currentAdmin);
            af.Show();
        }

        private void AdminManagersControl_Load(object sender, EventArgs e)
        {
            ManagerController mc = new ManagerController();
            string adminId = currentAdmin.User_Id;
            dataGridView3.DataSource = mc.GetManagers(adminId);
            dataGridView3.Refresh();

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgv = dataGridView3.Rows[e.RowIndex];

                IdTextbox.Text = dgv.Cells[0].Value.ToString();
                NameTextBox.Text = dgv.Cells[1].Value.ToString();
                PhoneTextBox.Text = dgv.Cells[2].Value.ToString();
                IdTextbox.Enabled = false;

            }
        }
    }
}
