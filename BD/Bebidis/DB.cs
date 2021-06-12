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
        protected String dbServer = "tcp:mednat.ieeta.pt\\SQLSERVER,8101";
        protected String dbName = "p1g8";
        protected String userName = "p1g8";
        protected String userPass = "Lalala#001";
        protected String connectionString;

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
