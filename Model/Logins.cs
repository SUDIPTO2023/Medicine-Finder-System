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
   public  class Logins
   {
        SqlDbDatabase sdb = new SqlDbDatabase();
        public void AddLogin(Login login)
        {
            SqlCommand cmd = sdb.GetQuery("INSERT INTO login Values(@user_Id,@email,@role,@securityAnswer,@password)");
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@user_Id", login.User_Id);
            cmd.Parameters.AddWithValue("@email", login.Email);
            cmd.Parameters.AddWithValue("@role", login.Role);
            cmd.Parameters.AddWithValue("@securityAnswer", login.SecurityAnswer);
            cmd.Parameters.AddWithValue("@password", login.Password);
           
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public Login UserValidate(string userId,string answer)
        {
            SqlCommand cmd = sdb.GetQuery("SELECT * FROM login WHERE user_Id=@user_Id AND securityAnswer=@securityAnswer");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@user_Id", userId);
            cmd.Parameters.AddWithValue("@securityAnswer", answer);
            Login login = GetDataValid(cmd);
            return login;
        }
        public void UpdatePassword(Login login)
        {
            try
            {

                SqlCommand cmd = sdb.GetQuery("UPDATE login SET password=@password WHERE user_Id=@user_Id");
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@user_Id", login.User_Id);
                cmd.Parameters.AddWithValue("@password", login.Password);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        public Login GetDataValid(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            Login login = new Login();

            
           
            if (sdr.Read())
            {
                     
              login.User_Id = sdr.GetString(0);
              login.Email = sdr.GetString(1);
              login.Role = sdr.GetInt32(2);
              login.SecurityAnswer = sdr.GetString(3);
              login.Password = sdr.GetString(4);
              cmd.Connection.Close();
              return login;
            }
            else
            {
                cmd.Connection.Close();
                return null;
                
            }





        }
        public Login SearchLogin(string user_Id,string password)
        {
            SqlCommand cmd = sdb.GetQuery("SELECT* FROM login WHERE user_Id=@user_Id AND password=@password");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@user_Id",user_Id);
            cmd.Parameters.AddWithValue("@password", password);
            List<Login> loginList = GetData(cmd);
            if (loginList.Count>0)
            {
                
                 return loginList[0];
                
                 
            }
            else
            {
               return null;
            }
                
           
            
        }
         
        public List<Login> GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Login> loginList = new List<Login>();
            
            using (sdr)
            {
                while(sdr.Read())
                {
                    Login login = new Login();
                    login.User_Id = sdr.GetString(0);
                    login.Email = sdr.GetString(1);
                    login.Role = sdr.GetInt32(2);
                    login.SecurityAnswer = sdr.GetString(3);
                    login.Password = sdr.GetString(4);
                    loginList.Add(login);
                }
            }
            cmd.Connection.Close();
             
            
            return loginList;
        }

   }
}
