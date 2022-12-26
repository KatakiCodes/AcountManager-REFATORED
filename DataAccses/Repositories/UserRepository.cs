using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccses.Contracts;
using DataAccses.Entity;

namespace DataAccses.Repositories
{
    public class UserRepository : MasterRepository,IUserRepository
    {
        private string insert;
        private string select;
        private string update;
        private string delete;

        public UserRepository()
        {
            //Inicializando as querys

            insert = "INSERT INTO USER VALUES (@SENHA,@ALT_SENHA)";
            select = "SELECT * FROM TBL_USER";
            update = "UPDATE TBL_USER SET (SENHA = @SENHA, ALT_SENHA = @ALT_SENHA)";
            delete = "DELETE FROM TBL_USER WHERE ID = @id_pk";
        }

        public int Add(User entity)
        {
            parameters = new List<System.Data.OleDb.OleDbParameter>();
            parameters.Add(new System.Data.OleDb.OleDbParameter("@SENHA", entity.password));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@ALT_SENHA", entity.alt_password));

            return (ExecuteNonQuery(insert));
        }

        public IEnumerable<User> GetAll()
        {
            using (DataTable dataTable = ExecuteReader(select))
            {
                List<User> userList = new List<User>();
                foreach(DataRow dataRow in dataTable.Rows)
                {
                    userList.Add(new User
                    {
                        id_pk = Convert.ToInt16(dataRow[0]),
                        password = dataRow[1].ToString(),
                        alt_password = dataRow[2].ToString()
                    });
                }
                return userList;
            }
        }

        public int Remove(int id)
        {
            parameters = new List<System.Data.OleDb.OleDbParameter>();
            parameters.Add(new System.Data.OleDb.OleDbParameter("@id_pk", id));

            return (ExecuteNonQuery(delete));
        }

        public int Update(User entity)
        {
            parameters = new List<System.Data.OleDb.OleDbParameter>();
            parameters.Add(new System.Data.OleDb.OleDbParameter("@SENHA", entity.password));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@ALT_SENHA", entity.alt_password));

            return (ExecuteNonQuery(update));
        }
    }
}
