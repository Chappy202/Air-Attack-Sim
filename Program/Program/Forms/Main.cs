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
        // Some useless code
        public int imageSet;

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
            //Add all picture boxes to an array to sort through easily
            PictureBox[] boxes = { pbx1, pbx2, pbx3, pbx4, pbx5, pbx6, pbx7, pbx8, pbx9, pbx10, pbx11, pbx12, pbx13, pbx14, pbx15, pbx16, pbx17, pbx18, pbx19, pbx20, pbx21, pbx22, pbx23, pbx24, pbx25, pbx26, pbx27, pbx28, pbx29, pbx30, pbx31, pbx32, pbx33, pbx34, pbx35, pbx36, pbx37, pbx38, pbx39, pbx40, pbx40, pbx41, pbx42, pbx43, pbx44, pbx45, pbx46, pbx47, pbx48, pbx48, pbx49, pbx50, pbx51, pbx52, pbx53, pbx54, pbx55, pbx56, pbx57, pbx58, pbx58, pbx59, pbx60, pbx61, pbx62, pbx63, pbx64, pbx65, pbx66, pbx67, pbx68, pbx69, pbx70, pbx71, pbx72, pbx73, pbx74, pbx75, pbx76, pbx77, pbx78, pbx79, pbx80, pbx81, pbx82, pbx83, pbx84, pbx85, pbx86, pbx87, pbx88 };

            //Checks whether a picture box has an obsticle or not
            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i].Image != null) 
                {
                    //Pathfinding code for plane to not hit or fly over obstacles
                }
            }

            pbx1.Image = imglObjects.Images[3];
            if (pbx1.Image == imglObjects.Images[3])
            {
                MessageBox.Show("Match!");
            }
            else
            {
                MessageBox.Show("No match!");
                //MessageBox.Show((pbx1.Image.);
            }
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

        private void pbx1_Click(object sender, EventArgs e)
        {
            pbx1.Image = imglObjects.Images[imageSet];
        }

        //Objects set
        private void pbxStart_Click(object sender, EventArgs e)
        {
            imageSet = 10;
        }

        private void pbxEnd_Click(object sender, EventArgs e)
        {
            imageSet = 4;
        }

        private void pbxAA_Click(object sender, EventArgs e)
        {
            imageSet = 0;

        }

        private void pbxHQ_Click(object sender, EventArgs e)
        {
            imageSet = 6;
        }

        private void pbxMed_Click(object sender, EventArgs e)
        {
            imageSet = 7;
        }

        private void pbxHangar_Click(object sender, EventArgs e)
        {
            imageSet = 5;
        }

        private void pbxArtilary_Click(object sender, EventArgs e)
        {
            imageSet = 1;
        }

        private void pbxTent_Click(object sender, EventArgs e)
        {
            imageSet = 11;
        }

        private void pbxRadar_Click(object sender, EventArgs e)
        {
            imageSet = 9;
        }

        private void pbxCafeteria_Click(object sender, EventArgs e)
        {
            imageSet = 3;
        }

        private void pbxBuilding_Click(object sender, EventArgs e)
        {
            imageSet = 2;
        }
    }
}
