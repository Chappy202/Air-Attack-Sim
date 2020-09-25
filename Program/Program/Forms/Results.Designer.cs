namespace Program.Forms
{
    partial class frmResults
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
            this.lblDamageLabel = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblSuccessLabel = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescriptionLabel = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeLabel = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblTargetLocationLabel = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblStartLabel = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblEndLabel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameLabel = new System.Windows.Forms.Label();
            this.lblAvoided = new System.Windows.Forms.Label();
            this.lblAvoidedLabel = new System.Windows.Forms.Label();
            this.lblReasonLabel = new System.Windows.Forms.Label();
            this.pnlReason = new System.Windows.Forms.Panel();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblFuelBefore = new System.Windows.Forms.Label();
            this.lblFuelBeforeLabel = new System.Windows.Forms.Label();
            this.lblFuelAfter = new System.Windows.Forms.Label();
            this.lblFuelAfterLabel = new System.Windows.Forms.Label();
            this.lblInvBefore = new System.Windows.Forms.Label();
            this.lblInvBeforeLabel = new System.Windows.Forms.Label();
            this.lblInvAfter = new System.Windows.Forms.Label();
            this.lblInvAfterLabel = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDescription.SuspendLayout();
            this.pnlReason.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDamageLabel
            // 
            this.lblDamageLabel.AutoSize = true;
            this.lblDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamageLabel.Location = new System.Drawing.Point(12, 9);
            this.lblDamageLabel.Name = "lblDamageLabel";
            this.lblDamageLabel.Size = new System.Drawing.Size(81, 20);
            this.lblDamageLabel.TabIndex = 0;
            this.lblDamageLabel.Text = "Damage:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.Location = new System.Drawing.Point(156, 9);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(18, 20);
            this.lblDamage.TabIndex = 1;
            this.lblDamage.Text = "0";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(156, 42);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(32, 20);
            this.lblSuccess.TabIndex = 3;
            this.lblSuccess.Text = "0%";
            // 
            // lblSuccessLabel
            // 
            this.lblSuccessLabel.AutoSize = true;
            this.lblSuccessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessLabel.Location = new System.Drawing.Point(12, 42);
            this.lblSuccessLabel.Name = "lblSuccessLabel";
            this.lblSuccessLabel.Size = new System.Drawing.Size(102, 20);
            this.lblSuccessLabel.TabIndex = 2;
            this.lblSuccessLabel.Text = "Success %:";
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Location = new System.Drawing.Point(16, 98);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(413, 54);
            this.pnlDescription.TabIndex = 4;
            // 
            // lblDescriptionLabel
            // 
            this.lblDescriptionLabel.AutoSize = true;
            this.lblDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionLabel.Location = new System.Drawing.Point(12, 75);
            this.lblDescriptionLabel.Name = "lblDescriptionLabel";
            this.lblDescriptionLabel.Size = new System.Drawing.Size(157, 20);
            this.lblDescriptionLabel.TabIndex = 5;
            this.lblDescriptionLabel.Text = "Strike Description:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(4, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(122, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "No Description Provided";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(156, 164);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 20);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "0s 0m";
            // 
            // lblTimeLabel
            // 
            this.lblTimeLabel.AutoSize = true;
            this.lblTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLabel.Location = new System.Drawing.Point(10, 164);
            this.lblTimeLabel.Name = "lblTimeLabel";
            this.lblTimeLabel.Size = new System.Drawing.Size(104, 20);
            this.lblTimeLabel.TabIndex = 6;
            this.lblTimeLabel.Text = "Strike Time:";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarget.Location = new System.Drawing.Point(156, 197);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(45, 20);
            this.lblTarget.TabIndex = 9;
            this.lblTarget.Text = "(0, 0)";
            // 
            // lblTargetLocationLabel
            // 
            this.lblTargetLocationLabel.AutoSize = true;
            this.lblTargetLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetLocationLabel.Location = new System.Drawing.Point(10, 197);
            this.lblTargetLocationLabel.Name = "lblTargetLocationLabel";
            this.lblTargetLocationLabel.Size = new System.Drawing.Size(140, 20);
            this.lblTargetLocationLabel.TabIndex = 8;
            this.lblTargetLocationLabel.Text = "Target Location:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(158, 231);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(45, 20);
            this.lblStart.TabIndex = 11;
            this.lblStart.Text = "(0, 0)";
            // 
            // lblStartLabel
            // 
            this.lblStartLabel.AutoSize = true;
            this.lblStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartLabel.Location = new System.Drawing.Point(12, 231);
            this.lblStartLabel.Name = "lblStartLabel";
            this.lblStartLabel.Size = new System.Drawing.Size(128, 20);
            this.lblStartLabel.TabIndex = 10;
            this.lblStartLabel.Text = "Start Location:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(158, 264);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(45, 20);
            this.lblEnd.TabIndex = 13;
            this.lblEnd.Text = "(0, 0)";
            // 
            // lblEndLabel
            // 
            this.lblEndLabel.AutoSize = true;
            this.lblEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndLabel.Location = new System.Drawing.Point(12, 264);
            this.lblEndLabel.Name = "lblEndLabel";
            this.lblEndLabel.Size = new System.Drawing.Size(120, 20);
            this.lblEndLabel.TabIndex = 12;
            this.lblEndLabel.Text = "End Location:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(158, 300);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 20);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Barracks";
            // 
            // lblNameLabel
            // 
            this.lblNameLabel.AutoSize = true;
            this.lblNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameLabel.Location = new System.Drawing.Point(12, 300);
            this.lblNameLabel.Name = "lblNameLabel";
            this.lblNameLabel.Size = new System.Drawing.Size(117, 20);
            this.lblNameLabel.TabIndex = 14;
            this.lblNameLabel.Text = "Target Name:";
            // 
            // lblAvoided
            // 
            this.lblAvoided.AutoSize = true;
            this.lblAvoided.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvoided.Location = new System.Drawing.Point(158, 333);
            this.lblAvoided.Name = "lblAvoided";
            this.lblAvoided.Size = new System.Drawing.Size(18, 20);
            this.lblAvoided.TabIndex = 17;
            this.lblAvoided.Text = "0";
            // 
            // lblAvoidedLabel
            // 
            this.lblAvoidedLabel.AutoSize = true;
            this.lblAvoidedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvoidedLabel.Location = new System.Drawing.Point(12, 333);
            this.lblAvoidedLabel.Name = "lblAvoidedLabel";
            this.lblAvoidedLabel.Size = new System.Drawing.Size(144, 20);
            this.lblAvoidedLabel.TabIndex = 16;
            this.lblAvoidedLabel.Text = "Targets Avoided:";
            // 
            // lblReasonLabel
            // 
            this.lblReasonLabel.AutoSize = true;
            this.lblReasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonLabel.Location = new System.Drawing.Point(12, 362);
            this.lblReasonLabel.Name = "lblReasonLabel";
            this.lblReasonLabel.Size = new System.Drawing.Size(236, 20);
            this.lblReasonLabel.TabIndex = 19;
            this.lblReasonLabel.Text = "Reason for avoiding targets:";
            // 
            // pnlReason
            // 
            this.pnlReason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlReason.Controls.Add(this.lblReason);
            this.pnlReason.Location = new System.Drawing.Point(16, 385);
            this.pnlReason.Name = "pnlReason";
            this.pnlReason.Size = new System.Drawing.Size(413, 54);
            this.pnlReason.TabIndex = 18;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(4, 5);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(122, 13);
            this.lblReason.TabIndex = 0;
            this.lblReason.Text = "No Description Provided";
            // 
            // lblFuelBefore
            // 
            this.lblFuelBefore.AutoSize = true;
            this.lblFuelBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelBefore.Location = new System.Drawing.Point(588, 9);
            this.lblFuelBefore.Name = "lblFuelBefore";
            this.lblFuelBefore.Size = new System.Drawing.Size(18, 20);
            this.lblFuelBefore.TabIndex = 21;
            this.lblFuelBefore.Text = "0";
            // 
            // lblFuelBeforeLabel
            // 
            this.lblFuelBeforeLabel.AutoSize = true;
            this.lblFuelBeforeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelBeforeLabel.Location = new System.Drawing.Point(444, 9);
            this.lblFuelBeforeLabel.Name = "lblFuelBeforeLabel";
            this.lblFuelBeforeLabel.Size = new System.Drawing.Size(108, 20);
            this.lblFuelBeforeLabel.TabIndex = 20;
            this.lblFuelBeforeLabel.Text = "Fuel Before:";
            // 
            // lblFuelAfter
            // 
            this.lblFuelAfter.AutoSize = true;
            this.lblFuelAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelAfter.Location = new System.Drawing.Point(588, 42);
            this.lblFuelAfter.Name = "lblFuelAfter";
            this.lblFuelAfter.Size = new System.Drawing.Size(18, 20);
            this.lblFuelAfter.TabIndex = 23;
            this.lblFuelAfter.Text = "0";
            // 
            // lblFuelAfterLabel
            // 
            this.lblFuelAfterLabel.AutoSize = true;
            this.lblFuelAfterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelAfterLabel.Location = new System.Drawing.Point(444, 42);
            this.lblFuelAfterLabel.Name = "lblFuelAfterLabel";
            this.lblFuelAfterLabel.Size = new System.Drawing.Size(94, 20);
            this.lblFuelAfterLabel.TabIndex = 22;
            this.lblFuelAfterLabel.Text = "Fuel After:";
            // 
            // lblInvBefore
            // 
            this.lblInvBefore.AutoSize = true;
            this.lblInvBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvBefore.Location = new System.Drawing.Point(588, 75);
            this.lblInvBefore.Name = "lblInvBefore";
            this.lblInvBefore.Size = new System.Drawing.Size(18, 20);
            this.lblInvBefore.TabIndex = 25;
            this.lblInvBefore.Text = "0";
            // 
            // lblInvBeforeLabel
            // 
            this.lblInvBeforeLabel.AutoSize = true;
            this.lblInvBeforeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvBeforeLabel.Location = new System.Drawing.Point(444, 75);
            this.lblInvBeforeLabel.Name = "lblInvBeforeLabel";
            this.lblInvBeforeLabel.Size = new System.Drawing.Size(147, 20);
            this.lblInvBeforeLabel.TabIndex = 24;
            this.lblInvBeforeLabel.Text = "Inventory Before:";
            // 
            // lblInvAfter
            // 
            this.lblInvAfter.AutoSize = true;
            this.lblInvAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvAfter.Location = new System.Drawing.Point(588, 108);
            this.lblInvAfter.Name = "lblInvAfter";
            this.lblInvAfter.Size = new System.Drawing.Size(18, 20);
            this.lblInvAfter.TabIndex = 27;
            this.lblInvAfter.Text = "0";
            // 
            // lblInvAfterLabel
            // 
            this.lblInvAfterLabel.AutoSize = true;
            this.lblInvAfterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvAfterLabel.Location = new System.Drawing.Point(444, 108);
            this.lblInvAfterLabel.Name = "lblInvAfterLabel";
            this.lblInvAfterLabel.Size = new System.Drawing.Size(133, 20);
            this.lblInvAfterLabel.TabIndex = 26;
            this.lblInvAfterLabel.Text = "Inventory After:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(463, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 54);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 452);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInvAfter);
            this.Controls.Add(this.lblInvAfterLabel);
            this.Controls.Add(this.lblInvBefore);
            this.Controls.Add(this.lblInvBeforeLabel);
            this.Controls.Add(this.lblFuelAfter);
            this.Controls.Add(this.lblFuelAfterLabel);
            this.Controls.Add(this.lblFuelBefore);
            this.Controls.Add(this.lblFuelBeforeLabel);
            this.Controls.Add(this.lblReasonLabel);
            this.Controls.Add(this.pnlReason);
            this.Controls.Add(this.lblAvoided);
            this.Controls.Add(this.lblAvoidedLabel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNameLabel);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblEndLabel);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblStartLabel);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblTargetLocationLabel);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeLabel);
            this.Controls.Add(this.lblDescriptionLabel);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.lblSuccessLabel);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblDamageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmResults";
            this.Text = "Results";
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            this.pnlReason.ResumeLayout(false);
            this.pnlReason.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDamageLabel;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblSuccessLabel;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptionLabel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeLabel;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblTargetLocationLabel;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblStartLabel;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblEndLabel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameLabel;
        private System.Windows.Forms.Label lblAvoided;
        private System.Windows.Forms.Label lblAvoidedLabel;
        private System.Windows.Forms.Label lblReasonLabel;
        private System.Windows.Forms.Panel pnlReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblFuelBefore;
        private System.Windows.Forms.Label lblFuelBeforeLabel;
        private System.Windows.Forms.Label lblFuelAfter;
        private System.Windows.Forms.Label lblFuelAfterLabel;
        private System.Windows.Forms.Label lblInvBefore;
        private System.Windows.Forms.Label lblInvBeforeLabel;
        private System.Windows.Forms.Label lblInvAfter;
        private System.Windows.Forms.Label lblInvAfterLabel;
        private System.Windows.Forms.Button btnClose;
    }
}