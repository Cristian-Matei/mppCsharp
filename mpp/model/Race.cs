using mpp.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.model
{
    public class Race : IHasId<int>
    {
        public int Id { get; set; }

        public string Name
        {
            get; set;
        }

        public Referee Referee
        {
            get; set;
        }
    }
}
