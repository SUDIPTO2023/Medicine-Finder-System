using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
    public class MedicinePurchase
    {
        private string bill_No;
        private DateTime dateTime;
        private string me_Id;
        private string p_Id;
        private string c_Id;

        public MedicinePurchase()
        {

        }

        public MedicinePurchase(string bill_No, DateTime dateTime, string me_Id, string p_Id, string c_Id)
        {
            this.Bill_No = bill_No;
            this.DateTime = dateTime;
            this.Me_Id = me_Id;
            this.P_Id = p_Id;
            this.C_Id = c_Id;
        }

        public string Bill_No { get => bill_No; set => bill_No = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public string Me_Id { get => me_Id; set => me_Id = value; }
        public string P_Id { get => p_Id; set => p_Id = value; }
        public string C_Id { get => c_Id; set => c_Id = value; }
    }
}
