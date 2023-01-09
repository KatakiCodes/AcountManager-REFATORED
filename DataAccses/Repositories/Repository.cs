using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Input;

namespace DataAccses.Repositories
{
    public abstract class Repository
    {
        private readonly string ConectionString;
        public Repository()
        {

            this.ConectionString = ConfigurationManager.ConnectionStrings["MyDB"].ToString();         
        }
        public OleDbConnection GetConnection()
        {
            return (new OleDbConnection(this.ConectionString));
        }
}
}
