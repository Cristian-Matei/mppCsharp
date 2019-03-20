using mpp.model;
using mpp.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mpp.service
{
    class ScoringService
    {
        private ParticipantRepository participantRepository;
        private ScoreRepository scoreRepository;

        public ScoringService(ParticipantRepository participantRepository, ScoreRepository scoreRepository)
        {
            this.participantRepository = participantRepository;
            this.scoreRepository = scoreRepository;
        }

        public DataSet getParticipantsWithScore()
        {
            return participantRepository.FindAllOrderedByName();
        }

        public DataSet generateReport(Race race)
        {
            return participantRepository.FindAllByRace(race);
        }

        public List<int> getIds()
        {
            return participantRepository.GetIds();
        }

        public void UpdateScore(int pId, int rId, int points)
        {
            scoreRepository.AddNewScore(pId, rId, points);
        }
    }
}
