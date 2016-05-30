using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Data;
using MySql.Data.MySqlClient;
using StackExchange.Redis;

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

        public ConnectionMultiplexer GetRedisConnection()
        {
            string host = Properties.Settings.Default.RedisHost;
            string port = Properties.Settings.Default.RedisPort;
            string passwd = Properties.Settings.Default.RedisPassword;
            return ConnectionMultiplexer.Connect(string.Format("{0}:{1},password={2}", host, port, passwd));
        }

        private String connString { get; set; }
    }
}
