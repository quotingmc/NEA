namespace Trainline_Sim_Windows_Testing
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelTrackDisplay = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripHeader = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStationDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTrackDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obstacleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.passengerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventCreatortoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonTimeDisplay = new System.Windows.Forms.ToolStripButton();
            this.checkBoxDrawLabels = new System.Windows.Forms.CheckBox();
            this.checkBoxDrawIntervals = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.SuspendLayout();
            this.toolStripHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTrackDisplay
            // 
            this.panelTrackDisplay.AutoScroll = true;
            this.panelTrackDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelTrackDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrackDisplay.Location = new System.Drawing.Point(12, 35);
            this.panelTrackDisplay.Name = "panelTrackDisplay";
            this.panelTrackDisplay.Size = new System.Drawing.Size(902, 390);
            this.panelTrackDisplay.TabIndex = 0;
            this.panelTrackDisplay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panelTrackDisplay_Scroll);
            this.panelTrackDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTrackDisplay_Paint);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(16, -169);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripHeader
            // 
            this.toolStripHeader.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.buttonTimeDisplay});
            this.toolStripHeader.Location = new System.Drawing.Point(0, 0);
            this.toolStripHeader.Name = "toolStripHeader";
            this.toolStripHeader.Size = new System.Drawing.Size(976, 31);
            this.toolStripHeader.TabIndex = 3;
            this.toolStripHeader.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadStationDataToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(38, 28);
            this.toolStripButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadStationDataToolStripMenuItem
            // 
            this.loadStationDataToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadStationDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadStationDataToolStripMenuItem1,
            this.loadTrackDataToolStripMenuItem});
            this.loadStationDataToolStripMenuItem.Name = "loadStationDataToolStripMenuItem";
            this.loadStationDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadStationDataToolStripMenuItem.Text = "Load";
            this.loadStationDataToolStripMenuItem.Click += new System.EventHandler(this.loadStationDataToolStripMenuItem_Click);
            // 
            // loadStationDataToolStripMenuItem1
            // 
            this.loadStationDataToolStripMenuItem1.Name = "loadStationDataToolStripMenuItem1";
            this.loadStationDataToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.loadStationDataToolStripMenuItem1.Text = "Load Station Data";
            // 
            // loadTrackDataToolStripMenuItem
            // 
            this.loadTrackDataToolStripMenuItem.Name = "loadTrackDataToolStripMenuItem";
            this.loadTrackDataToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.loadTrackDataToolStripMenuItem.Text = "Load Track Data";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Trainline_Sim_Windows_Testing.Properties.Resources.information;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton2.Text = "toolStripButtonInfo";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainToolStripMenuItem,
            this.scenarioToolStripMenuItem,
            this.obstacleToolStripMenuItem});
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(54, 28);
            this.toolStripButton3.Text = "Create";
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trainToolStripMenuItem.Text = "Train";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // scenarioToolStripMenuItem
            // 
            this.scenarioToolStripMenuItem.Name = "scenarioToolStripMenuItem";
            this.scenarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scenarioToolStripMenuItem.Text = "Scenario";
            // 
            // obstacleToolStripMenuItem
            // 
            this.obstacleToolStripMenuItem.Name = "obstacleToolStripMenuItem";
            this.obstacleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.obstacleToolStripMenuItem.Text = "Obstacle";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passengerInfoToolStripMenuItem,
            this.eventCreatortoolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 28);
            this.toolStripDropDownButton1.Text = "Windows";
            // 
            // passengerInfoToolStripMenuItem
            // 
            this.passengerInfoToolStripMenuItem.CheckOnClick = true;
            this.passengerInfoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.passengerInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.passengerInfoToolStripMenuItem.Name = "passengerInfoToolStripMenuItem";
            this.passengerInfoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.passengerInfoToolStripMenuItem.Text = "Passenger Info";
            this.passengerInfoToolStripMenuItem.Click += new System.EventHandler(this.passengerInfoToolStripMenuItem_Click);
            // 
            // eventCreatortoolStripMenuItem
            // 
            this.eventCreatortoolStripMenuItem.CheckOnClick = true;
            this.eventCreatortoolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eventCreatortoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eventCreatortoolStripMenuItem.Name = "eventCreatortoolStripMenuItem";
            this.eventCreatortoolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.eventCreatortoolStripMenuItem.Text = "Event Creator";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // buttonTimeDisplay
            // 
            this.buttonTimeDisplay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonTimeDisplay.AutoSize = false;
            this.buttonTimeDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonTimeDisplay.Enabled = false;
            this.buttonTimeDisplay.Image = ((System.Drawing.Image)(resources.GetObject("buttonTimeDisplay.Image")));
            this.buttonTimeDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonTimeDisplay.Name = "buttonTimeDisplay";
            this.buttonTimeDisplay.Size = new System.Drawing.Size(128, 28);
            // 
            // checkBoxDrawLabels
            // 
            this.checkBoxDrawLabels.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDrawLabels.Checked = true;
            this.checkBoxDrawLabels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawLabels.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDrawLabels.Image = global::Trainline_Sim_Windows_Testing.Properties.Resources.stationLabelsButtonImage;
            this.checkBoxDrawLabels.Location = new System.Drawing.Point(2, 0);
            this.checkBoxDrawLabels.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxDrawLabels.Name = "checkBoxDrawLabels";
            this.checkBoxDrawLabels.Size = new System.Drawing.Size(40, 40);
            this.checkBoxDrawLabels.TabIndex = 11;
            this.toolTip1.SetToolTip(this.checkBoxDrawLabels, "Show Station Names");
            this.checkBoxDrawLabels.UseVisualStyleBackColor = true;
            this.checkBoxDrawLabels.CheckedChanged += new System.EventHandler(this.checkBoxDrawLabels_CheckedChanged);
            // 
            // checkBoxDrawIntervals
            // 
            this.checkBoxDrawIntervals.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDrawIntervals.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDrawIntervals.Image = global::Trainline_Sim_Windows_Testing.Properties.Resources.intervalsButtonImage;
            this.checkBoxDrawIntervals.Location = new System.Drawing.Point(2, 42);
            this.checkBoxDrawIntervals.Margin = new System.Windows.Forms.Padding(1);
            this.checkBoxDrawIntervals.Name = "checkBoxDrawIntervals";
            this.checkBoxDrawIntervals.Size = new System.Drawing.Size(40, 40);
            this.checkBoxDrawIntervals.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBoxDrawIntervals, "Show Track Intervals");
            this.checkBoxDrawIntervals.UseVisualStyleBackColor = true;
            this.checkBoxDrawIntervals.CheckedChanged += new System.EventHandler(this.checkBoxDrawIntervals_CheckedChanged_1);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.PaleTurquoise;
            this.colorDialog.SolidColorOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Image = global::Trainline_Sim_Windows_Testing.Properties.Resources.location;
            this.checkBox1.Location = new System.Drawing.Point(2, 168);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 40);
            this.checkBox1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.checkBox1, "Center View On Train");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Image = global::Trainline_Sim_Windows_Testing.Properties.Resources.crossingsButtonImage;
            this.checkBox2.Location = new System.Drawing.Point(2, 84);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 40);
            this.checkBox2.TabIndex = 14;
            this.toolTip1.SetToolTip(this.checkBox2, "Show Track Intervals");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Image = ((System.Drawing.Image)(resources.GetObject("checkBox3.Image")));
            this.checkBox3.Location = new System.Drawing.Point(2, 126);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(40, 40);
            this.checkBox3.TabIndex = 15;
            this.toolTip1.SetToolTip(this.checkBox3, "Show Track Intervals");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.checkBoxDrawIntervals);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBoxDrawLabels);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(920, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 390);
            this.panel2.TabIndex = 0;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStripHeader);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panelTrackDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Track Display";
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripHeader.ResumeLayout(false);
            this.toolStripHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTrackDisplay;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripHeader;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem loadStationDataToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDrawLabels;
        private System.Windows.Forms.CheckBox checkBoxDrawIntervals;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem passengerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventCreatortoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonTimeDisplay;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obstacleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStationDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadTrackDataToolStripMenuItem;
    }
}

