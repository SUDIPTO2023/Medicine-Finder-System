using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
   public  class Admin
    {
        private string a_Id;
        private string a_Name;
        private int a_Number;
        public Admin()
        {

        }

        public Admin(string a_Id, string a_Name, int a_Number)
        {
            this.A_Id = a_Id;
            this.A_Name = a_Name;
            this.A_Number = a_Number;
        }

        public string A_Id { get => a_Id; set => a_Id = value; }
        public string A_Name { get => a_Name; set => a_Name = value; }
        public int A_Number { get => a_Number; set => a_Number = value; }
    }
}
