using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using mpp.model;
using MySql.Data.MySqlClient;

namespace mpp.repository
{
    class ParticipantRepository : IParticipantRepository
    {
        private static readonly ILog Logger = LogManager.GetLogger("ParticipantRepository");
        public IDictionary<string, string> props;
        public ParticipantRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }
        public IEnumerable<Participant> FindAll()
        {
            throw new NotImplementedException();
        }

        public DataSet FindAllByRace(Race race)
        {
            string commandText = "select p.id_participant, p.first_name, p.last_name, s.points from participant p inner join score s on  p.id_participant = s.participant where s.race = @race and s.points > 0 order by s.points DESC";
            IDbConnection con = DBUtils.GetConnection(props);
            var dataAdapter = new MySqlDataAdapter(commandText, (MySqlConnection)con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@race", race.Id);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            con.Close();
            return ds;

        }

        public DataSet FindAllOrderedByName()
        {
            Logger.InfoFormat("Retrived all participants");
            List<Participant> participants = new List<Participant>();
            string command = "select p.id_participant, p.first_name, p.last_name, sum(s.points) as puncte from participant p inner join score s on p.id_participant = s.participant group by p.first_name order by p.first_name ASC, p.last_name ASC";
            IDbConnection con = DBUtils.GetConnection(props);
            var dataAdapter = new MySqlDataAdapter(command, (MySqlConnection)con);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            con.Close();
            return ds;
        }

        public Participant FindOne(int id)
        {
            throw new NotImplementedException();
        }

        public List<int> GetIds()
        {
            List<int> ids = new List<int>();
            IDbConnection con = DBUtils.GetConnection(props);
            using (var command = con.CreateCommand())
            {
                command.CommandText = "select id_participant from participant";
                using (var dataR = command.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        ids.Add(dataR.GetInt32(0));
                    }
                    con.Close();
                    return ids;
                }
            }
           
        }
    }
}
