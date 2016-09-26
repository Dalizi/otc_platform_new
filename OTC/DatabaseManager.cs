/*
版权所有：中粮期货有限公司
作者：谭泽寰
功能：实现了DatabaseManager类，用来生成连接MySQL以及Redis数据库的实例
*/
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

        //解码加密过的连接字符串，并返回MySQL连接实例
        public MySqlConnection GetSQLConnection()
        {
            return new MySqlConnection(DataProtection.DecryptString(connString));
        }

        //把连接字符串作为参数，返回MySQL连接实例
        public MySqlConnection GetSQLConnection(string conn_string)
        {
            return new MySqlConnection(conn_string);
        }

        //从配置信息中读取Redis数据库的连接信息，返回连接实例
        public ConnectionMultiplexer GetRedisConnection()
        {
            string host = Properties.Settings.Default.RedisHost;
            string port = Properties.Settings.Default.RedisPort;
            string passwd = Properties.Settings.Default.RedisPassword;
            return ConnectionMultiplexer.Connect(string.Format("{0}:{1},password={2}", host, port, passwd));
        }

        //把连接字符串作为参数，返回连接实例
        public ConnectionMultiplexer GetRedisConnection(string conn_string)
        {
            return ConnectionMultiplexer.Connect(conn_string);
        }

        private String connString { get; set; }
    }
}
