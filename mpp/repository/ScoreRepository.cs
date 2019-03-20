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
    public class ScoreRepository : IScoreRepository
    {
        private static readonly ILog Logger = LogManager.GetLogger("ScoreRepository");
        public IDictionary<string, string> props;
        public ScoreRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public void AddNewScore(int idParticipant, int idRace, int points)
        {
            Logger.InfoFormat("Add score to participant with id {0}", idParticipant);
            IDbConnection con = DBUtils.GetConnection(props);
            using (var command = con.CreateCommand())
            {
                command.CommandText = "update score set points = points + @points where participant = @participant and race = @race";
                IDbDataParameter paramParticipant = command.CreateParameter();
                paramParticipant.ParameterName = "@participant";
                paramParticipant.Value = idParticipant;
                command.Parameters.Add(paramParticipant);

                IDbDataParameter paramRace = command.CreateParameter();
                paramRace.ParameterName = "@race";
                paramRace.Value = idRace;
                command.Parameters.Add(paramRace);

                IDbDataParameter paramPoints = command.CreateParameter();
                paramPoints.ParameterName = "@points";
                paramPoints.Value = points;
                command.Parameters.Add(paramPoints);

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Score> FindAll()
        {
            throw new NotImplementedException();
        }

        public Score FindOne(int id)
        {
            throw new NotImplementedException();
        }
    }
}
