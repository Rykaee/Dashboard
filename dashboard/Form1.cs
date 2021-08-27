using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace dashboard
{
    public partial class Form1 : Form
    {
        public bool logPanel = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (logPanel == true)
            {
                logpanel.Visible = false;
                logPanel = false;
            }else if(logPanel == false)
            {
                logpanel.Visible = true;
                logPanel = true;
            }
            
        }

        private void letsgoButton_Click(object sender, EventArgs e)
        {
            if (usernTextBox.Text == "admin" && passTextBox.Text == "admin")
            {
                logpanel.Visible = false;
                loginButton.Visible = false;
                loggedPanel.Visible = true;
                pictPanel.Visible = true;
                gamerPanel.Visible = true;
                datetimelabel.Visible = true;
                timerForPanel();
            }
        }

        private void letsGobtn_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && logPanel.Equals(true) && usernTextBox.Text == "admin" && passTextBox.Text == "admin")
            {
                logpanel.Visible = false;
                loginButton.Visible = false;
                loggedPanel.Visible = true;
                pictPanel.Visible = true;
                gamerPanel.Visible = true;
                datetimelabel.Visible = true;
                timerForPanel();
            }
        }

        private void timerForPanel()
        {
            DateTime now = DateTime.Now;
            datetimelabel.Text = now.ToString("MMM %d, yyyy");
        }

    }
}
