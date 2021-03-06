﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace HideAndSeek.Views
{
    public partial class HiderWoonSouth : Form
    {

        public HiderWoonSouth()
        {
            InitializeComponent();
        }

        private void btnUhal_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderUHal form = new HiderUHal();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=11&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timer1.Stop();
        }

        private void HiderWoonSouth_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyGlobals.timeWoonSouth++;
            timerLabel.Text = MyGlobals.timeWoonSouth.ToString();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            MyGlobals.endLocationHider = 7;
            this.Hide();

            Hider.HiderEndForm form = new Hider.HiderEndForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
