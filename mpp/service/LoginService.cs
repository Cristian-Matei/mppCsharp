using mpp.model;
using mpp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.service
{
    public class LoginService
    {
        private RefereeRepository refereeRepository;
        private RaceRepository raceRepository;

        public LoginService(RefereeRepository refereeRepository, RaceRepository raceRepository)
        {
            this.refereeRepository = refereeRepository;
            this.raceRepository = raceRepository;
        }

        public Referee Authenticate (string username, string password)
        {
            Referee referee = refereeRepository.FindRefereeByUsernameAndPassword(username, password);
            Race race = raceRepository.FindRaceByReferee(username);
            if (referee == null || race == null)
                return null;
            race.Referee = referee;
            referee.Race = race;
            return referee;
        }
    }
}
