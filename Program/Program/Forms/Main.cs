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
using Program.Handlers;

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
        public int selectedPlaneItem = 0;
        public string[] planes = new string[]{ "pbxLockheed", "pbxBoeingp8", "pbxDessault", "pbxBoeinEa" };

        // Object variable
        public int imageSet = 10;
        public string imageName = String.Empty;
        private bool busy = false;
        private int startx, starty;

        // Handlers
        private DataHandler data = new DataHandler();

        // Canvas Items
        List<Plane> allJets = new List<Plane>();
        List<Obstacle> allObstacles = new List<Obstacle>();

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
                for (int i = 0; i < pnlCanvas.Controls.Count; i++)
                {
                    Control obstacle = (Control) pnlCanvas.Controls[i];
                    pnlCanvas.Controls.Remove(obstacle);
                    obstacle.Dispose();
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
            StartSim();
        }

        private void StartSim()
        {
            if (!busy)
            {
                PictureBox end = null;
                PictureBox picture = null;
                foreach (PictureBox item in pnlCanvas.Controls)
                {
                    if (item.Tag == "finish.png")
                    {
                        end = item;
                        break;
                    }
                }
                foreach (PictureBox item in pnlCanvas.Controls)
                {
                    picture = item;
                    if (picture.Tag == "start.png")
                    {
                        // Update the start item with the plane skin
                        picture = item;
                        picture.BringToFront();
                        picture.Image = imglPlanes.Images[selectedPlaneItem];
                        updateObjects();
                        break;
                    }
                    
                }

                // Move the plane to the finish
                Avoidance avoid = new Avoidance();
                //busy = true;
                bool destination = false;
                if (end != null && picture != null)
                {
                    while (!destination)
                    {
                        if (picture.Left > end.Left)
                        {
                            if (avoid.isNear(picture.Location))
                            {
                                picture.Left -= 50;
                                picture.Refresh();
                                updateObjects();
                            }
                            else
                            {
                                picture.Left -= 1;
                                picture.Refresh();
                                updateObjects();
                            }
                        }

                        if (picture.Left < end.Left)
                        {
                            if (avoid.isNear(picture.Location))
                            {
                                picture.Left += 50;
                                picture.Refresh();
                                updateObjects();
                            }
                            else
                            {
                                picture.Left += 1;
                                picture.Refresh();
                                updateObjects();
                            }
                        }

                        if (picture.Top > end.Top)
                        {
                            if (avoid.isNear(picture.Location))
                            {
                                picture.Top -= 10;
                                picture.Refresh();
                                updateObjects();
                            }
                            else
                            {
                                picture.Top -= 1;
                                picture.Refresh();
                                updateObjects();
                            }
                            
                        }

                        if (picture.Top < end.Top)
                        {

                            if (avoid.isNear(picture.Location))
                            {
                                picture.Top += 10;
                                picture.Refresh();
                                updateObjects();
                            }
                            else
                            {
                                picture.Top += 1;
                                picture.Refresh();
                                updateObjects();
                            }
                        }

                        if (picture.Top == end.Top && picture.Left == end.Left)
                        {
                            destination = true;
                            picture.Refresh();
                            updateObjects();
                        }
                    }

                    // Return to the start
                    destination = false;
                    while (!destination)
                    {
                        if (picture.Location.X > startx)
                        {
                            picture.Location = new Point(picture.Location.X -1, picture.Location.Y);
                            picture.Refresh();
                            updateObjects();
                        }

                        if (picture.Location.X < startx)
                        {
                            picture.Location = new Point(picture.Location.X + 1, picture.Location.Y);
                            picture.Refresh();
                            updateObjects();
                        }

                        if (picture.Location.Y > starty)
                        {
                            picture.Location = new Point(picture.Location.X, picture.Location.Y - 1);
                            picture.Refresh();
                            updateObjects();
                        }

                        if (picture.Location.Y < starty)
                        {
                            picture.Location = new Point(picture.Location.X, picture.Location.Y + 1);
                            picture.Refresh();
                            updateObjects();
                        }
                        // Reached starting point
                        if (picture.Location.X == startx && picture.Location.Y == starty)
                        {
                            destination = true;
                            picture.Image = imglObjects.Images[10];
                            updateObjects();
                            picture.Refresh();
                            frmResults result = new frmResults();
                            result.ShowDialog();
                        }
                    }
                }
                else
                {
                    throw new ExceptionHandler("Unable to find a start or end!");
                }
               

                //busy = false;


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
                selectedPlane = "lockheed-martin-f-22a-raptor.png";
                selectedPlaneItem = 3;
                pbxLockheed.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "lockheed-martin-f-22a-raptor.png";
                selectedPlaneItem = 3;
                pbxLockheed.BackColor = Color.LightGreen;
                updatePlaneSelection();
            }
            
        }

        private void pbxBoeingp8_Click(object sender, EventArgs e)
        {
            if (selectedPlane == "None")
            {
                selectedPlane = "boeing-p-8-poseidon.png";
                selectedPlaneItem = 0;
                pbxBoeingp8.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "boeing-p-8-poseidon.png";
                selectedPlaneItem = 0;
                pbxBoeingp8.BackColor = Color.LightGreen;
                updatePlaneSelection();
            }
        }

        private void pbxDessault_Click(object sender, EventArgs e)
        {
            if (selectedPlane == "None")
            {
                selectedPlane = "dessault-rafale.png";
                selectedPlaneItem = 2;
                pbxDessault.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "dessault-rafale.png";
                selectedPlaneItem = 2;
                pbxDessault.BackColor = Color.LightGreen;
                updatePlaneSelection();
            }

        }

        private void pbxBoeinEa_Click(object sender, EventArgs e)
        {
            if (selectedPlane == "None")
            {
                selectedPlane = "boeng-ea-18g-growler.png";
                selectedPlaneItem = 1;
                pbxBoeinEa.BackColor = Color.LightGreen;
            }
            else
            {
                selectedPlane = "boeng-ea-18g-growler.png";
                selectedPlaneItem = 1;
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

        public void updateObjects()
        {
            foreach (PictureBox item in pnlCanvas.Controls)
            {
                item.Refresh();
            }
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

            // Add all planes to the lists
            allJets = data.GetPlanes();
            // Add all obstacles to the lists
            //allObstacles = data.GetObstacle();

            // Make sure that no Object locations are stored
            data.clearLocations();
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
            imageName = "Start";
        }

        private void pbxEnd_Click(object sender, EventArgs e)
        {
            imageSet = 4;
            imageName = "End";
        }

        private void pbxAA_Click(object sender, EventArgs e)
        {
            imageSet = 0;
            imageName = "AA";
        }

        private void pbxHQ_Click(object sender, EventArgs e)
        {
            imageSet = 6;
            imageName = "HQ";
        }

        private void pbxMed_Click(object sender, EventArgs e)
        {
            imageSet = 7;
            imageName = "Med";
        }

        private void pbxHangar_Click(object sender, EventArgs e)
        {
            imageSet = 5;
            imageName = "Hangar";
        }

        private void pbxArtilary_Click(object sender, EventArgs e)
        {
            imageSet = 1;
            imageName = "Artillery";
        }

        private void pbxTent_Click(object sender, EventArgs e)
        {
            imageSet = 11;
            imageName = "Tent";
        }

        private void pbxRadar_Click(object sender, EventArgs e)
        {
            imageSet = 9;
            imageName = "Radar";
        }

        private void pbxCafeteria_Click(object sender, EventArgs e)
        {
            imageSet = 3;
            imageName = "Cafeteria";
        }

        private void pbxBuilding_Click(object sender, EventArgs e)
        {
            imageSet = 2;
            imageName = "Building";
        }

        private void pbxClear_Click(object sender, EventArgs e)
        {
            imageSet = 12;
            imageName = "Clear";
        }

        // ##############################################
        // DRAG n DROP
        // ##############################################

        private void pnlCanvas_Click(object sender, EventArgs e)
        {
            bool startExist = false, endExist = false, HQExist = false;
            foreach (var item in pnlCanvas.Controls)
            {
                PictureBox obstacle = (PictureBox)item;
                if (obstacle.Tag == "start.png" && imageSet == 10)
                {
                    MessageBox.Show("You already have a starting point!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    startExist = true;
                } else if (obstacle.Tag == "finish.png" && imageSet == 4)
                {
                    MessageBox.Show("You already have a end point!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    endExist = true;
                } else if (obstacle.Tag == "HQ.png" && imageSet == 6)
                {
                    MessageBox.Show("You already have a HQ!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    HQExist = true;
                }
            }

            if (!startExist || !endExist || !HQExist)
            {
                if (imageSet != null)
                {
                    MouseEventArgs m = (MouseEventArgs)e;
                    int x = m.Location.X;
                    int y = m.Location.Y;
                    DataHandler.obstacles++;
                    PictureBox Obstacle = new PictureBox();
                    Obstacle.Location = new Point(x, y);
                    string name = "pbx-" + imageName + "-" + DataHandler.obstacles.ToString();
                    Obstacle.Name = name;
                    Obstacle.Size = new Size(64, 64);
                    Obstacle.Image = imglObjects.Images[imageSet];
                    Obstacle.Tag = imglObjects.Images.Keys[imageSet];
                    Obstacle.BackColor = Color.Transparent;
                    Obstacle.MouseDown += new MouseEventHandler(Obstacle_MouseDown);
                    Obstacle.MouseMove += new MouseEventHandler(Obstacle_MouseMove);
                    Obstacle.MouseUp += new MouseEventHandler(Obstacle_MouseUp);
                    Obstacle.MouseClick += new MouseEventHandler(Obstacle_Click);
                    pnlCanvas.Controls.Add(Obstacle);
                    data.addObstacle(name, Obstacle.Location.X, Obstacle.Location.Y);
                    if (imglObjects.Images.Keys[imageSet] == "start.png")
                    {
                        startx = x;
                        starty = y;
                    }
                }
            }
            
        }

        private void Obstacle_Click(object sender, MouseEventArgs e)
        {
            if (imageSet == 12)
            {
                if (pnlCanvas.Controls.Contains((Control)sender))
                {
                    Control obstacle = (Control) sender;
                    data.removeObstacle(obstacle.Name);
                    pnlCanvas.Controls.Remove(obstacle);
                    obstacle.Dispose();
                }
            }
        }

        private Control activeControl;
        private Point previousLocation;
        private void Obstacle_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            previousLocation = e.Location;
            Cursor = Cursors.Hand;
        }

        private void Obstacle_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender)
            {
                return;
            }

            var location = activeControl.Location;
            location.Offset(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
            activeControl.Location = location;
        }

        private void Obstacle_MouseUp(object sender, MouseEventArgs e)
        {
            data.updateLocation(activeControl.Name, activeControl.Location.X, activeControl.Location.Y);
            if (activeControl.Tag == "start.png")
            {
                startx = activeControl.Location.X;
                starty = activeControl.Location.Y;
            }
            activeControl = null;
            Cursor = Cursors.Default;
        }
    }
}
