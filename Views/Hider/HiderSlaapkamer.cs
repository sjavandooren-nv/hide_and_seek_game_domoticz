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
    public partial class HiderSlaapkamer : Form
    {

        public HiderSlaapkamer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUhal_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderKeuken form = new HiderKeuken();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=13&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timer1.Stop();
        }

        private void btn_WoonNorth_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderUHal form = new HiderUHal();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=12&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyGlobals.timeSlaapkamer++;
            timerLabel.Text = MyGlobals.timeSlaapkamer.ToString();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            MyGlobals.endLocationHider = 3;
            this.Hide();

            Hider.HiderEndForm form = new Hider.HiderEndForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
