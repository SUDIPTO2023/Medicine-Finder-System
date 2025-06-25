using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace MedicineLocator.Model
{
    class SqlDbDatabase
    {
        private const string connectionString = @"Data Source=DESKTOP-ADCQA77; Database=Medicine Finder; Integrated Security=true;TrustServerCertificate=True;";
         
         public SqlCommand GetQuery(string query)
         {
            var connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connection;
            return cmd;

         }

        
    }
}
