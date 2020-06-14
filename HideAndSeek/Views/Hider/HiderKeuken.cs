using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace HideAndSeek.Views
{
    public partial class HiderKeuken : Form
    {
        public HiderKeuken()
        {
            InitializeComponent();
        }

        private void btnUhal_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderSlaapkamer form = new HiderSlaapkamer();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=13&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timerKeuken.Stop();
        }

        private void btn_WoonNorth_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderWoonMiddle form = new HiderWoonMiddle();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=10&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timerKeuken.Stop();
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }

        private void timerKeuken_Tick(object sender, EventArgs e)
        {
            MyGlobals.timeKeuken++;
            timerLabel.Text = MyGlobals.timeKeuken.ToString();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            MyGlobals.endLocationHider = 2;
            this.Hide();

            Hider.HiderEndForm form = new Hider.HiderEndForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
