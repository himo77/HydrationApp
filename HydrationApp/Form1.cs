using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydrationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Setting initial color for both background and foreground
            this.BackColor = Color.DarkGray;
            this.ForeColor = Color.Black;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Fetching the value from the NumericUpDown control
            decimal waterQuantity = this.nudWaterQuantity.Value;

            //Based on the value, choosing the right message and
            //the background and foreground colors.
            if (waterQuantity >= 0 && waterQuantity <= 1)
            {
                this.lblStatus.Text = "Drink some water!";
                this.BackColor = Color.DarkGray;
                this.ForeColor = Color.Black;
            }
            else if (waterQuantity >= 2 && waterQuantity <= 3)
            {
                this.lblStatus.Text = "Good job!";
                this.BackColor = Color.LightBlue;
                this.ForeColor = Color.Black;
            }
            else if (waterQuantity >= 4 && waterQuantity <= 6)
            {
                this.lblStatus.Text = "Awesome!";
                this.BackColor = Color.MediumAquamarine;
                this.ForeColor = Color.Black;
            }
            else if (waterQuantity >= 6 && waterQuantity <= 9)
            {
                this.lblStatus.Text = "Just right!";
                this.BackColor = Color.DarkBlue;
                this.ForeColor = Color.White;
            }
            else if (waterQuantity >= 9)
            {
                this.lblStatus.Text = "Too much!";
                this.BackColor = Color.Red;
                this.ForeColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
