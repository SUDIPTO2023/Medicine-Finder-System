using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
   public class Managers
    {
        SqlDbDatabase sqdb = new SqlDbDatabase();
        public void AddManager(Manager manager)
        {
            SqlCommand cmd = sqdb.GetQuery("INSERT INTO manager Values(@m_Id,@m_Name,@m_Number,@a_Id)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@m_Id", manager.M_Id);
            cmd.Parameters.AddWithValue("@m_Name", manager.M_Name);
            cmd.Parameters.AddWithValue("@m_Number", manager.M_Number);
            cmd.Parameters.AddWithValue("@a_Id", manager.A_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
       public void  UpdateManager(Manager manager)
       {
            SqlCommand cmd = sqdb.GetQuery("UPDATE manager SET m_Id=@m_Id,m_Name=@m_Name,m_Number=@m_Number,a_Id=@a_Id Where m_Id=@m_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@m_Id", manager.M_Id);
            cmd.Parameters.AddWithValue("@m_Name", manager.M_Name);
            cmd.Parameters.AddWithValue("@m_Number", manager.M_Number);
            cmd.Parameters.AddWithValue("@a_Id", manager.A_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
       }
       public void RemoveManager(string managerId)
       {
            SqlCommand cmd = sqdb.GetQuery("DELETE FROM manager WHERE m_Id=@m_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@m_Id", managerId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
       }
       public Manager SearchManager(string managerId)
       {
            SqlCommand cmd = sqdb.GetQuery("SELECT * FROM manager WHERE m_Id=@m_Id;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@m_Id", managerId);
            List<Manager> managerList = GetData(cmd);
            if (managerList.Count > 0)
            {
                return managerList[0];
            }
            else
            {
                return null;
            }
        }
        public List<Manager>GetAllManager()
        {
            SqlCommand cmd = sqdb.GetQuery("SELECT * FROM manager");
            cmd.CommandType = CommandType.Text;
            List<Manager> managerList = GetData(cmd);
            return managerList;
        }
        public Manager GetManagerByUserId(string userId)
        {
            SqlCommand cmd = sqdb.GetQuery("SELECT m_Id,m_Name,m_Number,a_Id FROM manager WHERE m_Id=@m_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@m_Id", userId);
            Manager manager = GetSpecificManagerData(cmd);
            return manager;
        }
        public Manager GetSpecificManagerData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sqd = cmd.ExecuteReader();
            Manager manager = new Manager();
            using (sqd)
            {
                while (sqd.Read())
                {
                     
                    manager.M_Id = sqd.GetString(0);
                    manager.M_Name = sqd.GetString(1);
                    manager.M_Number = Convert.ToInt32(sqd.GetInt32(2));
                    manager.A_Id = sqd.GetString(3);
                     
                }
            }
            cmd.Connection.Close();
            return manager ;
        }
        public List<Manager>GetManager(string adminId)
        {
            SqlCommand cmd = sqdb.GetQuery("SELECT m_Id,m_Name,m_Number,a_Id FROM manager WHERE a_Id=@a_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@a_Id", adminId);
            List<Manager> managerList = GetData(cmd);
            return managerList;
        }
        public List<Manager>GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sqd = cmd.ExecuteReader();
            List<Manager> managerList = new List<Manager>();
            using(sqd)
            {
                while (sqd.Read())
                {
                    Manager manager = new Manager();
                    manager.M_Id = sqd.GetString(0);
                    manager.M_Name = sqd.GetString(1);
                    manager.M_Number = Convert.ToInt32(sqd.GetInt32(2));
                    manager.A_Id = sqd.GetString(3);
                    managerList.Add(manager);
                }
            }
            cmd.Connection.Close();
            return managerList;
        }
        

        // Random unique Client ID generate
        
    }
}
