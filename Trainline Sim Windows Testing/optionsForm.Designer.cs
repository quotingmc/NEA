﻿namespace Trainline_Sim_Windows_Testing
{
    partial class optionsForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDrawIntervals = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show Intervals";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Display Options:";
            // 
            // checkBoxDrawIntervals
            // 
            this.checkBoxDrawIntervals.AutoSize = true;
            this.checkBoxDrawIntervals.Location = new System.Drawing.Point(15, 25);
            this.checkBoxDrawIntervals.Name = "checkBoxDrawIntervals";
            this.checkBoxDrawIntervals.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDrawIntervals.TabIndex = 6;
            this.checkBoxDrawIntervals.Text = "Show Intervals";
            this.checkBoxDrawIntervals.UseVisualStyleBackColor = true;
            this.checkBoxDrawIntervals.CheckedChanged += new System.EventHandler(this.checkBoxDrawIntervals_CheckedChanged);
            // 
            // optionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 591);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDrawIntervals);
            this.Name = "optionsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDrawIntervals;
    }
}