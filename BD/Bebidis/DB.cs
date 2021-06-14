using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Bebidis
{
    class DB
    {
        protected static DB db = null;
        protected static String dbServer ="tcp:mednat.ieeta.pt\\SQLSERVER,8101";
        protected static String dbName = "p1g8";
        protected static String userName = "p1g8";
        protected static String userPass = "Lalala#001";
        protected static String connectionString;

        protected DB()
        {
            connectionString = "data source=" + dbServer + " ;" + "Initial Catalog = " + dbName +
                                    "; uid = " + userName + ";" + "password = " + userPass + ";";
        }

        public static DB getDB()
        {
            if (db == null)
            {
                db = new DB();
            }
            return db;
        }

        public String getConnectionString()
        {
            return connectionString;
        }
    }
}
