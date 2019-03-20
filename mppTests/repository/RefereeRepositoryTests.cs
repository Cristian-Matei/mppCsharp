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
    public class RefereeRepositoryTests
    {
        [TestMethod()]
        public void FindOneTest()
        {
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", "server=localhost;user=root;database=mpp;port=3306;password=root");
            RefereeRepository repository = new RefereeRepository(props);
            Referee referee = repository.FindOne(1);
            Assert.AreEqual(referee.FirstName, "Jane");
        }

        [TestMethod()]
        public void FindRefereeByUsernameAndPasswordTest()
        {
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", "server=localhost;user=root;database=mpp;port=3306;password=root");
            RefereeRepository repository = new RefereeRepository(props);
            Referee referee = repository.FindRefereeByUsernameAndPassword("john", "1234");
            Assert.AreEqual(referee.FirstName, "John");
        }
    }
}