using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
   public  class Pharmacys
   {
        SqlDbDatabase sqdb = new SqlDbDatabase();
        public void AddPharmacy(Pharmacy pharmacy)
        {
            SqlCommand cmd = sqdb.GetQuery("INSERT INTO pharmacy Values( @p_Id,@p_Name,@location,@lisenceNumber,@m_Id)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_Id", pharmacy.P_Id);
            cmd.Parameters.AddWithValue("@p_Name", pharmacy.P_Name);
            cmd.Parameters.AddWithValue("@location", pharmacy.Location);
            cmd.Parameters.AddWithValue("@lisenceNumber", pharmacy.LisenceNumber);
            cmd.Parameters.AddWithValue("@m_Id", pharmacy.M_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public void UpdatePharmacy(Pharmacy pharmacy)
        {
            SqlCommand cmd = sqdb.GetQuery("UPDATE pharmacy SET p_Id=@p_Id,p_Name=@p_Name,locatioin=@location,lisenceNumber=@lisenceNumber,m_Id=@m_Id Where p_Id=@p_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_Id", pharmacy.P_Id);
            cmd.Parameters.AddWithValue("@p_Name", pharmacy.P_Name);
            cmd.Parameters.AddWithValue("@location", pharmacy.Location);
            cmd.Parameters.AddWithValue("@lisenceNumber",pharmacy.LisenceNumber);
            cmd.Parameters.AddWithValue("@m_Id",pharmacy.M_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public void RemovePharmacy(string pharmacyId)
        {
            SqlCommand cmd = sqdb.GetQuery("DELETE FROM pharmacy WHERE p_Id=@p_id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_Id", pharmacyId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public Pharmacy SearchPharmacy(string pharmacyId)
        {
            SqlCommand cmd = sqdb.GetQuery("SELECT * FROM pharmacy WHERE p_id=@p_id;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", pharmacyId);
            List<Pharmacy> pharmacyList = GetData(cmd);
            if (pharmacyList.Count > 0)
            {
                return pharmacyList[0];
            }
            else
            {
                return null;
            }
        }
        public List<Pharmacy> GetAllPharmacy()
        {
            SqlCommand cmd = sqdb.GetQuery("SELECT p_Id, p_Name, locatioin, lisenceNumber, m_Id FROM Pharmacy");
            cmd.CommandType = CommandType.Text;
            List<Pharmacy> pharmacyList = GetData(cmd);
            return pharmacyList;

        }
        public List<Pharmacy>GetPharmacy(string adminId)
        {
            SqlCommand cmd = sqdb.GetQuery("SELECT p.p_Id,p.p_Name,p.locatioin,p.lisenceNumber,p.m_Id FROM pharmacy AS p INNER JOIN manager AS m ON p.m_Id=m.m_Id INNER JOIN Admin AS a ON m.a_Id=a.a_Id WHERE a.a_Id=@a_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@a_Id", adminId);
            List<Pharmacy> pharmacyList = GetData(cmd);
            return pharmacyList;
        }
        public List<Pharmacy> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr= cmd.ExecuteReader();
            List<Pharmacy> pharmacyList = new List<Pharmacy>();
            using(sdr)
            {
                while (sdr.Read())
                {
                    Pharmacy pharmacy = new Pharmacy();
                    pharmacy.P_Id = sdr.GetString(0);
                    pharmacy.P_Name = sdr.GetString(1);
                    pharmacy.Location = sdr.GetString(2);
                    pharmacy.LisenceNumber = sdr.GetString(3);
                    pharmacy.M_Id = sdr.GetString(4);
                    pharmacyList.Add(pharmacy);
                }
            }
            cmd.Connection.Close();

            return pharmacyList;
        }
 
        public  string GetPharmacyIdByManagerId(string managerId)
        {
          
            SqlCommand cmd = sqdb.GetQuery("SELECT p_Id FROM Pharmacy WHERE m_Id = @m_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue ("@m_Id",managerId);         
            Pharmacy p = new Pharmacy();
            cmd.Connection.Open();
            SqlDataReader sdb = cmd.ExecuteReader();
            while(sdb.Read())
            {
              p.P_Id = sdb.GetString(0);
              
            }
            cmd.Connection.Close();
            return p.P_Id;

        }
   }


}

