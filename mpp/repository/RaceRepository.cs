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
    public class RaceRepository : IRaceRepository
    {
        private static readonly ILog Logger = LogManager.GetLogger("RaceRepository");
        public IDictionary<string, string> props;
        public RaceRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public IEnumerable<Race> FindAll()
        {
            throw new NotImplementedException();
        }

        public Race FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public Race FindRaceByReferee(string username)
        {
            IDbConnection con = DBUtils.GetConnection(props);
            using (var command = con.CreateCommand())
            {
                command.CommandText = "select race.id_race, race.name from race inner join referee r on race.id_race = r.id_referee where r.username = @username ";
                IDbDataParameter paramUsername = command.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = username;
                command.Parameters.Add(paramUsername);

                using (var dataR = command.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idRace = dataR.GetInt32(0);
                        string name = dataR.GetString(1);
                        Race race = new Race
                        {
                            Id = idRace,
                            Name = name,
                            Referee = null
                        };
                        con.Close();
                        return race;
                    }
                }
            }
            return null;
        }
    }
}
