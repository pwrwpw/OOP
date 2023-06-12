using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank
{
    class Setting
    {
        public static string Database = "shopdb";
        public static string Server = "localhost";
        public static string UserID = "root";
        public static string UserPassword = "1q2q3q";

        public static DataSet bank_ds = null;

    }
}
