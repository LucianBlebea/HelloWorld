using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace AlternativeDataAccess
{
    public class DataHelper
    {
        //get connectionString to database
        private string connectionString = ConfigurationManager.ConnectionStrings["HelloDBConnectionString"].ConnectionString;

        public string GetProductName(string ID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT productName from Product WHERE ID = @ID";
            command.Parameters.Add(new SqlParameter("@ID", ID));

            command.Connection = connection;
            connection.Open();

            string productName = Convert.ToString(command.ExecuteScalar());
            
            connection.Close();

            return productName;
        }



        public DataSet GetDataByQuery(string sqlQuery)
        {
            DataSet dataset = new DataSet();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter
                {
                    SelectCommand = new SqlCommand(sqlQuery, connection)
                };
                adapter.Fill(dataset);
                connection.Close();
            }
            return dataset;
        }

        public DataTable GetDataByStoredProcedure(string procedureName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = procedureName;

            command.Connection = connection;
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}
