using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.utils
{
    public interface IHasId <T>
    {
        T Id { get; set; }
    }
}
