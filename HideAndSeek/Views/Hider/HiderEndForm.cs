using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideAndSeek.Views.Hider
{
    public partial class HiderEndForm : Form
    {
        public HiderEndForm()
        {
            InitializeComponent();

            if (MyGlobals.endLocationHider == 0)
            {
                label3.Text = "Ingangshal.";
            }
            else if (MyGlobals.endLocationHider == 1)
            {
                label3.Text = "Inloopkast.";
            }
            else if (MyGlobals.endLocationHider == 2)
            {
                label3.Text = "Keuken.";
            }
            else if (MyGlobals.endLocationHider == 3)
            {
                label3.Text = "Slaapkamer.";
            }
            else if (MyGlobals.endLocationHider == 4)
            {
                label3.Text = "U-hal.";
            }
            else if (MyGlobals.endLocationHider == 5)
            {
                label3.Text = "Woonruimte Middle.";
            }
            else if (MyGlobals.endLocationHider == 6)
            {
                label3.Text = "Woonruimte North.";
            }
            else
            {
                label3.Text = "Woonruimte South.";
            }

            label13.Text = MyGlobals.timeIngangshal.ToString();
            label14.Text = MyGlobals.timeInloopkast.ToString();
            label15.Text = MyGlobals.timeKeuken.ToString();
            label16.Text = MyGlobals.timeSlaapkamer.ToString();
            label17.Text = MyGlobals.timeUHal.ToString();
            label18.Text = MyGlobals.timeWoonMiddle.ToString();
            label19.Text = MyGlobals.timeWoonNorth.ToString();
            label20.Text = MyGlobals.timeWoonSouth.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
