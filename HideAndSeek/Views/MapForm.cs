﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek.Views
{
	public partial class MapForm : Form
	{
		public MapForm()
		{
			InitializeComponent();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			this.Hide();

			SeekerMainForm form = new SeekerMainForm();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{

		}
	}
}
