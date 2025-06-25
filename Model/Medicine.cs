using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
    public class Medicine
    {
        private string me_Id;
        private string me_Name;
        private string salt;
        private string company;
        private int price;
        private int quantity;
        private string type;
        private string p_Id;
        private string p_Name;
        public Medicine()
        {

        }

        public Medicine(string me_Id, string me_Name, string salt, string company, int price, int quantity, string type, string p_Id)
        {
            this.Me_Id = me_Id;
            this.Me_Name = me_Name;
            this.Salt = salt;
            this.Company = company;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
            this.P_Id = p_Id;
        }

        public string Me_Id { get => me_Id; set => me_Id = value; }
        public string Me_Name { get => me_Name; set => me_Name = value; }
        public string Salt { get => salt; set => salt = value; }
        public string Company { get => company; set => company = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Type { get => type; set => type = value; }
        public string P_Id { get => p_Id; set => p_Id = value; }
        public string P_Name { get => p_Name; set => p_Name = value; }
    }
}
