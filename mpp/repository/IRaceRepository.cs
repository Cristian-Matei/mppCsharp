using mpp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository
{
    public interface IRaceRepository : ICrudRepository<int, Race>
    {
        Race FindRaceByReferee(string username);
    }
}
