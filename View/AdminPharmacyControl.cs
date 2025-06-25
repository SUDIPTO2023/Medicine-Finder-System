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
    public partial class AdminPharmacyControl : Form
    {
        Login currentAdmin;
        public AdminPharmacyControl(Login admin)
        {
            InitializeComponent();
            currentAdmin = admin;
        }

        private void AdminPharmacyControl_Load(object sender, EventArgs e)
        {
            PharmacyController pc = new PharmacyController();
            string adminId = currentAdmin.User_Id;
            dataGridView4.DataSource = pc.GetPharmacy(adminId);
            dataGridView4.Refresh();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgv = dataGridView4.Rows[e.RowIndex];

                IdTextbox.Text = dgv.Cells[0].Value.ToString();
                NameTextBox.Text = dgv.Cells[1].Value.ToString();
                LocationTextBox.Text = dgv.Cells[2].Value.ToString();
                LisenceTextBox.Text = dgv.Cells[3].Value.ToString();
                ManagerTextIBoxId.Text = dgv.Cells[4].Value.ToString();
                IdTextbox.Enabled = false;
                ManagerTextIBoxId.Enabled = false;

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string pharmacyId = IdTextbox.Text;
                string pharmacyName = NameTextBox.Text;
                string location = LocationTextBox.Text;
                string lisenceNumber = LisenceTextBox.Text;
                string managerId = ManagerTextIBoxId.Text;
                Pharmacy pharmacy = new Pharmacy(pharmacyId, pharmacyName, location, lisenceNumber, managerId);
                PharmacyController pc = new PharmacyController();
                pc.UpdatePharmacy(pharmacy);
                MessageBox.Show("Pharmacy Update Successfully");
                BindingSource bs = new BindingSource();
                bs.DataSource = pc.GetPharmacy(currentAdmin.User_Id);
                dataGridView4.DataSource = bs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string pharmacyId = IdTextbox.Text;
                PharmacyController pc = new PharmacyController();
                pc.RemovePharmacy(pharmacyId);
                MessageBox.Show("Pharmacy Remove Successfully");
                string adminId = currentAdmin.User_Id;
                BindingSource bs = new BindingSource();
                bs.DataSource = pc.GetPharmacy(adminId);
                dataGridView4.DataSource = bs;
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
                string pharmacyId = IdTextbox.Text;
                PharmacyController pc = new PharmacyController();
                Pharmacy p = pc.SearchPharmacy(pharmacyId);
                if (p!= null)
                {
                    IdTextbox.Text = p.P_Id;
                    NameTextBox.Text = p.P_Name;
                    LocationTextBox.Text = p.Location;
                    LisenceTextBox.Text = p.LisenceNumber;
                    ManagerTextIBoxId.Text = p.M_Id;
                    
                    MessageBox.Show("Pharmacy Found");

                }
                else
                {
                    MessageBox.Show("Pharmacy not found");
                }

                string adminId = currentAdmin.User_Id;
                 
                BindingSource bs = new BindingSource();
                bs.DataSource = pc.GetPharmacy(adminId);
                dataGridView4.DataSource = bs;
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
            LocationTextBox.Clear();
            LisenceTextBox.Clear();
            ManagerTextIBoxId.Clear();
            IdTextbox.Enabled = true;
            ManagerTextIBoxId.Enabled = true;
            

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(currentAdmin);
            af.Show();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
