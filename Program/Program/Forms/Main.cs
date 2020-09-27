using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Forms;

namespace Program
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // ##############################################
        // BUTTONS
        // ##############################################

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the canvas?", "Erase all Objects", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            reports.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread planeThread = new Thread(new ThreadStart(movePlane));
            planeThread.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stop = true;
        }

        // ##############################################
        // EVENTS
        // ##############################################

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApp();
        }

        // ##############################################
        // METHODS
        // ##############################################

        public void ExitApp()
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit Simulation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

        public bool stop = false;

        public void movePlane()
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pbxStart.Image = imglObjects.Images[10];
            pbxEnd.Image = imglObjects.Images[4];
            pbxAA.Image = imglObjects.Images[0];
            pbxArtilary.Image = imglObjects.Images[1];
            pbxBuilding.Image = imglObjects.Images[2];
            pbxCafeteria.Image = imglObjects.Images[3];
            pbxHangar.Image = imglObjects.Images[5];
            pbxHQ.Image = imglObjects.Images[6];
            pbxMed.Image = imglObjects.Images[7];
            pbxRadar.Image = imglObjects.Images[9];
            pbxTent.Image = imglObjects.Images[11];
        }
    }
}
