﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
    
namespace HideAndSeek.Views
{
    public partial class HiderPlayForm : Form
    {


        public HiderPlayForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderWoonNorth form = new HiderWoonNorth();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=3&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timer_ingang.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderUHal form = new HiderUHal();
            form.Closed += (s, args) => this.Close();
            form.Show();

            HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchlight&idx=6&switchcmd=On") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            timer_ingang.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e) 
        {
            MyGlobals.endLocationHider = 0;
            this.Hide();

            Hider.HiderEndForm form = new Hider.HiderEndForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void timer_ingang_Tick(object sender, EventArgs e)
        {
            MyGlobals.timeIngangshal += 1;
            timerLabel.Text = MyGlobals.timeIngangshal.ToString();
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
