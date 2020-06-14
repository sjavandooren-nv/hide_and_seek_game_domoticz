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
    public partial class HiderInloopkast : Form
    {
        public HiderInloopkast()
        {
            InitializeComponent();
        }

        private void btn_WoonNorth_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderWoonNorth form = new HiderWoonNorth();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=9&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyGlobals.timeInloopkast++;
            timerLabel.Text = MyGlobals.timeInloopkast.ToString();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            MyGlobals.endLocationHider = 1;
            this.Hide();

            Hider.HiderEndForm form = new Hider.HiderEndForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
