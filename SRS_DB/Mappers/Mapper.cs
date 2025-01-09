using SRS_DB.DB;
using SRS_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_DB.Mappers
{
    internal class Mapper
    {
        protected static DBConnection _connection = null;
        public string tableName;
        public Mapper(string tableName)
        {
            if (_connection == null)
            {
                _connection = new DBConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sidenov;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            }
            this.tableName = tableName;
        }
        
        public DomainObject Find(int id)
        {
            ObjectWatcher objectList = ObjectWatcher.Instance;
            DomainObject result = objectList.GetObject($"{tableName}{id}");
            if(result != null)
            {
                return result;
            }
            return SelectStmt(id);
        }
        protected DomainObject SelectStmt(int id)
        {
            Console.WriteLine("id: " + id);
            string query = $"SELECT * FROM {tableName} WHERE id = {id}";
            List<string> data = _connection.Select(query);
            return GetObj(tableName, data);
        }
        protected DomainObject GetObj(string tableName, List<string> data)
        {
            ObjectWatcher objectList = ObjectWatcher.Instance;
            DomainObject result = objectList.GetObject($"{tableName}{data[0]}");
            if(result == null)
            {
                if(tableName == "fraction")
                {
                    result  = new Fraction(data);
                }
                else if(tableName == "fraction_type")
                {
                    result =  new FractionType(data);
                }
                else
                {
                    result =  new Cat(data);
                }
                objectList.Add($"{tableName}{data[0]}", result);
            }

            return result;
        }
        public int Save(DomainObject obj)
        {
            if(obj.Id == 0)
            {
                string query = $"INSERT INTO {tableName} (";

                List<string> colums = obj.GetColums();

                query += colums[0];
                for(int i = 1; i < colums.Count; i++)
                {
                    query += ", " + colums[i] ;
                }

                query += ") OUTPUT Inserted.ID VALUES (";

                var values = obj.GetValues();

                query += values[0];
                for(int i = 1; i< values.Count();i++)
                {
                    query += ", "  + values[i] ;
                }

                query += ")" ;
                int result=-1;
                result= _connection.Insert(query);
                obj.Id = result;
            }
            else
            {
                string query = $"UPDATE {tableName} SET";
                var colums = obj.GetColums();
                var values = obj.GetValues();

                query += " " + colums[0] + "=" + values[0];

                for (int i =1;i< colums.Count;i++)
                {
                    query += ", " +  colums[i] + "=" + values[i]; 
                }
                query += $"WHERE id  = {obj.Id}";
                _connection.Update(query);
            }
            return obj.Id;
        }
        public void Delete(DomainObject obj)
        {
            string query = $"DELETE FROM {tableName} WHERE id = {obj.Id}";
            _connection.Delete(query);
            obj = null;
        }

        public List<DomainObject> GetAll()
        {
            string query = $"SELECT id FROM {tableName}";
            List<string> data = _connection.Select(query);

            List<DomainObject> fractions = new List<DomainObject>();

            if (tableName == "fraction")
            {
                foreach (string i in data)
                {
                    if (int.TryParse(i, out int id))
                    {
                        Fraction fraction = (Fraction)Find(id);

                        fractions.Add(fraction);
                    }
                }
            }
            else
            {
                foreach (string i in data)
                {
                    if (int.TryParse(i, out int id))
                    {
                        FractionType fractionType = (FractionType)Find(id);

                        fractions.Add(fractionType);
                    }
                }
            }

            return fractions;
        }
    }
}
