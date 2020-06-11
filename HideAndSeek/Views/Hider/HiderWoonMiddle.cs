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
    public partial class HiderWoonMiddle : Form
    {
        public HiderWoonMiddle()
        {
            InitializeComponent();
        }

        private void btn_WoonNorth_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderKeuken form = new HiderKeuken();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=10&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
        }

        private void btnUhal_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderUHal form = new HiderUHal();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=15&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
        }
    }
}
