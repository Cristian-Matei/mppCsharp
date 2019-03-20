using Microsoft.VisualStudio.TestTools.UnitTesting;
using mpp.model;
using mpp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.repository.Tests
{
    [TestClass()]
    public class RaceRepositoryTests
    {
        [TestMethod()]
        public void FindRaceByRefereeTest()
        {
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", "server=localhost;user=root;database=mpp;port=3306;password=root");
            RaceRepository repository = new RaceRepository(props);
            Race race = repository.FindRaceByReferee("jane");
            Assert.AreEqual(race.Name, "swimming");
        }

    }
}