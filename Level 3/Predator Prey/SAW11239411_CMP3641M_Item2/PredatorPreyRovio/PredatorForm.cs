using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PredatorPreyRovio
{
    public partial class PredatorForm : Form
    {
        Rovio.Predator robot;
        System.Threading.Thread t2;
        public PredatorForm()
        {
            InitializeComponent();
        }

        public PredatorForm(string IP)
        {
            robot = new Rovio.Predator(IP, "admin", "administrator");
            robot.sourceImage += this.updateSource;
            robot.filterImage += this.updateFilt;
            robot.filterImage2 += this.updateGreen;
            robot.filterImage3 += this.updateBlue;
            t2 = new System.Threading.Thread(robot.stateMachine);
            t2.Start();
            InitializeComponent();
        }

        public delegate void UpdateSourceImage(Image image);
        public delegate void UpdateFiltImage(Image image);
        public delegate void UpdateGreenImage(Image image);
        public delegate void UpdateBlueFilt(Image image);

        public void updateSource(Image image)
        {
            sourceImage.Image = image;
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate { updateSource(image); }));
            this.updateState();
        }

        public void updateFilt(Image image)
        {
            filtImage.Image = image;
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate { updateFilt(image); }));
            this.updateState();
        }

        public void updateGreen(Image image)
        {
            greenFilt.Image = image;
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate { updateGreen(image); }));
            this.updateState();
        }

        public void updateBlue(Image image)
        {
            blueImage.Image = image;
            if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate { updateBlue(image); }));
            this.updateState();
        }

        public void updateState()
        {
            stateLabel.Text = (robot.getState());
            label3.Text = (robot.getColour());
            label4.Text = (robot.getDir());
        }

        private void PredatorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t2.Suspend();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t2.Resume();
        }



    }
}
