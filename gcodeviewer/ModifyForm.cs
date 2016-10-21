using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gcodeparser
{
    public partial class ModifyForm : Form
    {
        private MainForm mainForm;

        public ModifyForm(MainForm mainform)
        {
            this.mainForm = mainform;
            InitializeComponent();
        }

        private void ModifyForm_KeyDown(object sender, KeyEventArgs e)
        {
            float steps = e.Shift ? .1f : 1.0f;
            bool axisX = false, axisY = false;

            switch (e.KeyCode)
            {
                case Keys.Down: axisY = true; steps = -steps; break;
                case Keys.Up: axisY = true; break;
                case Keys.Left: axisX = true; steps = -steps; break;
                case Keys.Right: axisX = true; break;
                case Keys.Add:
                    if (this.mainForm.ViewDevice.CurrentCodeLineIndex < this.mainForm.ViewDevice.CodeLines.Count - 1)
                        this.mainForm.ViewDevice.CurrentCodeLineIndex++; break;
                case Keys.Subtract:
                    if (this.mainForm.ViewDevice.CurrentCodeLineIndex > 0)
                        this.mainForm.ViewDevice.CurrentCodeLineIndex--; break;
                default: return;
            }


            foreach (ViewerStep step in this.mainForm.ViewDevice.CodeLines[this.mainForm.ViewDevice.CurrentCodeLineIndex].Steps)
            {
                if (axisX)
                {
                    step.Start.X += steps;
                }

                if (axisY)
                {
                    step.Start.Y += steps;
                }
            }

            if (this.mainForm.ViewDevice.CurrentCodeLineIndex > 0)
            {

                foreach (ViewerStep step in this.mainForm.ViewDevice.CodeLines[this.mainForm.ViewDevice.CurrentCodeLineIndex - 1].Steps)
                {
                    if (axisX)
                    {
                        step.End.X += steps;
                    }

                    if (axisY)
                    {
                        step.End.Y += steps;
                    }
                }
            }



            this.mainForm.ViewDevice.InvalidateParentControl();

            //this.mainForm.ViewDevice.CurrentStep.GCodeLine
        }
    }
}
