using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartPOS
{
    public class adoClass
    {
        public static SqlConnection sqlCn;
        public static SqlCommandBuilder builder;
        public static void setConnection()
        {
            sqlCn = new SqlConnection(SmartPOS.Properties.Settings.Default.connections);
        }
    }
}
