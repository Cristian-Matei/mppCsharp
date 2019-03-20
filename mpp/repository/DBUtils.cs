using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository
{
    class DBUtils
    {
        private static IDbConnection instance = null;

        public static IDbConnection GetConnection (IDictionary<string, string> props)
        {
            if (instance == null || instance.State == ConnectionState.Closed)
            {
                instance = GetNewConnection(props);
                instance.Open();
            }
            return instance;
        }

        private static IDbConnection GetNewConnection(IDictionary<string, string> props) 
            => ConnectionFactory.GetInstance().CreateConnection(props);

        public static IDictionary<string, string> getProps()
        {
            string connStr = ConfigurationManager.ConnectionStrings["triathlon"].ToString();
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", connStr);
            return props;
        }
    }
}
