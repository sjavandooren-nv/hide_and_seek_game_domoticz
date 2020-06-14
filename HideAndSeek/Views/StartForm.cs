using HideAndSeek.Views;
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
using System.Threading;

namespace HideAndSeek
{
	public partial class StartForm : Form
	{
		private Thread SeekerThread;
		private Thread HiderThread;

		public StartForm()
		{
			InitializeComponent();
		}

		private void StartForm_Load(object sender, EventArgs e)
		{

		}

		private void btnSeeker_Click(object sender, EventArgs e)
		{
			SeekerThread = new Thread(StartSeeker);
			SeekerThread.SetApartmentState(ApartmentState.STA);
			SeekerThread.Start();
		}

		private void btnHider_Click(object sender, EventArgs e)
		{
			HiderThread = new Thread(StartHider);
			HiderThread.SetApartmentState(ApartmentState.STA);
			HiderThread.Start();
		}
		
		private void StartSeeker(object obj)
		{
			Application.Run(new SeekerMainForm());
		}

		private void StartHider(object obj)
		{
			Application.Run(new HiderMainForm());

			HttpWebRequest request = WebRequest.Create("http://127.0.0.1:8080/json.htm?type=command&param=switchscene&idx=1&switchcmd=On") as HttpWebRequest;
			HttpWebResponse response = request.GetResponse() as HttpWebResponse;
			Stream stream = response.GetResponseStream();
			StreamReader reader = new StreamReader(stream);
		}
	}
}
