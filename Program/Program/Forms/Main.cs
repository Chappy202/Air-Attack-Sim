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

        // Object variable
        public int imageSet = 10;

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
            pbx1.Tag = imglObjects.Images.Keys[3];
            foreach (var item in imglObjects.Images.Keys)
            {
                if (pbx1.Tag.ToString() == item)
                {
                    MessageBox.Show("Match!");
                    MessageBox.Show(pbx1.Tag.ToString());
                }
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
        // ##############################################
        // OBJECT TOOLTIPS
        // ##############################################
        private void pbxStart_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxStart, "Start");
        }

        private void pbxEnd_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxEnd, "End");
        }

        private void pbxAA_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxAA, "Anti-Air");
        }

        private void pbxHQ_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxHQ, "Headquarters");
        }

        private void pbxMed_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxMed, "Medical Bay");
        }

        private void pbxHangar_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxHangar, "Hangar");
        }

        private void pbxArtilary_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxArtilary, "Artillery");
        }

        private void pbxTent_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxTent, "Tent");
        }

        private void pbxRadar_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxRadar, "Radar");
        }

        private void pbxCafeteria_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxCafeteria, "Cafeteria");
        }

        private void pbxBuilding_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxBuilding, "Building");
        }

        // ##############################################
        // PLANE TOOLTIPS
        // ##############################################
        private void pbxLockheed_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxLockheed, "Lockheed");
        }

        private void pbxBoeingp8_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxBoeingp8, "Boeing P 8");
        }

        private void pbxDessault_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxDessault, "Dessault");
        }

        private void pbxBoeinEa_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbxBoeinEa, "Boeing EA");
        }

        // ##############################################
        // OBJECT SELECT
        // ##############################################
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

        // ##############################################
        // CANVAS ASSIGN
        // ##############################################

        private void pbx1_Click(object sender, EventArgs e)
        {
            pbx1.Image = imglObjects.Images[imageSet];
            pbx1.Tag = imglObjects.Images.Keys[imageSet];
        }
        private void pbx2_Click(object sender, EventArgs e)
        {
            pbx2.Image = imglObjects.Images[imageSet];
            pbx2.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx3_Click(object sender, EventArgs e)
        {
            pbx3.Image = imglObjects.Images[imageSet];
            pbx3.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx4_Click(object sender, EventArgs e)
        {
            pbx4.Image = imglObjects.Images[imageSet];
            pbx4.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx5_Click(object sender, EventArgs e)
        {
            pbx5.Image = imglObjects.Images[imageSet];
            pbx5.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx6_Click(object sender, EventArgs e)
        {
            pbx6.Image = imglObjects.Images[imageSet];
            pbx6.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx7_Click(object sender, EventArgs e)
        {
            pbx7.Image = imglObjects.Images[imageSet];
            pbx7.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx8_Click(object sender, EventArgs e)
        {
            pbx8.Image = imglObjects.Images[imageSet];
            pbx8.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx9_Click(object sender, EventArgs e)
        {
            pbx9.Image = imglObjects.Images[imageSet];
            pbx9.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx10_Click(object sender, EventArgs e)
        {
            pbx10.Image = imglObjects.Images[imageSet];
            pbx10.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx11_Click(object sender, EventArgs e)
        {
            pbx11.Image = imglObjects.Images[imageSet];
            pbx11.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx12_Click(object sender, EventArgs e)
        {
            pbx12.Image = imglObjects.Images[imageSet];
            pbx12.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx13_Click(object sender, EventArgs e)
        {
            pbx13.Image = imglObjects.Images[imageSet];
            pbx13.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx14_Click(object sender, EventArgs e)
        {
            pbx14.Image = imglObjects.Images[imageSet];
            pbx14.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx15_Click(object sender, EventArgs e)
        {
            pbx15.Image = imglObjects.Images[imageSet];
            pbx15.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx16_Click(object sender, EventArgs e)
        {
            pbx16.Image = imglObjects.Images[imageSet];
            pbx16.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx17_Click(object sender, EventArgs e)
        {
            pbx17.Image = imglObjects.Images[imageSet];
            pbx17.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx18_Click(object sender, EventArgs e)
        {
            pbx18.Image = imglObjects.Images[imageSet];
            pbx18.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx19_Click(object sender, EventArgs e)
        {
            pbx19.Image = imglObjects.Images[imageSet];
            pbx19.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx20_Click(object sender, EventArgs e)
        {
            pbx20.Image = imglObjects.Images[imageSet];
            pbx20.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx21_Click(object sender, EventArgs e)
        {
            pbx21.Image = imglObjects.Images[imageSet];
            pbx21.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx22_Click(object sender, EventArgs e)
        {
            pbx22.Image = imglObjects.Images[imageSet];
            pbx22.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx23_Click(object sender, EventArgs e)
        {
            pbx23.Image = imglObjects.Images[imageSet];
            pbx23.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx24_Click(object sender, EventArgs e)
        {
            pbx24.Image = imglObjects.Images[imageSet];
            pbx24.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx25_Click(object sender, EventArgs e)
        {
            pbx25.Image = imglObjects.Images[imageSet];
            pbx25.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx26_Click(object sender, EventArgs e)
        {
            pbx26.Image = imglObjects.Images[imageSet];
            pbx26.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx27_Click(object sender, EventArgs e)
        {
            pbx27.Image = imglObjects.Images[imageSet];
            pbx27.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx28_Click(object sender, EventArgs e)
        {
            pbx28.Image = imglObjects.Images[imageSet];
            pbx28.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx29_Click(object sender, EventArgs e)
        {
            pbx29.Image = imglObjects.Images[imageSet];
            pbx29.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx30_Click(object sender, EventArgs e)
        {
            pbx30.Image = imglObjects.Images[imageSet];
            pbx30.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx31_Click(object sender, EventArgs e)
        {
            pbx31.Image = imglObjects.Images[imageSet];
            pbx31.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx32_Click(object sender, EventArgs e)
        {
            pbx32.Image = imglObjects.Images[imageSet];
            pbx32.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx33_Click(object sender, EventArgs e)
        {
            pbx33.Image = imglObjects.Images[imageSet];
            pbx33.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx34_Click(object sender, EventArgs e)
        {
            pbx34.Image = imglObjects.Images[imageSet];
            pbx34.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx35_Click(object sender, EventArgs e)
        {
            pbx35.Image = imglObjects.Images[imageSet];
            pbx35.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx36_Click(object sender, EventArgs e)
        {
            pbx36.Image = imglObjects.Images[imageSet];
            pbx36.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx37_Click(object sender, EventArgs e)
        {
            pbx37.Image = imglObjects.Images[imageSet];
            pbx37.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx38_Click(object sender, EventArgs e)
        {
            pbx38.Image = imglObjects.Images[imageSet];
            pbx38.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx39_Click(object sender, EventArgs e)
        {
            pbx39.Image = imglObjects.Images[imageSet];
            pbx39.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx40_Click(object sender, EventArgs e)
        {
            pbx40.Image = imglObjects.Images[imageSet];
            pbx40.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx41_Click(object sender, EventArgs e)
        {
            pbx41.Image = imglObjects.Images[imageSet];
            pbx41.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx42_Click(object sender, EventArgs e)
        {
            pbx42.Image = imglObjects.Images[imageSet];
            pbx42.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx43_Click(object sender, EventArgs e)
        {
            pbx43.Image = imglObjects.Images[imageSet];
            pbx43.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx44_Click(object sender, EventArgs e)
        {
            pbx44.Image = imglObjects.Images[imageSet];
            pbx44.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx45_Click(object sender, EventArgs e)
        {
            pbx45.Image = imglObjects.Images[imageSet];
            pbx45.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx46_Click(object sender, EventArgs e)
        {
            pbx46.Image = imglObjects.Images[imageSet];
            pbx46.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx47_Click(object sender, EventArgs e)
        {
            pbx47.Image = imglObjects.Images[imageSet];
            pbx47.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx48_Click(object sender, EventArgs e)
        {
            pbx48.Image = imglObjects.Images[imageSet];
            pbx48.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx49_Click(object sender, EventArgs e)
        {
            pbx49.Image = imglObjects.Images[imageSet];
            pbx49.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx50_Click(object sender, EventArgs e)
        {
            pbx50.Image = imglObjects.Images[imageSet];
            pbx50.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx51_Click(object sender, EventArgs e)
        {
            pbx51.Image = imglObjects.Images[imageSet];
            pbx51.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx52_Click(object sender, EventArgs e)
        {
            pbx52.Image = imglObjects.Images[imageSet];
            pbx52.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx53_Click(object sender, EventArgs e)
        {
            pbx53.Image = imglObjects.Images[imageSet];
            pbx53.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx54_Click(object sender, EventArgs e)
        {
            pbx54.Image = imglObjects.Images[imageSet];
            pbx54.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx55_Click(object sender, EventArgs e)
        {
            pbx55.Image = imglObjects.Images[imageSet];
            pbx55.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx56_Click(object sender, EventArgs e)
        {
            pbx56.Image = imglObjects.Images[imageSet];
            pbx56.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx57_Click(object sender, EventArgs e)
        {
            pbx57.Image = imglObjects.Images[imageSet];
            pbx57.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx58_Click(object sender, EventArgs e)
        {
            pbx58.Image = imglObjects.Images[imageSet];
            pbx58.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx59_Click(object sender, EventArgs e)
        {
            pbx59.Image = imglObjects.Images[imageSet];
            pbx59.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx60_Click(object sender, EventArgs e)
        {
            pbx60.Image = imglObjects.Images[imageSet];
            pbx60.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx61_Click(object sender, EventArgs e)
        {
            pbx61.Image = imglObjects.Images[imageSet];
            pbx61.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx62_Click(object sender, EventArgs e)
        {
            pbx62.Image = imglObjects.Images[imageSet];
            pbx62.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx63_Click(object sender, EventArgs e)
        {
            pbx63.Image = imglObjects.Images[imageSet];
            pbx63.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx64_Click(object sender, EventArgs e)
        {
            pbx64.Image = imglObjects.Images[imageSet];
            pbx64.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx65_Click(object sender, EventArgs e)
        {
            pbx65.Image = imglObjects.Images[imageSet];
            pbx65.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx66_Click(object sender, EventArgs e)
        {
            pbx66.Image = imglObjects.Images[imageSet];
            pbx66.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx67_Click(object sender, EventArgs e)
        {
            pbx67.Image = imglObjects.Images[imageSet];
            pbx67.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx68_Click(object sender, EventArgs e)
        {
            pbx68.Image = imglObjects.Images[imageSet];
            pbx68.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx69_Click(object sender, EventArgs e)
        {
            pbx69.Image = imglObjects.Images[imageSet];
            pbx69.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx70_Click(object sender, EventArgs e)
        {
            pbx70.Image = imglObjects.Images[imageSet];
            pbx70.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx71_Click(object sender, EventArgs e)
        {
            pbx71.Image = imglObjects.Images[imageSet];
            pbx71.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx72_Click(object sender, EventArgs e)
        {
            pbx72.Image = imglObjects.Images[imageSet];
            pbx72.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx73_Click(object sender, EventArgs e)
        {
            pbx73.Image = imglObjects.Images[imageSet];
            pbx73.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx74_Click(object sender, EventArgs e)
        {
            pbx74.Image = imglObjects.Images[imageSet];
            pbx74.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx75_Click(object sender, EventArgs e)
        {
            pbx75.Image = imglObjects.Images[imageSet];
            pbx75.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx76_Click(object sender, EventArgs e)
        {
            pbx76.Image = imglObjects.Images[imageSet];
            pbx76.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx77_Click(object sender, EventArgs e)
        {
            pbx77.Image = imglObjects.Images[imageSet];
            pbx77.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx78_Click(object sender, EventArgs e)
        {
            pbx78.Image = imglObjects.Images[imageSet];
            pbx78.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx79_Click(object sender, EventArgs e)
        {
            pbx79.Image = imglObjects.Images[imageSet];
            pbx79.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx80_Click(object sender, EventArgs e)
        {
            pbx80.Image = imglObjects.Images[imageSet];
            pbx80.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx81_Click(object sender, EventArgs e)
        {
            pbx81.Image = imglObjects.Images[imageSet];
            pbx81.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx82_Click(object sender, EventArgs e)
        {
            pbx82.Image = imglObjects.Images[imageSet];
            pbx82.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx83_Click(object sender, EventArgs e)
        {
            pbx83.Image = imglObjects.Images[imageSet];
            pbx83.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx84_Click(object sender, EventArgs e)
        {
            pbx84.Image = imglObjects.Images[imageSet];
            pbx84.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx85_Click(object sender, EventArgs e)
        {
            pbx85.Image = imglObjects.Images[imageSet];
            pbx85.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx86_Click(object sender, EventArgs e)
        {
            pbx86.Image = imglObjects.Images[imageSet];
            pbx86.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx87_Click(object sender, EventArgs e)
        {
            pbx87.Image = imglObjects.Images[imageSet];
            pbx87.Tag = imglObjects.Images.Keys[imageSet];
        }

        private void pbx88_Click(object sender, EventArgs e)
        {
            pbx88.Image = imglObjects.Images[imageSet];
            pbx88.Tag = imglObjects.Images.Keys[imageSet];
        }
    }
}
