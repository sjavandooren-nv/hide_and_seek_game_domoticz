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

namespace HideAndSeek
{
	public partial class SeekerMainForm : Form
	{
		private TimeSpan TimeLimit = new TimeSpan(0, 1, 0); // 1 min
		private int PlayTime = 0; //in Miliseconds
		private Timer GlobalTimer;

		public SeekerMainForm(Timer timer)
		{
			InitializeComponent();
			GlobalTimer = timer;
		}

		private void SeekerMainForm_Load(object sender, EventArgs e)
		{
			lblTimer.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", TimeLimit.Minutes, TimeLimit.Seconds, TimeLimit.Milliseconds);
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{
			Timer.Start();
			btnStartGame.Enabled = false;
			//btnCameras.Enabled = true;
			btnShowFloorplan.Enabled = true;
		}

		private void btnShowFloorplan_Click(object sender, EventArgs e)
		{
			this.Visible = false;

			MapForm form = new MapForm();
			form.Closed += (s, args) => this.Visible = true;
			form.RemainingTime = TimeLimit - new TimeSpan(0, 0, 0, 0, PlayTime);
			form.SeekerWon += (s, args) => Timer.Stop();
			form.Show();
		}

		private void btnCameras_Click(object sender, EventArgs e)
		{
			this.Visible = false;

			CamerasForm form = new CamerasForm();
			form.Closed += (s, args) => this.Visible = true;
			//form.RemainingTime = TimeLimit - new TimeSpan(0, 0, 0, 0, PlayTime);
			form.Show();
		}

		private void btnGameStats_Click(object sender, EventArgs e)
		{
			this.Hide();

			StatisticsForm form = new StatisticsForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnGameHistory_Click(object sender, EventArgs e)
		{
			this.Hide();

			HistoryForm form = new HistoryForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			this.Hide();

			SettingsForm form = new SettingsForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			PlayTime = PlayTime + 10;

			TimeSpan timeSpan = TimeLimit - new TimeSpan(0, 0, 0, 0, PlayTime);
			lblTimer.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

			if ((Convert.ToInt32(TimeLimit.TotalMilliseconds) - PlayTime) <= 0)
			{
				Timer.Stop();
				MessageBox.Show("Time is up! \n You lost");
				this.Close();
			}
		}
	}
}
