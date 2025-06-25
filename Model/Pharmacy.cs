using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
    public class Pharmacy
    {
        private string p_Id;
        private string p_Name;
        private string location;
        private string lisenceNumber;
        private string m_Id;
        public Pharmacy()
        {

        }
        public Pharmacy(string p_Id, string p_Name, string location, string lisenceNumber, string m_id)
        {
            this.P_Id = p_Id;
            this.P_Name = p_Name;
            this.Location = location;
            this.LisenceNumber = lisenceNumber;
            this.m_Id = m_id;
        }

        public string P_Id { get => p_Id; set => p_Id = value; }
        public string P_Name { get => p_Name; set => p_Name = value; }
        public string Location { get => location; set => location = value; }
        public string LisenceNumber { get => lisenceNumber; set => lisenceNumber = value; }
        public string M_Id { get => m_Id; set => m_Id = value; }
    }
}
