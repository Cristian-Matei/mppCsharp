using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using mpp.model;

namespace mpp.repository
{
    public class RefereeRepository : IRefereeRepository
    {
        private static readonly ILog Logger = LogManager.GetLogger("RefereeRepository");
        public IDictionary<string, string> props;
        public RefereeRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public IEnumerable<Referee> FindAll() => throw new NotImplementedException();

        public Referee FindOne(int id)
        {
            Logger.InfoFormat("Try to find Referee with id {0}", id);
            IDbConnection con = DBUtils.GetConnection(props);
            using(var command = con.CreateCommand())
            {
                command.CommandText = "Select * from referee where id_referee = @id";
                IDbDataParameter paramId = command.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                command.Parameters.Add(paramId);

                using (var dataR = command.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idReferee = dataR.GetInt32(0);
                        string firstName = dataR.GetString(1);
                        string lastName = dataR.GetString(2);
                        string username = dataR.GetString(3);
                        string password = dataR.GetString(4);
                        Referee referee = new Referee
                        {
                            Id = idReferee,
                            FirstName = firstName,
                            LastName = lastName,
                            Username = username,
                            Password = password,
                            Race = null
                        };
                        con.Close();
                        return referee;
                    }
                }
            } 
            return null;
        }

        public Referee FindRefereeByUsernameAndPassword(string username, string password)
        {
            Logger.InfoFormat("Try to find Referee with username {0}", username);
            IDbConnection con = DBUtils.GetConnection(props);
            using (var command = con.CreateCommand())
            {
                command.CommandText = "Select * from referee where username = @user and password = md5(@pass)";
                IDbDataParameter paramUser = command.CreateParameter();
                paramUser.ParameterName = "@user";
                paramUser.Value = username;
                command.Parameters.Add(paramUser);

                IDbDataParameter paramPass = command.CreateParameter();
                paramPass.ParameterName = "@pass";
                paramPass.Value = password;
                command.Parameters.Add(paramPass);

                using (var dataR = command.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idReferee = dataR.GetInt32(0);
                        string firstName = dataR.GetString(1);
                        string lastName = dataR.GetString(2);
                        string user = dataR.GetString(3);
                        string pass = dataR.GetString(4);
                        Referee referee = new Referee
                        {
                            Id = idReferee,
                            FirstName = firstName,
                            LastName = lastName,
                            Username = username,
                            Password = pass,
                            Race = null
                        };
                        con.Close();
                        return referee;
                    }
                }
            }
            return null;
        }

    }
}
