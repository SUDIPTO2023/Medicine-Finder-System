using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
    public class Medicines
    {
        SqlDbDatabase sqdb = new SqlDbDatabase();
        public void AddMedicine(Medicine medicine)
        {

            SqlCommand cmd = sqdb.GetQuery("INSERT INTO medicine Values(@me_ID,@me_Name,@salt,@company,@price,@quantity,@type,@p_Id)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@me_Id", medicine.Me_Id);
            cmd.Parameters.AddWithValue("@me_Name", medicine.Me_Name);
            cmd.Parameters.AddWithValue("@salt", medicine.Salt);
            cmd.Parameters.AddWithValue("@company", medicine.Company);
            cmd.Parameters.AddWithValue("@price", medicine.Price);
            cmd.Parameters.AddWithValue("@quantity", medicine.Quantity);
            cmd.Parameters.AddWithValue("@type", medicine.Type);
            cmd.Parameters.AddWithValue("@p_Id", medicine.P_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateMedicine(Medicine medicine)
        {
            SqlCommand cmd = sqdb.GetQuery("UPDATE Medicine SET me_Id=@me_Id, me_Name=@me_Name,salt=@salt,company=@company,price=@price, quantity=@quantity,type=@type,p_Id=@p_Id WHERE me_ID=@me_Id;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@me_Id", medicine.Me_Id);
            cmd.Parameters.AddWithValue("@me_Name", medicine.Me_Name);
            cmd.Parameters.AddWithValue("@salt", medicine.Salt);
            cmd.Parameters.AddWithValue("@company", medicine.Company);
            cmd.Parameters.AddWithValue("@price", medicine.Price);
            cmd.Parameters.AddWithValue("@quantity", medicine.Quantity);
            cmd.Parameters.AddWithValue("@type", medicine.Type);
            cmd.Parameters.AddWithValue("@p_Id", medicine.P_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void RemoveMedicine(string medicineId)
        {
            SqlCommand cmd = sqdb.GetQuery("DELETE FROM MEDICINE WHERE me_id=@me_id;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@me_Id", medicineId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public Medicine SearchMedicine(string medicineId)
        {
            SqlCommand cmd = sqdb.GetQuery("SELECT * FROM Medicine WHERE me_id=@me_id;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@me_id", medicineId);
            List<Medicine> medicineList = GetData(cmd);
            if (medicineList.Count>0)
            {
                return medicineList[0];
            }
            else
            {
                return null;
            }


        }
        public List<Medicine> GetMedicines(string pharmacyId)
        {
            SqlCommand cmd = sqdb.GetQuery ("SELECT  me_Id,me_Name,salt,company,price,quantity,type,p_id FROM Medicine WHERE p_Id=@p_id;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", pharmacyId);
            List<Medicine> medicineList = GetData(cmd);
            return medicineList;

        }

        public List<Medicine> GetMedicineByNameAndLocation(string name, string location)
        {
            SqlCommand cmd = sqdb.GetQuery(@"SELECT me.*,p.p_Name  FROM medicine me INNER JOIN pharmacy p ON me.p_id = p.p_Id WHERE me.me_Name = @me_Name AND p.locatioin = @locatioin");
            cmd.Parameters.AddWithValue("@me_Name", name);
            cmd.Parameters.AddWithValue("@locatioin", location);
            List<Medicine> medicineList = GetExtraData(cmd);
            return medicineList;
        }
        public List<Medicine> GetExtraData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Medicine> medicinList = new List<Medicine>();
            using (sdr)
            {
                while (sdr.Read())
                {
                    Medicine medicine = new Medicine();
                    medicine.Me_Id = sdr.GetString(0);
                    medicine.Me_Name = sdr.GetString(1);
                    medicine.Salt = sdr.GetString(2);
                    medicine.Company = sdr.GetString(3);
                    medicine.Price = sdr.GetInt32(4);
                    medicine.Quantity = sdr.GetInt32(5);
                    medicine.Type = sdr.GetString(6);
                    medicine.P_Id = sdr.GetString(7);
                    medicine.P_Name = sdr.GetString(8);
                    medicinList.Add(medicine);

                }

            }

            cmd.Connection.Close();
            return medicinList;
        }

        public List<Medicine> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Medicine> medicinList = new List<Medicine>();
            using(sdr)
            {
                while(sdr.Read())
                {
                    Medicine medicine = new Medicine();
                    medicine.Me_Id = sdr.GetString(0);
                    medicine.Me_Name = sdr.GetString(1);
                    medicine.Salt = sdr.GetString(2);
                    medicine.Company = sdr.GetString(3);
                    medicine.Price = Convert.ToInt32(sdr.GetInt32(4));
                    medicine.Quantity = Convert.ToInt32(sdr.GetInt32(5));
                    medicine.Type = sdr.GetString(6);
                    medicine.P_Id = sdr.GetString(7);
                    medicinList.Add(medicine);

                }

            }
            
            cmd.Connection.Close();
            return medicinList;
        }
         
         

        

        


    }
}
