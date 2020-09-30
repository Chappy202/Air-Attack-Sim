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
using Program.Classes;
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
                foreach (PictureBox image in flpnlCanvas.Controls)
                {
                    if (image.Image != null)
                    {
                        image.Image = null;
                    }
                }
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

            Movement anim = new Movement();
            GenerateMap map = new GenerateMap();
            map.CreateMap(flpnlCanvas);
            anim.MovePlane(pbxBoeingp8, flpnlCanvas);
            anim.Move(pbxBoeingp8, pbxBoeingp8.Location.X, pbxBoeingp8.Location.Y);
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
            pbxStart.Tag = imglObjects.Images.Keys[10];
            pbxEnd.Image = imglObjects.Images[4];
            pbxEnd.Tag = imglObjects.Images.Keys[4];
            pbxAA.Image = imglObjects.Images[0];
            pbxAA.Tag = imglObjects.Images.Keys[0];
            pbxArtilary.Image = imglObjects.Images[1];
            pbxArtilary.Tag = imglObjects.Images[1];
            pbxBuilding.Image = imglObjects.Images[2];
            pbxBuilding.Tag = imglObjects.Images.Keys[2];
            pbxCafeteria.Image = imglObjects.Images[3];
            pbxCafeteria.Tag = imglObjects.Images.Keys[3];
            pbxHangar.Image = imglObjects.Images[5];
            pbxHangar.Tag = imglObjects.Images.Keys[5];
            pbxHQ.Image = imglObjects.Images[6];
            pbxHQ.Tag = imglObjects.Images.Keys[6];
            pbxMed.Image = imglObjects.Images[7];
            pbxMed.Tag = imglObjects.Images.Keys[7];
            pbxRadar.Image = imglObjects.Images[9];
            pbxRadar.Tag = imglObjects.Images.Keys[9];
            pbxTent.Image = imglObjects.Images[11];
            pbxTent.Tag = imglObjects.Images.Keys[11];
            pbxClear.Image = imglObjects.Images[12];
            pbxClear.Tag = imglObjects.Images.Keys[12];

            // Assign planes
            pbxLockheed.Image = imglPlanes.Images[3];
            pbxLockheed.Tag = imglPlanes.Images.Keys[3];
            pbxBoeingp8.Image = imglPlanes.Images[0];
            pbxBoeingp8.Tag = imglPlanes.Images.Keys[0];
            pbxDessault.Image = imglPlanes.Images[2];
            pbxDessault.Tag = imglPlanes.Images.Keys[2];
            pbxBoeinEa.Image = imglPlanes.Images[1];
            pbxBoeinEa.Tag = imglPlanes.Images.Keys[1];
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

        private void pbxClear_Click(object sender, EventArgs e)
        {
            imageSet = 12;
        }

        // ##############################################
        // CANVAS ASSIGN
        // ##############################################

        private void pbx1_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx1.Image = null;
                pbx1.Tag = null;
            }
            else
            {
                pbx1.Image = imglObjects.Images[imageSet];
                pbx1.Tag = imglObjects.Images.Keys[imageSet];
            }
        }
        private void pbx2_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx2.Image = null;
                pbx2.Tag = null;
            }
            else
            {
                pbx2.Image = imglObjects.Images[imageSet];
                pbx2.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx3_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx3.Image = null;
                pbx3.Tag = null;
            }
            else
            {
                pbx3.Image = imglObjects.Images[imageSet];
                pbx3.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx4_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx4.Image = null;
                pbx4.Tag = null;
            }
            else
            {
                pbx4.Image = imglObjects.Images[imageSet];
                pbx4.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx5_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx5.Image = null;
                pbx5.Tag = null;
            }
            else
            {
                pbx5.Image = imglObjects.Images[imageSet];
                pbx5.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx6_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx6.Image = null;
                pbx6.Tag = null;
            }
            else
            {
                pbx6.Image = imglObjects.Images[imageSet];
                pbx6.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx7_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx7.Image = null;
                pbx7.Tag = null;
            }
            else
            {
                pbx7.Image = imglObjects.Images[imageSet];
                pbx7.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx8_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx8.Image = null;
                pbx8.Tag = null;
            }
            else
            {
                pbx8.Image = imglObjects.Images[imageSet];
                pbx8.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx9_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx9.Image = null;
                pbx9.Tag = null;
            }
            else
            {
                pbx9.Image = imglObjects.Images[imageSet];
                pbx9.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx10_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx10.Image = null;
                pbx10.Tag = null;
            }
            else
            {
                pbx10.Image = imglObjects.Images[imageSet];
                pbx10.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx11_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx11.Image = null;
                pbx11.Tag = null;
            }
            else
            {
                pbx11.Image = imglObjects.Images[imageSet];
                pbx11.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx12_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx12.Image = null;
                pbx12.Tag = null;
            }
            else
            {
                pbx12.Image = imglObjects.Images[imageSet];
                pbx12.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx13_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx13.Image = null;
                pbx13.Tag = null;
            }
            else
            {
                pbx13.Image = imglObjects.Images[imageSet];
                pbx13.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx14_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx14.Image = null;
                pbx14.Tag = null;
            }
            else
            {
                pbx14.Image = imglObjects.Images[imageSet];
                pbx14.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx15_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx15.Image = null;
                pbx15.Tag = null;
            }
            else
            {
                pbx15.Image = imglObjects.Images[imageSet];
                pbx15.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx16_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx16.Image = null;
                pbx16.Tag = null;
            }
            else
            {
                pbx16.Image = imglObjects.Images[imageSet];
                pbx16.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx17_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx17.Image = null;
                pbx17.Tag = null;
            }
            else
            {
                pbx17.Image = imglObjects.Images[imageSet];
                pbx17.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx18_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx18.Image = null;
                pbx18.Tag = null;
            }
            else
            {
                pbx18.Image = imglObjects.Images[imageSet];
                pbx18.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx19_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx19.Image = null;
                pbx19.Tag = null;
            }
            else
            {
                pbx19.Image = imglObjects.Images[imageSet];
                pbx19.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx20_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx20.Image = null;
                pbx20.Tag = null;
            }
            else
            {
                pbx20.Image = imglObjects.Images[imageSet];
                pbx20.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx21_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx21.Image = null;
                pbx21.Tag = null;
            }
            else
            {
                pbx21.Image = imglObjects.Images[imageSet];
                pbx21.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx22_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx22.Image = null;
                pbx22.Tag = null;
            }
            else
            {
                pbx22.Image = imglObjects.Images[imageSet];
                pbx22.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx23_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx23.Image = null;
                pbx23.Tag = null;
            }
            else
            {
                pbx23.Image = imglObjects.Images[imageSet];
                pbx23.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx24_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx24.Image = null;
                pbx24.Tag = null;
            }
            else
            {
                pbx24.Image = imglObjects.Images[imageSet];
                pbx24.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx25_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx25.Image = null;
                pbx25.Tag = null;
            }
            else
            {
                pbx25.Image = imglObjects.Images[imageSet];
                pbx25.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx26_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx26.Image = null;
                pbx26.Tag = null;
            }
            else
            {
                pbx26.Image = imglObjects.Images[imageSet];
                pbx26.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx27_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx27.Image = null;
                pbx27.Tag = null;
            }
            else
            {
                pbx27.Image = imglObjects.Images[imageSet];
                pbx27.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx28_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx28.Image = null;
                pbx28.Tag = null;
            }
            else
            {
                pbx28.Image = imglObjects.Images[imageSet];
                pbx28.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx29_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx29.Image = null;
                pbx29.Tag = null;
            }
            else
            {
                pbx29.Image = imglObjects.Images[imageSet];
                pbx29.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx30_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx30.Image = null;
                pbx30.Tag = null;
            }
            else
            {
                pbx30.Image = imglObjects.Images[imageSet];
                pbx30.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx31_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx31.Image = null;
                pbx31.Tag = null;
            }
            else
            {
                pbx31.Image = imglObjects.Images[imageSet];
                pbx31.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx32_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx32.Image = null;
                pbx32.Tag = null;
            }
            else
            {
                pbx32.Image = imglObjects.Images[imageSet];
                pbx32.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx33_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx33.Image = null;
                pbx33.Tag = null;
            }
            else
            {
                pbx33.Image = imglObjects.Images[imageSet];
                pbx33.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx34_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx34.Image = null;
                pbx34.Tag = null;
            }
            else
            {
                pbx34.Image = imglObjects.Images[imageSet];
                pbx34.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx35_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx35.Image = null;
                pbx35.Tag = null;
            }
            else
            {
                pbx35.Image = imglObjects.Images[imageSet];
                pbx35.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx36_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx36.Image = null;
                pbx36.Tag = null;
            }
            else
            {
                pbx36.Image = imglObjects.Images[imageSet];
                pbx36.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx37_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx37.Image = null;
                pbx37.Tag = null;
            }
            else
            {
                pbx37.Image = imglObjects.Images[imageSet];
                pbx37.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx38_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx38.Image = null;
                pbx38.Tag = null;
            }
            else
            {
                pbx38.Image = imglObjects.Images[imageSet];
                pbx38.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx39_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx39.Image = null;
                pbx39.Tag = null;
            }
            else
            {
                pbx39.Image = imglObjects.Images[imageSet];
                pbx39.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx40_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx40.Image = null;
                pbx40.Tag = null;
            }
            else
            {
                pbx40.Image = imglObjects.Images[imageSet];
                pbx40.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx41_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx41.Image = null;
                pbx41.Tag = null;
            }
            else
            {
                pbx41.Image = imglObjects.Images[imageSet];
                pbx41.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx42_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx42.Image = null;
                pbx42.Tag = null;
            }
            else
            {
                pbx42.Image = imglObjects.Images[imageSet];
                pbx42.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx43_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx43.Image = null;
                pbx43.Tag = null;
            }
            else
            {
                pbx43.Image = imglObjects.Images[imageSet];
                pbx43.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx44_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx44.Image = null;
                pbx44.Tag = null;
            }
            else
            {
                pbx44.Image = imglObjects.Images[imageSet];
                pbx44.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx45_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx45.Image = null;
                pbx45.Tag = null;
            }
            else
            {
                pbx45.Image = imglObjects.Images[imageSet];
                pbx45.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx46_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx46.Image = null;
                pbx46.Tag = null;
            }
            else
            {
                pbx46.Image = imglObjects.Images[imageSet];
                pbx46.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx47_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx47.Image = null;
                pbx47.Tag = null;
            }
            else
            {
                pbx47.Image = imglObjects.Images[imageSet];
                pbx47.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx48_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx48.Image = null;
                pbx48.Tag = null;
            }
            else
            {
                pbx48.Image = imglObjects.Images[imageSet];
                pbx48.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx49_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx49.Image = null;
                pbx49.Tag = null;
            }
            else
            {
                pbx49.Image = imglObjects.Images[imageSet];
                pbx49.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx50_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx50.Image = null;
                pbx50.Tag = null;
            }
            else
            {
                pbx50.Image = imglObjects.Images[imageSet];
                pbx50.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx51_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx51.Image = null;
                pbx51.Tag = null;
            }
            else
            {
                pbx51.Image = imglObjects.Images[imageSet];
                pbx51.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx52_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx52.Image = null;
                pbx52.Tag = null;
            }
            else
            {
                pbx52.Image = imglObjects.Images[imageSet];
                pbx52.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx53_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx53.Image = null;
                pbx53.Tag = null;
            }
            else
            {
                pbx53.Image = imglObjects.Images[imageSet];
                pbx53.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx54_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx54.Image = null;
                pbx54.Tag = null;
            }
            else
            {
                pbx54.Image = imglObjects.Images[imageSet];
                pbx54.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx55_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx55.Image = null;
                pbx55.Tag = null;
            }
            else
            {
                pbx55.Image = imglObjects.Images[imageSet];
                pbx55.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx56_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx56.Image = null;
                pbx56.Tag = null;
            }
            else
            {
                pbx56.Image = imglObjects.Images[imageSet];
                pbx56.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx57_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx57.Image = null;
                pbx57.Tag = null;
            }
            else
            {
                pbx57.Image = imglObjects.Images[imageSet];
                pbx57.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx58_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx58.Image = null;
                pbx58.Tag = null;
            }
            else
            {
                pbx58.Image = imglObjects.Images[imageSet];
                pbx58.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx59_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx59.Image = null;
                pbx59.Tag = null;
            }
            else
            {
                pbx59.Image = imglObjects.Images[imageSet];
                pbx59.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx60_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx60.Image = null;
                pbx60.Tag = null;
            }
            else
            {
                pbx60.Image = imglObjects.Images[imageSet];
                pbx60.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx61_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx61.Image = null;
                pbx61.Tag = null;
            }
            else
            {
                pbx61.Image = imglObjects.Images[imageSet];
                pbx61.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx62_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx62.Image = null;
                pbx62.Tag = null;
            }
            else
            {
                pbx62.Image = imglObjects.Images[imageSet];
                pbx62.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx63_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx63.Image = null;
                pbx63.Tag = null;
            }
            else
            {
                pbx63.Image = imglObjects.Images[imageSet];
                pbx63.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx64_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx64.Image = null;
                pbx64.Tag = null;
            }
            else
            {
                pbx64.Image = imglObjects.Images[imageSet];
                pbx64.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx65_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx65.Image = null;
                pbx65.Tag = null;
            }
            else
            {
                pbx65.Image = imglObjects.Images[imageSet];
                pbx65.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx66_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx66.Image = null;
                pbx66.Tag = null;
            }
            else
            {
                pbx66.Image = imglObjects.Images[imageSet];
                pbx66.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx67_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx67.Image = null;
                pbx67.Tag = null;
            }
            else
            {
                pbx67.Image = imglObjects.Images[imageSet];
                pbx67.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx68_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx68.Image = null;
                pbx68.Tag = null;
            }
            else
            {
                pbx68.Image = imglObjects.Images[imageSet];
                pbx68.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx69_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx69.Image = null;
                pbx69.Tag = null;
            }
            else
            {
                pbx69.Image = imglObjects.Images[imageSet];
                pbx69.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx70_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx70.Image = null;
                pbx70.Tag = null;
            }
            else
            {
                pbx70.Image = imglObjects.Images[imageSet];
                pbx70.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx71_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx71.Image = null;
                pbx71.Tag = null;
            }
            else
            {
                pbx71.Image = imglObjects.Images[imageSet];
                pbx71.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx72_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx72.Image = null;
                pbx72.Tag = null;
            }
            else
            {
                pbx72.Image = imglObjects.Images[imageSet];
                pbx72.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx73_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx73.Image = null;
                pbx73.Tag = null;
            }
            else
            {
                pbx73.Image = imglObjects.Images[imageSet];
                pbx73.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx74_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx74.Image = null;
                pbx74.Tag = null;
            }
            else
            {
                pbx74.Image = imglObjects.Images[imageSet];
                pbx74.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx75_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx75.Image = null;
                pbx75.Tag = null;
            }
            else
            {
                pbx75.Image = imglObjects.Images[imageSet];
                pbx75.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx76_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx76.Image = null;
                pbx76.Tag = null;
            }
            else
            {
                pbx76.Image = imglObjects.Images[imageSet];
                pbx76.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx77_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx77.Image = null;
                pbx77.Tag = null;
            }
            else
            {
                pbx77.Image = imglObjects.Images[imageSet];
                pbx77.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx78_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx78.Image = null;
                pbx78.Tag = null;
            }
            else
            {
                pbx78.Image = imglObjects.Images[imageSet];
                pbx78.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx79_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx79.Image = null;
                pbx79.Tag = null;
            }
            else
            {
                pbx79.Image = imglObjects.Images[imageSet];
                pbx79.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx80_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx80.Image = null;
                pbx80.Tag = null;
            }
            else
            {
                pbx80.Image = imglObjects.Images[imageSet];
                pbx80.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx81_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx81.Image = null;
                pbx81.Tag = null;
            }
            else
            {
                pbx81.Image = imglObjects.Images[imageSet];
                pbx81.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx82_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx82.Image = null;
                pbx82.Tag = null;
            }
            else
            {
                pbx82.Image = imglObjects.Images[imageSet];
                pbx82.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx83_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx83.Image = null;
                pbx83.Tag = null;
            }
            else
            {
                pbx83.Image = imglObjects.Images[imageSet];
                pbx83.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx84_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx84.Image = null;
                pbx84.Tag = null;
            }
            else
            {
                pbx84.Image = imglObjects.Images[imageSet];
                pbx84.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx85_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx85.Image = null;
                pbx85.Tag = null;
            }
            else
            {
                pbx85.Image = imglObjects.Images[imageSet];
                pbx85.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx86_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx86.Image = null;
                pbx86.Tag = null;
            }
            else
            {
                pbx86.Image = imglObjects.Images[imageSet];
                pbx86.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx87_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx87.Image = null;
                pbx87.Tag = null;
            }
            else
            {
                pbx87.Image = imglObjects.Images[imageSet];
                pbx87.Tag = imglObjects.Images.Keys[imageSet];
            }
        }

        private void pbx88_Click(object sender, EventArgs e)
        {
            if (imageSet == 12)
            {
                pbx88.Image = null;
                pbx88.Tag = null;
            }
            else
            {
                pbx88.Image = imglObjects.Images[imageSet];
                pbx88.Tag = imglObjects.Images.Keys[imageSet];
            }
        }
    }
}
