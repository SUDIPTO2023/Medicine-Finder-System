using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
   public  class Client
   {
        private string c_Id;
        private string c_Name;
        private string gender;
        private int c_Number;
        private string a_Id;

        public  Client()
        {

        }
         

        public Client(string c_Id, string c_Name, string gender, int c_Number, string a_Id)
        {
            this.c_Id = c_Id;
            this.c_Name = c_Name;
            this.gender = gender;
            this.c_Number = c_Number;
            this.a_Id = a_Id;
        }

        
        public string C_Id { get => c_Id; set => c_Id = value; }
        public string C_Name { get => c_Name; set => c_Name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int C_Number { get => c_Number; set => c_Number = value; }
        public string A_Id { get => a_Id; set => a_Id = value; }
    }
}
