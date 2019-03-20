using mpp.model;
using mpp.repository;
using mpp.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mpp
{
    public partial class ReportForm : Form
    {
        private Referee referee;
        private Race race;
        private ScoringService scoringService;
        public ReportForm(Race race)
        {
            InitializeComponent();
            this.race = race;
            string connStr = ConfigurationManager.ConnectionStrings["triathlon"].ToString();
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", connStr);
            ParticipantRepository participantRepository = new ParticipantRepository(props);
            ScoreRepository scoreRepository = new ScoreRepository(props);
            ScoringService scoringService = new ScoringService(participantRepository, scoreRepository);
            this.scoringService = scoringService;
            DataTable dataTable = scoringService.generateReport(this.race).Tables[0];
            dataGridView1.DataSource = dataTable;
        }
    }
}
