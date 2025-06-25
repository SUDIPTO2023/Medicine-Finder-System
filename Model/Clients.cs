using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineLocator.Model
{
    public class Clients
    {
        SqlDbDatabase sdb = new SqlDbDatabase();
        public void AddClient(Client client)
        {
            SqlCommand cmd = sdb.GetQuery("INSERT INTO client Values(@c_Id,@c_Name,@gender,@c_Number,@a_Id)");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@c_Id", client.C_Id);
            cmd.Parameters.AddWithValue("@c_Name", client.C_Name);
            cmd.Parameters.AddWithValue("@gender", client.Gender);
            cmd.Parameters.AddWithValue("@c_Number", client.C_Number);
            cmd.Parameters.AddWithValue("@a_Id", client.A_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void UpdateClient(Client client)
        {
            SqlCommand cmd = sdb.GetQuery("UPDATE client SET c_Id=@c_Id,c_Name=@c_Name,gender=@gender,c_Number=@c_Number,a_Id=@a_Id WHERE c_Id=@c_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@c_Id", client.C_Id);
            cmd.Parameters.AddWithValue("@c_Name", client.C_Name);
            cmd.Parameters.AddWithValue("@gender", client.Gender);
            cmd.Parameters.AddWithValue("@c_Number", client.C_Number);
            cmd.Parameters.AddWithValue("@a_Id", client.A_Id);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void RemoveClient(string clientId)
        {
            SqlCommand cmd = sdb.GetQuery("DELETE FROM client WHERE c_Id=@c_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@c_Id", clientId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public Client SearchClient(string clientId )
        {
            SqlCommand cmd = sdb.GetQuery("SELECT * FROM client WHERE c_Id=@c_Id;");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@c_Id", clientId);
            List<Client> clientList = GetData(cmd);
            if (clientList.Count > 0)
            {
                return clientList[0];
            }
            else
            {
                return null;
            }
        }
        public Client GetClientFromUserId(string userId)
        {
            SqlCommand cmd = sdb.GetQuery("SELECT c_Id,c_Name,gender,c_Number,a_Id FROM client WHERE c_Id=@c_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@c_Id", userId);
            Client c = GetSpecificClientData(cmd);
            return c;

        }
        public Client GetSpecificClientData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            Client client = new Client();
            using (sdr)
            {
                while (sdr.Read())
                {
                    
                    client.C_Id = sdr.GetString(0);
                    client.C_Name = sdr.GetString(1);
                    client.Gender = sdr.GetString(2);
                    client.C_Number = Convert.ToInt32(sdr.GetInt32(3));
                    client.A_Id = sdr.GetString(4);
                     
                }
            }
            cmd.Connection.Close();
            return client;
        }
        public List<Client> GetAllClient()
        {
            SqlCommand cmd = sdb.GetQuery("SELECT * FROM client");
            cmd.CommandType = CommandType.Text;
            List<Client> clientList = GetData(cmd);
            return clientList;
        }
        public List<Client> GetClient(string adminId)
        {
            SqlCommand cmd = sdb.GetQuery("SELECT c_Id,c_Name,gender,c_Number,a_Id FROM client WHERE a_Id=@a_Id");
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@a_Id", adminId);
            List<Client> clientList = GetData(cmd);
            return clientList;
        }
        public List<Client>GetData(SqlCommand cmd)
        {
            cmd.Connection.Open();
            SqlDataReader sdr= cmd.ExecuteReader();
            List<Client> clientList = new List<Client>();
            using (sdr)
            {
                while (sdr.Read())
                {
                    Client client = new Client();
                    client.C_Id = sdr.GetString(0);
                    client.C_Name = sdr.GetString(1);
                    client.Gender = sdr.GetString(2);
                    client.C_Number = Convert.ToInt32(sdr.GetInt32(3));
                    client.A_Id = sdr.GetString(4);
                    clientList.Add(client);
                }
            }
            cmd.Connection.Close();
            return clientList;
        }
    }
}
