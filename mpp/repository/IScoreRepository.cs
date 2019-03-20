using mpp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository
{
    interface IScoreRepository : ICrudRepository<int, Score>
    {
        void AddNewScore(int idParticipant, int idRace, int points);
    }
}
