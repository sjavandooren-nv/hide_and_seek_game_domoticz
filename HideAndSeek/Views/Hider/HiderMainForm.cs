using System;
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
	public partial class HiderMainForm : Form
	{
		public HiderMainForm()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            HiderPlayForm form = new HiderPlayForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

		private void btnFloorPlanHider_Click(object sender, EventArgs e)
		{

		}
	}
}
