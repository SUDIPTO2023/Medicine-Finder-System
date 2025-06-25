using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MedicineLocator.Model
{
   public  class Manager
    {
        private string m_Id;
        private string m_Name;
        private int m_Number;
        
        private string a_Id;
        public Manager()
        {

        }

        public Manager(string m_Id, string m_Name, int m_Number,  string a_Id)
        {
            this.m_Id = m_Id;
            this.m_Name = m_Name;
            this.m_Number = m_Number;
             
            this.A_Id = a_Id;
        }
        
        public string M_Id { get => m_Id; set => m_Id = value; }
        public string M_Name { get => m_Name; set => m_Name = value; }
        public int M_Number { get => m_Number; set => m_Number = value; }
         
        public string A_Id { get => a_Id; set => a_Id = value; }
   }
}
