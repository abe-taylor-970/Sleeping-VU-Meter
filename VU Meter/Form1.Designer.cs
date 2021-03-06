﻿namespace VU_Meter
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gaugeLeft = new AGauge.AGauge();
            this.gaugeRight = new AGauge.AGauge();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.allowVariableMaxValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMaxValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTo0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTo20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTo40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gaugeLeft
            // 
            this.gaugeLeft.BaseArcColor = System.Drawing.Color.Black;
            this.gaugeLeft.BaseArcRadius = 150;
            this.gaugeLeft.BaseArcStart = 220;
            this.gaugeLeft.BaseArcSweep = 100;
            this.gaugeLeft.BaseArcWidth = 2;
            this.gaugeLeft.Cap_Idx = ((byte)(0));
            this.gaugeLeft.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.gaugeLeft.CapPosition = new System.Drawing.Point(127, 70);
            this.gaugeLeft.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(127, 70),
        new System.Drawing.Point(270, 77),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.gaugeLeft.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.gaugeLeft.CapText = "";
            this.gaugeLeft.Center = new System.Drawing.Point(140, 175);
            this.gaugeLeft.Location = new System.Drawing.Point(0, 0);
            this.gaugeLeft.MaxValue = 100F;
            this.gaugeLeft.MinValue = 0F;
            this.gaugeLeft.Name = "gaugeLeft";
            this.gaugeLeft.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Gray;
            this.gaugeLeft.NeedleColor2 = System.Drawing.Color.Black;
            this.gaugeLeft.NeedleRadius = 150;
            this.gaugeLeft.NeedleType = 0;
            this.gaugeLeft.NeedleWidth = 2;
            this.gaugeLeft.Range_Idx = ((byte)(1));
            this.gaugeLeft.RangeColor = System.Drawing.Color.Red;
            this.gaugeLeft.RangeEnabled = false;
            this.gaugeLeft.RangeEndValue = 100F;
            this.gaugeLeft.RangeInnerRadius = 150;
            this.gaugeLeft.RangeOuterRadius = 160;
            this.gaugeLeft.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.gaugeLeft.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.gaugeLeft.RangesEndValue = new float[] {
        75F,
        100F,
        0F,
        0F,
        0F};
            this.gaugeLeft.RangesInnerRadius = new int[] {
        150,
        150,
        70,
        70,
        70};
            this.gaugeLeft.RangesOuterRadius = new int[] {
        160,
        160,
        80,
        80,
        80};
            this.gaugeLeft.RangesStartValue = new float[] {
        0F,
        75F,
        0F,
        0F,
        0F};
            this.gaugeLeft.RangeStartValue = 75F;
            this.gaugeLeft.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeLeft.ScaleLinesInterInnerRadius = 145;
            this.gaugeLeft.ScaleLinesInterOuterRadius = 150;
            this.gaugeLeft.ScaleLinesInterWidth = 2;
            this.gaugeLeft.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeLeft.ScaleLinesMajorInnerRadius = 140;
            this.gaugeLeft.ScaleLinesMajorOuterRadius = 150;
            this.gaugeLeft.ScaleLinesMajorStepValue = 25F;
            this.gaugeLeft.ScaleLinesMajorWidth = 2;
            this.gaugeLeft.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.gaugeLeft.ScaleLinesMinorInnerRadius = 145;
            this.gaugeLeft.ScaleLinesMinorNumOf = 9;
            this.gaugeLeft.ScaleLinesMinorOuterRadius = 150;
            this.gaugeLeft.ScaleLinesMinorWidth = 1;
            this.gaugeLeft.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeLeft.ScaleNumbersFormat = null;
            this.gaugeLeft.ScaleNumbersRadius = 162;
            this.gaugeLeft.ScaleNumbersRotation = 90;
            this.gaugeLeft.ScaleNumbersStartScaleLine = 1;
            this.gaugeLeft.ScaleNumbersStepScaleLines = 2;
            this.gaugeLeft.Size = new System.Drawing.Size(280, 210);
            this.gaugeLeft.TabIndex = 4;
            this.gaugeLeft.Text = "aGauge1";
            this.gaugeLeft.Value = 0F;
            this.gaugeLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gaugeLeft_MouseDown);
            // 
            // gaugeRight
            // 
            this.gaugeRight.BaseArcColor = System.Drawing.Color.Black;
            this.gaugeRight.BaseArcRadius = 150;
            this.gaugeRight.BaseArcStart = 220;
            this.gaugeRight.BaseArcSweep = 100;
            this.gaugeRight.BaseArcWidth = 2;
            this.gaugeRight.Cap_Idx = ((byte)(0));
            this.gaugeRight.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.gaugeRight.CapPosition = new System.Drawing.Point(125, 70);
            this.gaugeRight.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(125, 70),
        new System.Drawing.Point(270, 77),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.gaugeRight.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.gaugeRight.CapText = "";
            this.gaugeRight.Center = new System.Drawing.Point(140, 175);
            this.gaugeRight.Location = new System.Drawing.Point(280, 0);
            this.gaugeRight.MaxValue = 100F;
            this.gaugeRight.MinValue = 0F;
            this.gaugeRight.Name = "gaugeRight";
            this.gaugeRight.NeedleColor1 = AGauge.AGauge.NeedleColorEnum.Gray;
            this.gaugeRight.NeedleColor2 = System.Drawing.Color.Black;
            this.gaugeRight.NeedleRadius = 150;
            this.gaugeRight.NeedleType = 0;
            this.gaugeRight.NeedleWidth = 2;
            this.gaugeRight.Range_Idx = ((byte)(1));
            this.gaugeRight.RangeColor = System.Drawing.Color.Red;
            this.gaugeRight.RangeEnabled = false;
            this.gaugeRight.RangeEndValue = 100F;
            this.gaugeRight.RangeInnerRadius = 150;
            this.gaugeRight.RangeOuterRadius = 160;
            this.gaugeRight.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.gaugeRight.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.gaugeRight.RangesEndValue = new float[] {
        75F,
        100F,
        0F,
        0F,
        0F};
            this.gaugeRight.RangesInnerRadius = new int[] {
        150,
        150,
        70,
        70,
        70};
            this.gaugeRight.RangesOuterRadius = new int[] {
        160,
        160,
        80,
        80,
        80};
            this.gaugeRight.RangesStartValue = new float[] {
        0F,
        75F,
        0F,
        0F,
        0F};
            this.gaugeRight.RangeStartValue = 75F;
            this.gaugeRight.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.gaugeRight.ScaleLinesInterInnerRadius = 145;
            this.gaugeRight.ScaleLinesInterOuterRadius = 150;
            this.gaugeRight.ScaleLinesInterWidth = 2;
            this.gaugeRight.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.gaugeRight.ScaleLinesMajorInnerRadius = 140;
            this.gaugeRight.ScaleLinesMajorOuterRadius = 150;
            this.gaugeRight.ScaleLinesMajorStepValue = 25F;
            this.gaugeRight.ScaleLinesMajorWidth = 2;
            this.gaugeRight.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.gaugeRight.ScaleLinesMinorInnerRadius = 145;
            this.gaugeRight.ScaleLinesMinorNumOf = 9;
            this.gaugeRight.ScaleLinesMinorOuterRadius = 150;
            this.gaugeRight.ScaleLinesMinorWidth = 1;
            this.gaugeRight.ScaleNumbersColor = System.Drawing.Color.Black;
            this.gaugeRight.ScaleNumbersFormat = null;
            this.gaugeRight.ScaleNumbersRadius = 162;
            this.gaugeRight.ScaleNumbersRotation = 90;
            this.gaugeRight.ScaleNumbersStartScaleLine = 1;
            this.gaugeRight.ScaleNumbersStepScaleLines = 2;
            this.gaugeRight.Size = new System.Drawing.Size(280, 210);
            this.gaugeRight.TabIndex = 5;
            this.gaugeRight.Text = "aGauge1";
            this.gaugeRight.Value = 0F;
            this.gaugeRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gaugeRight_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allowVariableMaxValueToolStripMenuItem,
            this.resetMaxValueToolStripMenuItem,
            this.toolStripSeparator4,
            this.optionsToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 142);
            // 
            // allowVariableMaxValueToolStripMenuItem
            // 
            this.allowVariableMaxValueToolStripMenuItem.CheckOnClick = true;
            this.allowVariableMaxValueToolStripMenuItem.Name = "allowVariableMaxValueToolStripMenuItem";
            this.allowVariableMaxValueToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.allowVariableMaxValueToolStripMenuItem.Text = "Allow Variable Max Value";
            this.allowVariableMaxValueToolStripMenuItem.Click += new System.EventHandler(this.allowVariableMaxValueToolStripMenuItem_Click);
            // 
            // resetMaxValueToolStripMenuItem
            // 
            this.resetMaxValueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetTo0ToolStripMenuItem,
            this.resetTo20ToolStripMenuItem,
            this.resetTo40ToolStripMenuItem});
            this.resetMaxValueToolStripMenuItem.Name = "resetMaxValueToolStripMenuItem";
            this.resetMaxValueToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.resetMaxValueToolStripMenuItem.Text = "Reset Max Value";
            this.resetMaxValueToolStripMenuItem.Click += new System.EventHandler(this.resetMaxValueToolStripMenuItem_Click);
            // 
            // resetTo0ToolStripMenuItem
            // 
            this.resetTo0ToolStripMenuItem.Name = "resetTo0ToolStripMenuItem";
            this.resetTo0ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.resetTo0ToolStripMenuItem.Text = "Reset to 0";
            this.resetTo0ToolStripMenuItem.Click += new System.EventHandler(this.resetTo0ToolStripMenuItem_Click);
            // 
            // resetTo20ToolStripMenuItem
            // 
            this.resetTo20ToolStripMenuItem.Name = "resetTo20ToolStripMenuItem";
            this.resetTo20ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.resetTo20ToolStripMenuItem.Text = "Reset to 20";
            this.resetTo20ToolStripMenuItem.Click += new System.EventHandler(this.resetTo20ToolStripMenuItem_Click);
            // 
            // resetTo40ToolStripMenuItem
            // 
            this.resetTo40ToolStripMenuItem.Name = "resetTo40ToolStripMenuItem";
            this.resetTo40ToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.resetTo40ToolStripMenuItem.Text = "Reset to 40";
            this.resetTo40ToolStripMenuItem.Click += new System.EventHandler(this.resetTo40ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(203, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Left %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Right %";
            // 
            // lblMax
            // 
            this.lblMax.Location = new System.Drawing.Point(532, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(28, 13);
            this.lblMax.TabIndex = 9;
            this.lblMax.Text = "100";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 94);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gaugeLeft);
            this.Controls.Add(this.gaugeRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VU Meter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private AGauge.AGauge gaugeLeft;
        private AGauge.AGauge gaugeRight;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem resetMaxValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allowVariableMaxValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTo0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTo40ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetTo20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblMax;
    }
}