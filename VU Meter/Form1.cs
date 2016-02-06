using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CoreAudioApi;

namespace VU_Meter
{
    public partial class Form1 : Form
    {
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int WM_NCHITTEST = 0x84;
        const int HT_CAPTION = 0x2;

        private List<float> left = new List<float>();
        private List<float> right = new List<float>();

        private MMDevice device;

        private static int countForSleep = 0;

        public Form1()
        {
            InitializeComponent();
            
            MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
            device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
            this.Location = Properties.Settings.Default.location;
            this.TopMost = Properties.Settings.Default.TopMost;
            if (Properties.Settings.Default.variablevalue == true)
            {
                allowVariableMaxValueToolStripMenuItem.Checked = true;
                int zero = 1;
                lblMax.Text = zero.ToString();
                resetMaxValueToolStripMenuItem.Enabled = true;
            }
            else
            {
                allowVariableMaxValueToolStripMenuItem.Checked = false;
                int zero = 100;
                lblMax.Text = zero.ToString();
                resetMaxValueToolStripMenuItem.Enabled = false;
            }
            ChangeFontColors();
        }

        public void ChangeFontColors()
        {
            //Properties.Settings.Default.Save();
            gaugeLeft.BackColor = Properties.Settings.Default.LeftBackColor;
            gaugeLeft.NeedleColor2 = Properties.Settings.Default.LeftNeedle;
            gaugeLeft.BaseArcColor = Properties.Settings.Default.LeftArc;
            gaugeLeft.ScaleLinesMajorColor = Properties.Settings.Default.LeftMajor;
            gaugeLeft.ScaleLinesInterColor = Properties.Settings.Default.LeftMajor;
            gaugeLeft.ScaleLinesMinorColor = Properties.Settings.Default.LeftMinor;
            gaugeLeft.ScaleNumbersColor = Properties.Settings.Default.LeftText;
            label1.ForeColor = Properties.Settings.Default.LeftText;
            label1.BackColor = Properties.Settings.Default.LeftBackColor;
            gaugeRight.BackColor = Properties.Settings.Default.RightBackColor;
            gaugeRight.NeedleColor2 = Properties.Settings.Default.RightNeedle;
            gaugeRight.BaseArcColor = Properties.Settings.Default.RightArc;
            gaugeRight.ScaleLinesMajorColor = Properties.Settings.Default.RightMajor;
            gaugeRight.ScaleLinesInterColor = Properties.Settings.Default.RightMajor;
            gaugeRight.ScaleLinesMinorColor = Properties.Settings.Default.RightMinor;
            gaugeRight.ScaleNumbersColor = Properties.Settings.Default.RightText;
            label2.ForeColor = Properties.Settings.Default.RightText;
            label2.BackColor = Properties.Settings.Default.RightBackColor;
            lblMax.ForeColor = Properties.Settings.Default.RightText;
            lblMax.BackColor = Properties.Settings.Default.RightBackColor;
            this.TopMost = Properties.Settings.Default.TopMost;

            if (Properties.Settings.Default.Horizontal)
            {
                this.Size = new Size(560, 94);
                gaugeLeft.BringToFront();
                gaugeRight.Location = new Point(280, 0);
                gaugeRight.BringToFront();
                label1.Location = new Point(123, 72);
                label1.BringToFront();
                label2.Location = new Point(400, 72);
                label2.BringToFront();
                lblMax.Location = new Point(532, 0);
                lblMax.BringToFront();
            }
            else
            {
                this.Size = new Size(280, 188);
                gaugeLeft.BringToFront();
                gaugeRight.Location = new Point(0, 93);
                gaugeRight.BringToFront();
                label1.Location = new Point(124, 56);
                label1.BringToFront();
                label2.Location = new Point(121, 156);
                label2.BringToFront();
                lblMax.Location = new Point(252, 0);
                lblMax.BringToFront();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double value = device.AudioMeterInformation.PeakValues[0] * 100;
            if (left.Count == 10)
                left.RemoveAt(0);
            left.Add((float)value);
            double leftaverage = left.Average();

            value = device.AudioMeterInformation.PeakValues[1] * 100;
            if (right.Count == 10)
                right.RemoveAt(0);
            right.Add((float)value);
            double rightaverage = right.Average();

            if (leftaverage > rightaverage)
            {
                if (leftaverage > Convert.ToDouble(lblMax.Text))
                {
                    float interval;
                    float max;
                    interval = (float)Math.Ceiling(leftaverage / 4);
                    max = interval * 4;
                    lblMax.Text = max.ToString();
                }
            }
            else
            {
                if (rightaverage > Convert.ToDouble(lblMax.Text))
                {
                    float interval;
                    float max;
                    interval = (float)Math.Ceiling(rightaverage / 4);
                    max = interval * 4;
                    lblMax.Text = max.ToString();
                }
            }

            gaugeLeft.Value = (float)(leftaverage / (Convert.ToDouble(lblMax.Text) / 100));
            gaugeRight.Value = (float)(rightaverage / (Convert.ToDouble(lblMax.Text) / 100));

            if ((gaugeLeft.Value == 0) && (gaugeRight.Value == 0))  {
                ++countForSleep;
       //         System.Console.WriteLine(countForSleep);
            }
            else {
                countForSleep = 0;
            }
            /*
            if (countForSleep == 100)
            {
                System.Diagnostics.Process.Start("shutdown", "/s");
            }
            */
            if (countForSleep == 9500) {
                Application.SetSuspendState(PowerState.Suspend, true, true);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeftBackColor = colorDialog1.Color;
                gaugeLeft.BackColor = colorDialog1.Color;
                label1.BackColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void needleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeftNeedle = colorDialog1.Color;
                gaugeLeft.NeedleColor2 = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void arcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeftArc = colorDialog1.Color;
                gaugeLeft.BaseArcColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void majorLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeftMajor = colorDialog1.Color;
                gaugeLeft.ScaleLinesMajorColor = colorDialog1.Color;
                gaugeLeft.ScaleLinesInterColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void minorLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeftMinor = colorDialog1.Color;
                gaugeLeft.ScaleLinesMinorColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void backColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.RightBackColor = colorDialog1.Color;
                gaugeRight.BackColor = colorDialog1.Color;
                label2.BackColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void needleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.RightNeedle = colorDialog1.Color;
                gaugeRight.NeedleColor2 = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void arcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.RightArc = colorDialog1.Color;
                gaugeRight.BaseArcColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void majorLinesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.RightMajor = colorDialog1.Color;
                gaugeRight.ScaleLinesMajorColor = colorDialog1.Color;
                gaugeRight.ScaleLinesInterColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void minorLinesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.RightMinor = colorDialog1.Color;
                gaugeRight.ScaleLinesMinorColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeftText = colorDialog1.Color;
                gaugeLeft.ScaleNumbersColor = colorDialog1.Color;
                label1.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.RightText = colorDialog1.Color;
                gaugeRight.ScaleNumbersColor = colorDialog1.Color;
                label2.ForeColor = colorDialog1.Color;
                Properties.Settings.Default.Save();
            }
        }

        private void resetColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            ChangeFontColors();
        }

