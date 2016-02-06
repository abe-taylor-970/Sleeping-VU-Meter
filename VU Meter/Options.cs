using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VU_Meter
{
    public partial class Options : Form
    {
        public Color leftBack
        {
            get { return btnLeftBack.BackColor; }
            set { btnLeftBack.BackColor = value; }
        }

        public Color leftNeedle
        {
            get { return btnLeftNeedle.BackColor; }
            set { btnLeftNeedle.BackColor = value; }
        }

        public Color leftArc
        {
            get { return btnLeftArc.BackColor; }
            set { btnLeftArc.BackColor = value; }
        }

        public Color leftMajor
        {
            get { return btnLeftMajor.BackColor; }
            set { btnLeftMajor.BackColor = value; }
        }

        public Color leftMinor
        {
            get { return btnLeftMinor.BackColor; }
            set { btnLeftMinor.BackColor = value; }
        }

        public Color leftText
        {
            get { return btnLeftText.BackColor; }
            set { btnLeftText.BackColor = value; }
        }

        public Color rightBack
        {
            get { return btnRightBack.BackColor; }
            set { btnRightBack.BackColor = value; }
        }

        public Color rightNeedle
        {
            get { return btnRightNeedle.BackColor; }
            set { btnRightNeedle.BackColor = value; }
        }

        public Color rightArc
        {
            get { return btnRightArc.BackColor; }
            set { btnRightArc.BackColor = value; }
        }

        public Color rightMajor
        {
            get { return btnRightMajor.BackColor; }
            set { btnRightMajor.BackColor = value; }
        }

        public Color rightMinor
        {
            get { return btnRightMinor.BackColor; }
            set { btnRightMinor.BackColor = value; }
        }

        public Color rightText
        {
            get { return btnRightText.BackColor; }
            set { btnRightText.BackColor = value; }
        }

        public Boolean onTop
        {
            get { return chkOnTop.Checked; }
            set { chkOnTop.Checked = value; }
        }

        public Boolean Horiz
        {
            get { return radHoriz.Checked; }
            set { radHoriz.Checked = value; }
        }

        public Boolean Vert
        {
            get { return radVert.Checked; }
            set { radVert.Checked = value; }
        }

        public int response
        {
            get { return Convert.ToInt16(cmbResponse.SelectedItem); }
            set { cmbResponse.SelectedItem = Convert.ToString(value); }
        }

        public Options()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnLeftBack_Click(object sender, EventArgs e)
        {
            color.Color = btnLeftBack.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnLeftBack.BackColor = color.Color;
        }

        private void btnLeftNeedle_Click(object sender, EventArgs e)
        {
            color.Color = btnLeftNeedle.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnLeftNeedle.BackColor = color.Color;
        }

        private void btnLeftArc_Click(object sender, EventArgs e)
        {
            color.Color = btnLeftArc.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnLeftArc.BackColor = color.Color;
        }

        private void btnLeftMajor_Click(object sender, EventArgs e)
        {
            color.Color = btnLeftMajor.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnLeftMajor.BackColor = color.Color;
        }

        private void btnLeftMinor_Click(object sender, EventArgs e)
        {
            color.Color = btnLeftMinor.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnLeftMinor.BackColor = color.Color;
        }

        private void btnLeftText_Click(object sender, EventArgs e)
        {
            color.Color = btnLeftText.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnLeftText.BackColor = color.Color;
        }

        private void btnRightBack_Click(object sender, EventArgs e)
        {
            color.Color = btnRightBack.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnRightBack.BackColor = color.Color;
        }

        private void btnRightNeedle_Click(object sender, EventArgs e)
        {
            color.Color = btnRightNeedle.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnRightNeedle.BackColor = color.Color;
        }

        private void btnRightArc_Click(object sender, EventArgs e)
        {
            color.Color = btnRightArc.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnRightArc.BackColor = color.Color;
        }

        private void btnRightMajor_Click(object sender, EventArgs e)
        {
            color.Color = btnRightMajor.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnRightMajor.BackColor = color.Color;
        }

        private void btnRightMinor_Click(object sender, EventArgs e)
        {
            color.Color = btnRightMinor.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnRightMinor.BackColor = color.Color;
        }

        private void btnRightText_Click(object sender, EventArgs e)
        {
            color.Color = btnRightText.BackColor;
            if (color.ShowDialog() == DialogResult.OK)
                btnRightText.BackColor = color.Color;
        }
    }
}
