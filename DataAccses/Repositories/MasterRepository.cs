using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DataAccses.Repositories
{
    public abstract class MasterRepository : Repository
    {
        protected List<OleDbParameter> parameters;
        protected int ExecuteNonQuery(string queryTransaction)
        {
            
            using (var connection = GetConnection())
            {
                using (OleDbCommand command = new OleDbCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = queryTransaction;

                    foreach(OleDbParameter parameter in parameters)
                    {
                        command.Parameters.Add(parameter);
                    }
                    int rowsAffected = command.ExecuteNonQuery();
                    parameters.Clear();
                    return rowsAffected;
                }
            }
        }
        protected DataTable ExecuteReader(string queryTransaction)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = queryTransaction;
                    OleDbDataReader reader = command.ExecuteReader();
                    using (DataTable dataTable = new DataTable())
                    {
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }
    }
}
