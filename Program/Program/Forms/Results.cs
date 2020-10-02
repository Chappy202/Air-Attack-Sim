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
        private DataHandler data = new DataHandler();
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
            bool found = false;
            DateTime latest = data.log.Max(r => r.Date);
            foreach (var item in data.log)
            {
                if (item.Date == latest)
                {
                    lblAvoided.Text = item.Avoided.ToString();
                    lblDamage.Text = item.Damage.ToString();
                    lblDescription.Text = values.description;
                    lblEnd.Text = item.End.ToString();
                    lblFuelAfter.Text = item.FuelAfter.ToString();
                    lblFuelBefore.Text = item.FuelBefore.ToString();
                    lblName.Text = item.Obstacle.ToString();
                    lblInvAfter.Text = item.InvAfter.ToString();
                    lblInvBefore.Text = item.InvBefore.ToString();
                    lblTime.Text = item.Date.ToString();
                    lblReason.Text = item.Reason.ToString();
                    lblStart.Text = item.Start.ToString();
                    lblSuccess.Text = item.Success.ToString() + "%";
                    lblTarget.Text = item.Target.ToString();
                    found = true;
                }
            }

            if (found != true)
            {
                MessageBox.Show("Could not find log!");
            }
            //lblAvoided.Text = data.log[0].Avoided.ToString();
            //lblDamage.Text = data.log[0].Damage.ToString();
            //lblDescription.Text = values.description;
            //lblEnd.Text = data.log[0].End.ToString();
            //lblFuelAfter.Text = data.log[0].FuelAfter.ToString();
            //lblFuelBefore.Text = data.log[0].FuelBefore.ToString();
            //lblName.Text = data.log[0].Obstacle.ToString();
            //lblInvAfter.Text = data.log[0].InvAfter.ToString();
            //lblInvBefore.Text = data.log[0].InvBefore.ToString();
            //lblTime.Text = data.log[0].Date.ToString();
            //lblReason.Text = data.log[0].Reason.ToString();
            //lblStart.Text = data.log[0].Start.ToString();
            //lblSuccess.Text = data.log[0].Success.ToString() + "%";
            //lblTarget.Text = data.log[0].Target.ToString();
        }
    }
}
