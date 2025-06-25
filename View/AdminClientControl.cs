using MedicineLocator.Controller;
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
    public partial class AdminClientControl : Form
    {
        Login currentAdmin;
        public AdminClientControl(Login admin)
        {
            InitializeComponent();
            currentAdmin = admin;
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
                string number = validPhoneCheck(PhoneTextBox.Text);
                if (number!=null)
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
                    else
                    {
                        MessageBox.Show("Please Select");
                    }
                    int clientNumber = Convert.ToInt32(PhoneTextBox.Text);
                    string adminId = currentAdmin.User_Id;
                    Client client = new Client(clientId, clientName, gender, clientNumber, adminId);
                    ClientController cc = new ClientController();
                    cc.UpdateClient(client);
                    MessageBox.Show("Client Update Successfully");
                    BindingSource bs = new BindingSource();
                    bs.DataSource = cc.GetClients(adminId);
                    dataGridView6.DataSource = bs;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string clientId = IdTextbox.Text;

            ClientController cc = new ClientController();
            cc.RemoveClient(clientId);
            MessageBox.Show("Remove a Client Successfully");
            string adminId = currentAdmin.User_Id;
            BindingSource bs = new BindingSource();
            bs.DataSource = cc.GetClients(adminId);
            dataGridView6.DataSource = bs;
            IdTextbox.Clear();
            NameTextBox.Clear();
            PhoneTextBox.Clear();
            MaleRadioButton.Checked = false;
            FemalRadioButton.Checked = false;
            IdTextbox.Enabled = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string clientId = IdTextbox.Text;
                ClientController cc= new ClientController();
                Client c= cc.SearchClient(clientId);
                if (c != null)
                {
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
                    MessageBox.Show("CLient Found");


                }
            
                else
                {
                    MessageBox.Show("Client not found");
                }

                string adminId = currentAdmin.User_Id;

                BindingSource bs = new BindingSource();
                bs.DataSource = cc.GetClients(adminId);
                dataGridView6.DataSource = bs;
                IdTextbox.Enabled = false;
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
            MaleRadioButton.Checked = false;
            FemalRadioButton.Checked = false;
            IdTextbox.Enabled = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm af = new AdminForm(currentAdmin);
            af.Show();
        }

        private void AdminClientControl_Load(object sender, EventArgs e)
        {
            ClientController mc = new ClientController();
            string adminId = currentAdmin.User_Id;
            dataGridView6.DataSource = mc.GetClients(adminId);
            dataGridView6.Refresh();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgv = dataGridView6.Rows[e.RowIndex];

                IdTextbox.Text = dgv.Cells[0].Value.ToString();
                NameTextBox.Text = dgv.Cells[1].Value.ToString();
                string gender = dgv.Cells[2].Value.ToString();
                if (gender == "Male")
                {
                    MaleRadioButton.Checked = true;
                     
                }
                else if (gender == "Female")
                {
                    FemalRadioButton.Checked = true;
                    
                }

                PhoneTextBox.Text = dgv.Cells[3].Value.ToString();
                IdTextbox.Enabled = false;

            }
        }
    }
}
