using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MESProject.DBConnect
{
    class DataSources
    {
        private static string strconn =
            "Data Source=192.168.0.9;Initial Catalog=Product Manager;User ID=sa;Password=1234";
        private static SqlConnection conn = null;

        public static SqlConnection getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strconn);

            }
            conn.Open();
            Console.WriteLine("연결성공");
            return conn;
        }

        public static void setClose()
        {
            if (conn != null)
            {
                Console.WriteLine("연결끊기성공");
                conn.Close();
            }

        }


    }
}
