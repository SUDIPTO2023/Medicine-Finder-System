using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace MedicineLocator.Model
{
    
    public class Admins
    {
        SqlDbDatabase sqdb = new SqlDbDatabase();
        public void AddAdmin()
        {
            SqlCommand cmd = sqdb.GetQuery("INSERT INTO Admin Value(@a_Id,@a_Name,@a_Number)");
        }
        public string GetAdminIdByManagerId(string managerId)
        {
            string adminId = "0";
            SqlCommand cmd = sqdb.GetQuery("SELECT a_Id FROM Admin WHERE m_Id = @m_Id");

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@m_Id", managerId);
            cmd.Connection.Open();
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                adminId= Convert.ToString(result);
            }
            cmd.Connection.Close();
            return adminId;

        }
    }
}
