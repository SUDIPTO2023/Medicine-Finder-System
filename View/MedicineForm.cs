using MedicineLocator.Controller;
using MedicineLocator.Model;
using Microsoft.Data.SqlClient;
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
    public partial class MedicineForm : Form
    {
        Login currentManager;
        public MedicineForm(Login manager)
        {
            InitializeComponent();
            currentManager = manager;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string medicine_Id = IdTextbox.Text;
                string medicineName = NameTextBox.Text;
                string salt = SaltTextBox.Text;
                string company = CompanyTextBox.Text;
                int price = Convert.ToInt32(PriceTextBox.Text);
                int quantity = Convert.ToInt32(QuantityTextBox.Text);
                string medicineType = "";
                string managerId = currentManager.User_Id;
                PharmacyController pc = new PharmacyController();
                string managerPharmacyId = pc.GetPharmacyIdByManagerId(managerId);

                if (TypeComboBox.Text == "Tablet")
                {
                    medicineType = "Tablet";
                }
                else if (TypeComboBox.Text == "Capsule")
                {
                    medicineType = "Capsule";
                }
                else if (TypeComboBox.Text == "Syrup")
                {
                    medicineType = "Syrup";
                }
                else
                {
                    MessageBox.Show("Please Select One");
                }
                MedicineController mc = new MedicineController();
                Medicine medicine = new Medicine(medicine_Id, medicineName, salt, company, price, quantity, medicineType, managerPharmacyId);

                mc.AddMedicine(medicine);
                MessageBox.Show("Medicine Added Successfully");
                MessageBox.Show("Thank you " + managerPharmacyId);
                BindingSource bs = new BindingSource();
                bs.DataSource = mc.GetMedicine(managerPharmacyId);
                dataGridView1.DataSource = bs;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Please fill up carefully");
            }
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string medicine_Id = IdTextbox.Text;
                string medicineName = NameTextBox.Text;
                string salt = SaltTextBox.Text;
                string company = CompanyTextBox.Text;
                int price = Convert.ToInt32(PriceTextBox.Text);
                int quantity = Convert.ToInt32(QuantityTextBox.Text);
                string medicineType = "";
                string managerId = currentManager.User_Id;
                PharmacyController pc = new PharmacyController();
                string managerPharmacyId = pc.GetPharmacyIdByManagerId(managerId);

                if (TypeComboBox.Text == "Tablet")
                {
                    medicineType = "Tablet";
                }
                else if (TypeComboBox.Text == "Capsule")
                {
                    medicineType = "Capsule";
                }
                else if (TypeComboBox.Text == "Syrup")
                {
                    medicineType = "Syrup";
                }
                else
                {
                    MessageBox.Show("Please Select One");
                }
                MedicineController mc = new MedicineController();
                Medicine medicine = new Medicine(medicine_Id, medicineName, salt, company, price, quantity, medicineType, managerPharmacyId);
                
                mc.UpdateMedicine(medicine);
                MessageBox.Show("Medicine Update Successfully");

                BindingSource bs = new BindingSource();
                bs.DataSource = mc.GetMedicine(managerPharmacyId);
                dataGridView1.DataSource = bs;



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
            SaltTextBox.Clear();
            CompanyTextBox.Clear();
            PriceTextBox.Clear();
            QuantityTextBox.Clear();
            TypeComboBox.Text = null;
            IdTextbox.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];

                IdTextbox.Text = dgv.Cells[0].Value.ToString();
                NameTextBox.Text = dgv.Cells[1].Value.ToString();
                SaltTextBox.Text = dgv.Cells[2].Value.ToString();
                CompanyTextBox.Text = dgv.Cells[3].Value.ToString();
                PriceTextBox.Text = dgv.Cells[4].Value.ToString();
                QuantityTextBox.Text = dgv.Cells[5].Value.ToString();
                TypeComboBox.Text = dgv.Cells[6].Value.ToString();
                IdTextbox.Enabled = false;

            }

        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {


            string managerId = currentManager.User_Id;
            PharmacyController pc = new PharmacyController();
            string managerPharmacyId = pc.GetPharmacyIdByManagerId(managerId);



            MedicineController mc = new MedicineController();

            
            //dataGridView1.AutoGenerateColumns = false;

            dataGridView1.DataSource = mc.GetMedicine(managerPharmacyId);
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Refresh();



        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string medicineId = IdTextbox.Text;
                MedicineController mc = new MedicineController();
                mc.RemoveMedicine(medicineId);
                MessageBox.Show("Remove Successfully");
                string managerId = currentManager.User_Id;
                PharmacyController pc = new PharmacyController();
                string managerPharmacyId = pc.GetPharmacyIdByManagerId(managerId);
                BindingSource bs = new BindingSource();
                bs.DataSource = mc.GetMedicine(managerPharmacyId);
                dataGridView1.DataSource = bs;
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
                string medicineId = IdTextbox.Text;
                MedicineController mc = new MedicineController();
                Medicine m = mc.SearchMedicine(medicineId);
                if (m != null)
                {
                    IdTextbox.Text = m.Me_Id;
                    NameTextBox.Text = m.Me_Name;
                    SaltTextBox.Text = m.Salt;
                    CompanyTextBox.Text = m.Company;
                    PriceTextBox.Text = Convert.ToString(m.Price);
                    QuantityTextBox.Text = Convert.ToString(m.Quantity);
                    TypeComboBox.Text = m.Type;
                    MessageBox.Show("Medcine Found");

                }
                else
                {
                    MessageBox.Show("Medicine not found");
                }

                string managerId = currentManager.User_Id;
                PharmacyController pc = new PharmacyController();
                string managerPharmacyId = pc.GetPharmacyIdByManagerId(managerId);
                BindingSource bs = new BindingSource();
                bs.DataSource = mc.GetMedicine(managerPharmacyId);
                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm mf = new ManagerForm(currentManager);
            mf.Show();
        }
    }
}
