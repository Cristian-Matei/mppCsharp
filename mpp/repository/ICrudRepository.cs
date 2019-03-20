using mpp.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository
{
    public interface ICrudRepository<ID, E> where E : IHasId<ID>
    {
        E FindOne(ID id);
        IEnumerable<E> FindAll();
    }
}
