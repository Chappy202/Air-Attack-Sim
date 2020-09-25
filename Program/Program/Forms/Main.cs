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
            bool Edge = false;
            while (!stop)
            {
                for (int i = 0; i < 50; i++)
                {
                    int X = pbxPlane.Location.X - 5;
                    int Y = pbxPlane.Location.Y;
                    if (pbxPlane.InvokeRequired)
                    {
                        MethodInvoker AssignnMethodToControl = new MethodInvoker(movePlane);
                        pbxPlane.Invoke(AssignnMethodToControl);
                    }
                    else
                    {
                        pbxPlane.Location = new Point(X, Y);
                    }
                    Thread.Sleep(50);
                }
            }
        }
        
    }
}
