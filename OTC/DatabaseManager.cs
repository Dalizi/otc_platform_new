using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Data;
using MySql.Data.MySqlClient;

namespace OTC
{
    public class DatabaseManager
    {
        public DatabaseManager()
        {

        }

        public void SetConnString(String s)
        {
            this.connString = s;
        }

        public MySqlConnection GetSQLConnection()
        {
            return new MySqlConnection(DataProtection.DecryptString(connString));
        }

        private String connString { get; set; }
    }
}
