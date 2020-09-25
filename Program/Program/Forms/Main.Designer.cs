namespace Program
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.flpnlObjects = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbxPlane = new System.Windows.Forms.PictureBox();
            this.pnlCanvas.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.AutoSize = true;
            this.pnlCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCanvas.Controls.Add(this.pbxPlane);
            this.pnlCanvas.Location = new System.Drawing.Point(12, 59);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(772, 566);
            this.pnlCanvas.TabIndex = 0;
            // 
            // flpnlObjects
            // 
            this.flpnlObjects.AutoSize = true;
            this.flpnlObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flpnlObjects.Location = new System.Drawing.Point(790, 12);
            this.flpnlObjects.Name = "flpnlObjects";
            this.flpnlObjects.Size = new System.Drawing.Size(300, 613);
            this.flpnlObjects.TabIndex = 2;
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.btnReports);
            this.pnlHeader.Controls.Add(this.btnClear);
            this.pnlHeader.Controls.Add(this.btnReset);
            this.pnlHeader.Controls.Add(this.btnStop);
            this.pnlHeader.Controls.Add(this.btnStart);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(772, 44);
            this.pnlHeader.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(683, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(547, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(130, 38);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Simulation Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(411, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Simulation";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(275, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Simulation";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(139, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 38);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Simulation";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 38);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Simulation";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbxPlane
            // 
            this.pbxPlane.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlane.Image")));
            this.pbxPlane.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxPlane.InitialImage")));
            this.pbxPlane.Location = new System.Drawing.Point(628, 211);
            this.pbxPlane.Name = "pbxPlane";
            this.pbxPlane.Size = new System.Drawing.Size(128, 128);
            this.pbxPlane.TabIndex = 0;
            this.pbxPlane.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 637);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.flpnlObjects);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "frmMain";
            this.Text = "Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.FlowLayoutPanel flpnlObjects;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbxPlane;
    }
}

