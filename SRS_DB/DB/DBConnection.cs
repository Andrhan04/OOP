using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SRS_DB.DB
{
    internal class DBConnection
    {
        private bool _is_connected = false;
        
        private SqlConnection _connection;       
        public DBConnection(string DMS) 
        {
            _is_connected = true; 
            _connection = new SqlConnection(DMS);
        }
        public List<string> Select(string query)
        {
            List<string> data = new List<string>();

            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, _connection);   
            
            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                
                while (reader.Read())
                {
                    int FieldCnt = reader.FieldCount;                   
                    data.Add(reader.GetInt32(0).ToString());
                    for(int i = 1; i < FieldCnt; i++)
                    {
                        data.Add(reader.GetValue(i).ToString());
                    }
                }
                if(data.Count() == 0)
                {
                    Console.WriteLine("Нет элемента с таким идентификатором");
                }
                reader.Close();
            }
            _connection.Close();

            return data;
        }
        public int Insert(string query)
        {

            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, _connection);

            int id = 0;

            using (SqlDataReader reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
            }

            _connection.Close();
            return id;
        }
        public void Delete(string query)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, _connection);

            sqlCommand.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(string query)
        {
            _connection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, _connection);

            sqlCommand.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
