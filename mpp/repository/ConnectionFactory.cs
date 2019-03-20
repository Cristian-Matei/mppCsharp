using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository
{
    abstract class ConnectionFactory
    {
        protected ConnectionFactory() {
        }

        private static ConnectionFactory instance;

        public static ConnectionFactory GetInstance()
        {
            if (instance == null)
            {
                instance = new MySqlConnectionFactory();
            }
            return instance;
        }

        public abstract IDbConnection CreateConnection(IDictionary<string, string> props);
    }
}
