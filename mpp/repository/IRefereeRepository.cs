using mpp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository
{
    public interface IRefereeRepository : ICrudRepository<int, Referee>
    {
        Referee FindRefereeByUsernameAndPassword(string username, string password);
    }
}
