using mpp.model;
using mpp.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mpp
{
    public partial class LoginForm : Form
    {
        private LoginService service;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(LoginService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Referee referee = service.Authenticate(usernameTextBox.Text, passwordTextBox.Text);
            if (referee == null)
            {
                MessageBox.Show("Incorrect credentials");
            }
            else
            {
                Hide();
               
                MainForm mainForm = new MainForm(referee);
                mainForm.FormClosed += (sen, ev) => { Show(); };
                mainForm.Show();
            }
            
        }
    }
}
