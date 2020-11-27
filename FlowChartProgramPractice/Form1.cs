using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FlowChartProgramPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            helloWorldlabel.Visible = false;
            goodbyeLabel.Visible = false;
            exitButton.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Black;

            startButton.Visible = false;

            helloWorldlabel.Visible = true;
            Refresh();
            Thread.Sleep(3000);

            this.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);

            this.BackColor = Color.Black;
            Refresh();
            Thread.Sleep(500);

            this.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);

            this.BackColor = Color.Black;
            Refresh();
            Thread.Sleep(500);

            helloWorldlabel.Visible = false;

            exitButton.Visible = true;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitButton.Visible = false;

            goodbyeLabel.Visible = true;
            Refresh();
            Thread.Sleep(2500);
            Application.Exit();
            

        }
    }
}
