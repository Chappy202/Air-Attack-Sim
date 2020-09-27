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
        // GLOBAL VARIABLES
        // ##############################################
        public string selectedPlane = "None";
        public string[] planes = new string[]{ "pbxLockheed", "pbxBoeingp8", "pbxDessault", "pbxBoeinEa" };


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

        private void pbxLockheed_Click(object sender, EventArgs e)
        {
            if (selectedPlane == "None")
            {
                selectedPlane = "pbxLockheed";
                pbxLockheed.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "pbxLockheed";
                pbxLockheed.BackColor = Color.LightGreen;
                updatePlaneSelection();
            }
            
        }

        private void pbxBoeingp8_Click(object sender, EventArgs e)
        {
            if (selectedPlane == "None")
            {
                selectedPlane = "pbxBoeingp8";
                pbxBoeingp8.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "pbxBoeingp8";
                pbxBoeingp8.BackColor = Color.LightGreen;
                updatePlaneSelection();
            }
        }

        private void pbxDessault_Click(object sender, EventArgs e)
        {
            if (selectedPlane == "None")
            {
                selectedPlane = "pbxDessault";
                pbxDessault.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "pbxDessault";
                pbxDessault.BackColor = Color.LightGreen;
                updatePlaneSelection();
            }

        }

        private void pbxBoeinEa_Click(object sender, EventArgs e)
        {
            if (selectedPlane == "None")
            {
                selectedPlane = "pbxBoeinEa";
                pbxBoeinEa.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "pbxBoeinEa";
                pbxBoeinEa.BackColor = Color.LightGreen;
                updatePlaneSelection();
            }
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

        public void updatePlaneSelection()
        {
            if (selectedPlane == planes[0])
            {
                pbxBoeingp8.BackColor = Color.LightBlue;
            }
            else if (selectedPlane == planes[1])
            {
                pbxBoeinEa.BackColor = Color.LightBlue;
            }
            else if (selectedPlane == planes[2])
            {
                pbxDessault.BackColor = Color.LightBlue;
            }
            else if (selectedPlane == planes[3])
            {
                pbxLockheed.BackColor = Color.LightBlue;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Assign objects
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

            // Assign planes
            pbxLockheed.Image = imglPlanes.Images[3];
            pbxBoeingp8.Image = imglPlanes.Images[0];
            pbxDessault.Image = imglPlanes.Images[2];
            pbxBoeinEa.Image = imglPlanes.Images[1];
        }
    }
}
