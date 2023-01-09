 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccses.Contracts;
using DataAccses.Entity;

namespace DataAccses.Repositories
{
    public class AccountRepository : MasterRepository, IAccountRepository
    {
        private string insert;
        private string select;
        private string update;
        private string delete;

        public AccountRepository()
        {
            //Inicializando as querys  
            /*,,USER,CONTACT*/ /*,@user,@contact*/

            //Alguns campos não estão devidamente definidos para validar a query insert
            insert = "INSERT INTO ACCOUNT (PLATAFORM, EMAIL, PASSWORD_CONTENT, USERNAME, CONTACT,PASSWORD_CREATOR) VALUES (@plataform, @email, @password, @user, @contact, @password_creator)";
            select = "SELECT * FROM ACCOUNT";
            update = "UPDATE ACCOUNT SET (PLATAFORM = @plataform, EMAIL = @email, PASSWORD_CONTENT = @password,USERNAME = @user,CONTACT = @contact)";
            delete = "DELETE FROM ACCOUNT WHERE ID = @id";
        }
        public int Add(Account entity)
        {
            parameters = new List<System.Data.OleDb.OleDbParameter>();

            parameters.Add(new System.Data.OleDb.OleDbParameter("@plataform", entity.plataform));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@email", entity.email));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@password", entity.password));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@user", entity.user));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@contact", entity.contact));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@password_creator", entity.password_creator));

            return (ExecuteNonQuery(insert));
        }
        //Obtendo os dados da dataTable e gerando uma lista de conta
        public IEnumerable<Account> GetAll()
        {
            using (DataTable dataTable = ExecuteReader(select))
            {
                List<Account> accountList = new List<Account>();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    accountList.Add(new Account {
                        id_pk = Convert.ToInt16(dataRow[0]),
                        plataform = dataRow[1].ToString(),
                        email = dataRow[2].ToString(),
                        password = dataRow[3].ToString(),
                        user = dataRow[4].ToString(),
                        contact = Convert.ToInt32(dataRow[5]),
                        password_creator = dataRow[6].ToString()
                    });

                }
                    return (accountList);
            }
        }

        public int Remove(int id)
        {
            parameters = new List<System.Data.OleDb.OleDbParameter>();
            parameters.Add(new System.Data.OleDb.OleDbParameter("@id", id));
            return (ExecuteNonQuery(delete));
        }

        public int Update(Account entity)
        {
            parameters = new List<System.Data.OleDb.OleDbParameter>();

            parameters.Add(new System.Data.OleDb.OleDbParameter("@plataform", entity.plataform));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@email", entity.email));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@password", entity.password));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@user", entity.user));
            parameters.Add(new System.Data.OleDb.OleDbParameter("@contact", entity.contact));

            return (ExecuteNonQuery(update));
        }
    }
}
