using mpp.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository
{
    interface IParticipantRepository : ICrudRepository<int, Participant>
    {
        DataSet FindAllOrderedByName();
        DataSet FindAllByRace(Race race);
        List<int> GetIds();
    }
}