        private void resetMaxValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void resetTo0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int zero = 1;
            lblMax.Text = zero.ToString();
            left.Clear();
        }

        private void resetTo20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int zero = 20;
            lblMax.Text = zero.ToString();
            left.Clear();
        }

        private void resetTo40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int zero = 40;
            lblMax.Text = zero.ToString();
            left.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.location = this.Location;
            Properties.Settings.Default.Save();
        }

        private void allowVariableMaxValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allowVariableMaxValueToolStripMenuItem.Checked == true)
            {
                Properties.Settings.Default.variablevalue = true;
                Properties.Settings.Default.Save();
                int zero = 1;
                lblMax.Text = zero.ToString();
                left.Clear();
                resetMaxValueToolStripMenuItem.Enabled = true;
            }
            if (allowVariableMaxValueToolStripMenuItem.Checked == false)
            {
                Properties.Settings.Default.variablevalue = false;
                Properties.Settings.Default.Save();
                int zero = 100;
                lblMax.Text = zero.ToString();
                left.Clear();
                resetMaxValueToolStripMenuItem.Enabled = false;
            }
        }

        private void gaugeLeft_MouseDown(object sender, MouseEventArgs e)
        {
            gaugeLeft.Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            WndProc(ref msg);
        }

        private void gaugeRight_MouseDown(object sender, MouseEventArgs e)
        {
            gaugeRight.Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            WndProc(ref msg);
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();

            options.leftBack = Properties.Settings.Default.LeftBackColor;
            options.leftNeedle = Properties.Settings.Default.LeftNeedle;
            options.leftArc = Properties.Settings.Default.LeftArc;
            options.leftMajor = Properties.Settings.Default.LeftMajor;
            options.leftMinor = Properties.Settings.Default.LeftMinor;
            options.leftText = Properties.Settings.Default.LeftText;
            options.rightBack = Properties.Settings.Default.RightBackColor;
            options.rightNeedle = Properties.Settings.Default.RightNeedle;
            options.rightArc = Properties.Settings.Default.RightArc;
            options.rightMajor = Properties.Settings.Default.RightMajor;
            options.rightMinor = Properties.Settings.Default.RightMinor;
            options.rightText = Properties.Settings.Default.RightText;
            options.onTop = Properties.Settings.Default.TopMost;
            options.response = (timer1.Interval * 10);
            if (Properties.Settings.Default.Horizontal)
                options.Horiz = true;
            else
                options.Vert = true;

            if (options.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.LeftBackColor = options.leftBack;
                Properties.Settings.Default.LeftNeedle = options.leftNeedle;
                Properties.Settings.Default.LeftArc = options.leftArc;
                Properties.Settings.Default.LeftMajor = options.leftMajor;
                Properties.Settings.Default.LeftMinor = options.leftMinor;
                Properties.Settings.Default.LeftText = options.leftText;
                Properties.Settings.Default.RightBackColor = options.rightBack;
                Properties.Settings.Default.RightNeedle = options.rightNeedle;
                Properties.Settings.Default.RightArc = options.rightArc;
                Properties.Settings.Default.RightMajor = options.rightMajor;
                Properties.Settings.Default.RightMinor = options.rightMinor;
                Properties.Settings.Default.RightText = options.rightText;
                Properties.Settings.Default.TopMost = options.onTop;
                if (options.Horiz)
                    Properties.Settings.Default.Horizontal = true;
                else
                    Properties.Settings.Default.Horizontal = false;
                ChangeFontColors();
                timer1.Interval = options.response / 10;
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();

            if (about.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
