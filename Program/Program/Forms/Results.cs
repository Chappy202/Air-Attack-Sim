using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Classes;

namespace Program.Forms
{
    public partial class frmResults : Form
    {
        public frmResults()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResults_Load(object sender, EventArgs e)
        {
            Globals values = new Globals();
            lblAvoided.Text = values.avoided.ToString();
            lblDamage.Text = values.damage.ToString();
            lblDescription.Text = values.description;
            lblEnd.Text = values.end;
            lblFuelAfter.Text = values.fuelafter.ToString();
            lblFuelBefore.Text = values.fuelbefore.ToString();
            lblName.Text = values.targetname;
            lblInvAfter.Text = values.invafter.ToString();
            lblInvBefore.Text = values.invbefore.ToString();
            lblTime.Text = values.time;
            lblReason.Text = values.reason;
            lblStart.Text = values.start;
            lblSuccess.Text = values.success.ToString() + "%";
            lblTarget.Text = values.target;
        }
    }
}
