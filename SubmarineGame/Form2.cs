using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubmarineGame
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// This window will show the summary of the game
        /// </summary>
        public Form2()
        {
            InitializeComponent();

        }

        /// <summary>
        /// This function updates the values in the window that opens
        /// </summary>
        /// <param name="xVal"></param>
        /// <param name="yVal"></param>
        /// <param name="clickeSubmarine"></param>
        /// <param name="clickeNotSubmarine"></param>
        /// <param name="dictionary"></param>
        /// <param name="score"></param>
        internal void SendVals(int xVal, int yVal, int clickeSubmarine, int clickeNotSubmarine, Dictionary<decimal, decimal> dictionary, int score)
        {
            this.label12.Text = "[ " + Convert.ToString(xVal)+ " , " + Convert.ToString(yVal)+" ]";
            this.label12.Visible = true;

            this.label13.Text = Convert.ToString(dictionary[4]) ;
            this.label13.Visible = true;
            this.label14.Text = Convert.ToString(dictionary[3]);
            this.label14.Visible = true;
            this.label15.Text = Convert.ToString(dictionary[2]);
            this.label15.Visible = true;
            this.label16.Text = Convert.ToString(dictionary[1]);
            this.label16.Visible = true;

            this.label17.Text = Convert.ToString(clickeSubmarine+ clickeNotSubmarine);
            this.label17.Visible = true;

            this.label18.Text = Convert.ToString(clickeSubmarine);
            this.label18.Visible = true;
            this.label19.Text = Convert.ToString(clickeNotSubmarine);
            this.label19.Visible = true;

            this.label20.Text = Convert.ToString(score);
            this.label20.Visible = true;
        }
    }
}
