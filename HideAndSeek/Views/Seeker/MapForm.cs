using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek.Views
{
	public partial class MapForm : Form
	{
		public TimeSpan RemainingTime { get; set; }
		private int PlayTime = 0;

		public MapForm()
		{
			InitializeComponent();
		}

		private void MapForm_Load(object sender, EventArgs e)
		{
			lblTimer.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", RemainingTime.Minutes, RemainingTime.Seconds, RemainingTime.Milliseconds);
			Timer.Start();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Room Chosen");
		}

		private void btnLivingRoomMiddle_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromArgb(0, 247, 255);
			btnCloset.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomNorth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnKitchen.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnEntryHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnBedroom.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnUHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomSouth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnChoose.Enabled = true;
		}

		private void btnCloset_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnCloset.BackColor = Color.FromArgb(0, 247, 255);
			btnLivingRoomNorth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnKitchen.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnEntryHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnBedroom.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnUHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomSouth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnChoose.Enabled = true;
		}

		private void btnLivingRoomNorth_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnCloset.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomNorth.BackColor = Color.FromArgb(0, 247, 255);
			btnKitchen.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnEntryHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnBedroom.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnUHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomSouth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnChoose.Enabled = true;
		}

		private void btnKitchen_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnCloset.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomNorth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnKitchen.BackColor = Color.FromArgb(0, 247, 255);
			btnEntryHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnBedroom.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnUHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomSouth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnChoose.Enabled = true;
		}

		private void btnEntryHall_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnCloset.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomNorth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnKitchen.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnEntryHall.BackColor = Color.FromArgb(0, 247, 255);
			btnBedroom.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnUHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomSouth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnChoose.Enabled = true;
		}

		private void btnBedroom_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnCloset.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomNorth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnKitchen.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnEntryHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnBedroom.BackColor = Color.FromArgb(0, 247, 255);
			btnUHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomSouth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnChoose.Enabled = true;
		}

		private void btnUHall_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnCloset.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomNorth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnKitchen.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnEntryHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnBedroom.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnUHall.BackColor = Color.FromArgb(0, 247, 255);
			btnLivingRoomSouth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnChoose.Enabled = true;
		}

		private void btnLivingRoomSouth_Click(object sender, EventArgs e)
		{
			btnLivingRoomMiddle.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnCloset.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomNorth.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnKitchen.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnEntryHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnBedroom.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnUHall.BackColor = Color.FromKnownColor(KnownColor.Control);
			btnLivingRoomSouth.BackColor = Color.FromArgb(0, 247, 255);
			btnChoose.Enabled = true;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			PlayTime = PlayTime + 10;

			TimeSpan timeSpan = RemainingTime - new TimeSpan(0, 0, 0, 0, PlayTime);
			lblTimer.Text = string.Format("{0:D2}:{1:D2}.{2:D3}", timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

			if ((Convert.ToInt32(RemainingTime.TotalMilliseconds) - PlayTime) <= 0)
			{
				Timer.Stop();
			}
		}
	}
}
