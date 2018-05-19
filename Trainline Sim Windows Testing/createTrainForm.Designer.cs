namespace Trainline_Sim_Windows_Testing
{
    partial class createTrainForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboEndStation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxStops = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboStartStation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureColourSelect = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAdvancedOptions = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxAdvancedOptions = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColourSelect)).BeginInit();
            this.panelAdvancedOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "End Station:";
            // 
            // comboEndStation
            // 
            this.comboEndStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboEndStation.FormattingEnabled = true;
            this.comboEndStation.Location = new System.Drawing.Point(172, 72);
            this.comboEndStation.Name = "comboEndStation";
            this.comboEndStation.Size = new System.Drawing.Size(110, 21);
            this.comboEndStation.TabIndex = 18;
            this.comboEndStation.SelectedIndexChanged += new System.EventHandler(this.comboEndStation_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stopping Stations:";
            // 
            // listBoxStops
            // 
            this.listBoxStops.FormattingEnabled = true;
            this.listBoxStops.Items.AddRange(new object[] {
            "Stansted Mountfichett",
            "Bishops Stortford",
            "Sawbridgeworth",
            "Harlow Mill"});
            this.listBoxStops.Location = new System.Drawing.Point(172, 99);
            this.listBoxStops.Name = "listBoxStops";
            this.listBoxStops.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStops.Size = new System.Drawing.Size(110, 82);
            this.listBoxStops.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Start Station:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboStartStation
            // 
            this.comboStartStation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboStartStation.FormattingEnabled = true;
            this.comboStartStation.Location = new System.Drawing.Point(172, 45);
            this.comboStartStation.Name = "comboStartStation";
            this.comboStartStation.Size = new System.Drawing.Size(110, 21);
            this.comboStartStation.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Train Colour:";
            // 
            // pictureColourSelect
            // 
            this.pictureColourSelect.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureColourSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureColourSelect.Location = new System.Drawing.Point(172, 18);
            this.pictureColourSelect.Name = "pictureColourSelect";
            this.pictureColourSelect.Size = new System.Drawing.Size(110, 21);
            this.pictureColourSelect.TabIndex = 0;
            this.pictureColourSelect.TabStop = false;
            this.pictureColourSelect.Click += new System.EventHandler(this.pictureColourSelect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelAdvancedOptions
            // 
            this.panelAdvancedOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdvancedOptions.Controls.Add(this.comboBox1);
            this.panelAdvancedOptions.Controls.Add(this.button2);
            this.panelAdvancedOptions.Location = new System.Drawing.Point(15, 262);
            this.panelAdvancedOptions.Name = "panelAdvancedOptions";
            this.panelAdvancedOptions.Size = new System.Drawing.Size(267, 137);
            this.panelAdvancedOptions.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 23;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdvancedOptions
            // 
            this.checkBoxAdvancedOptions.AutoSize = true;
            this.checkBoxAdvancedOptions.Checked = true;
            this.checkBoxAdvancedOptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdvancedOptions.Location = new System.Drawing.Point(15, 239);
            this.checkBoxAdvancedOptions.Name = "checkBoxAdvancedOptions";
            this.checkBoxAdvancedOptions.Size = new System.Drawing.Size(114, 17);
            this.checkBoxAdvancedOptions.TabIndex = 22;
            this.checkBoxAdvancedOptions.Text = "Advanced Options";
            this.checkBoxAdvancedOptions.UseVisualStyleBackColor = true;
            this.checkBoxAdvancedOptions.CheckedChanged += new System.EventHandler(this.checkBoxAdvancedOptions_CheckedChanged);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.MediumTurquoise;
            // 
            // createTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 454);
            this.Controls.Add(this.checkBoxAdvancedOptions);
            this.Controls.Add(this.panelAdvancedOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxStops);
            this.Controls.Add(this.comboEndStation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboStartStation);
            this.Controls.Add(this.pictureColourSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "createTrainForm";
            this.Text = "createTrainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureColourSelect)).EndInit();
            this.panelAdvancedOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEndStation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxStops;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboStartStation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureColourSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelAdvancedOptions;
        private System.Windows.Forms.CheckBox checkBoxAdvancedOptions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}