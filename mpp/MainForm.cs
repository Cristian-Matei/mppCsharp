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
    public partial class MainForm : Form
    {
        private Referee referee;
        private ScoringService scoringService;
        private Dictionary<int, int> scores;
        public MainForm(Referee referee)
        {
            InitializeComponent();
            this.referee = referee;
            string connStr = ConfigurationManager.ConnectionStrings["triathlon"].ToString();
            //IDictionary<string, string> props = new SortedList<string, string>();
            IDictionary<string, string> props = DBUtils.getProps();
            ParticipantRepository participantRepository = new ParticipantRepository(props);
            ScoreRepository scoreRepository = new ScoreRepository(props);
            ScoringService scoringService = new ScoringService(participantRepository, scoreRepository);
            this.scoringService = scoringService;
            DataTable dataTable = scoringService.getParticipantsWithScore().Tables[0];
            participantsGridView.DataSource = dataTable;
            scores = new Dictionary<int, int>();
            foreach (int key in scoringService.getIds())
            {
                scores.Add(key, 0);
            }
            refereeNameLabel.Text = "Hello " + this.referee.Username;
        }

        private void participantsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = participantsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            idTextBox.Text = id;
            int intid = int.Parse(id);
            pointsTextBox.Text = scores[intid].ToString();
        }

        private void enterOneResultButton_Click(object sender, EventArgs e)
        {
            scores[int.Parse(idTextBox.Text)] = int.Parse(pointsTextBox.Text);
        }

        private void enterAllResultsButton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<int, int> entry in scores)
            {
                scoringService.UpdateScore(entry.Key, referee.Race.Id, entry.Value);
            }
            participantsGridView.DataSource = scoringService.getParticipantsWithScore().Tables[0];
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(this.referee.Race);
            reportForm.Show();
        }
    }
}
