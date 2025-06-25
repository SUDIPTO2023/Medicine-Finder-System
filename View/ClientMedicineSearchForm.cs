using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicineLocator.Controller;
using MedicineLocator.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicineLocator.View
{
    public partial class ClientMedicineSearchForm : Form
    {
        Login currentClient;
        public ClientMedicineSearchForm(Login client)
        {
            InitializeComponent();
            currentClient = client;
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string medicineName = NameTextbox.Text.Trim();
                string location = LocationComboBox1.Text.Trim();

                MedicineController mc = new MedicineController();
                List<Medicine> m = mc.GetMedicineByNameAndLocation(medicineName, location);
                if (m.Count > 0)
                {
                    MessageBox.Show("Medicine Found");
                    BindingSource bs = new BindingSource();
                    bs.DataSource = mc.GetMedicineByNameAndLocation(medicineName, location);
                    dataGridView5.DataSource = bs;
                    dataGridView5.Columns[5].Visible = false;
                }
                else
                {
                    MessageBox.Show("Medicine Not Found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }


        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgv = dataGridView5.Rows[e.RowIndex];
 
                string medicneId = dgv.Cells[0].Value.ToString();
                string medicineName= dgv.Cells[1].Value.ToString();
                string salt = dgv.Cells[2].Value.ToString();
                string companyName = dgv.Cells[3].Value.ToString();
                string price= dgv.Cells[4].Value.ToString();
                string quantity = dgv.Cells[5].Value.ToString();
                string type = dgv.Cells[6].Value.ToString();
                string pharmacyName = dgv.Cells[8].Value.ToString();
                this.Hide();
                
                
                MedicineFullInformation mfinf= new  MedicineFullInformation(currentClient,medicneId, medicineName, salt, companyName, price, quantity, type, pharmacyName);
                mfinf.Show();
                
            }
        }
    }
}
