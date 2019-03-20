using log4net;
using log4net.Config;
using mpp.repository;
using mpp.service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mpp
{
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>  
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        
            string connStr = ConfigurationManager.ConnectionStrings["triathlon"].ToString();
            IDictionary<string, string> props = new SortedList<string, string>();
            props.Add("ConnectionString", connStr);
            RefereeRepository refereeRepository = new RefereeRepository(props);
            RaceRepository raceRepository = new RaceRepository(props);
            LoginService loginService = new LoginService(refereeRepository, raceRepository);
            log.Debug("Start application");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(loginService));

        }
    }
}
