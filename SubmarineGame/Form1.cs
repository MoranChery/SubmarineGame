using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SubmarineGame
{
    /// <summary>
    /// This class is the logical part of the game in the main window
    /// </summary>
    public partial class Form1 : Form
    {
        Board board;
        int xVal = 10;
        int yVal = 10;
        int levVal = 1;
        int clickeSubmarine = 0;
        int clickeNotSubmarine = 0;

        public Form1()
        {
            InitializeComponent();
            Closing += OnClosing;
        }

        /// <summary>
        /// This function notifies the user when he closes the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="cancelEventArgs"></param>
        private void OnClosing(object sender, CancelEventArgs cancelEventArgs)
        {
            const string message = "Are you sure you want to exit?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
            {
                cancelEventArgs.Cancel = true;
            }
        }

        /// <summary>
        /// This function updates the value in the TextBox cells
        /// only when numbers are pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /// <summary>
        /// This function displays the game board according to the data
        /// obtained when the start button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Start_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBoxX.Text, out xVal) && int.TryParse(textBoxY.Text, out yVal) && int.TryParse(textBoxLev.Text, out levVal))
            {
                textBoxX.ReadOnly= true;
                textBoxY.ReadOnly = true;
                textBoxLev.ReadOnly = true;
                buttonStart.Visible = false;
                CraeteBord(xVal, yVal, levVal);

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xVal"></param>
        /// <param name="yVal"></param>
        /// <param name="levVal"></param>
        private void CraeteBord(int xVal, int yVal, int levVal)
        {
            board = new Board(xVal, yVal, levVal);
            int startPointX = 15;
            int startPointY = 15;
            int sizeX = xVal * 17;
            int sizeY = xVal * 17;
            this.groupBoxBorad.Size = new Size(sizeX, sizeY);
            this.groupBoxBorad.Visible = true;
            for (int i= 0; i<xVal; i++)
            {
                for(int j = 0; j<yVal; j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(pictureBox)).BeginInit();
                    pictureBox.Size = new System.Drawing.Size(15, 15);
                    pictureBox.TabIndex = i* yVal +j+ 1;
                    pictureBox.TabStop = false;
                    pictureBox.Click += new System.EventHandler(this.CellClick);
                    pictureBox.BackColor = Color.FromArgb(0, 0, 255);
                    pictureBox.Location = new System.Drawing.Point(startPointX+(i*17), startPointY+j*17);
                    groupBoxBorad.Controls.Add(pictureBox);
                    ((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
                }
            }
            this.groupBoxBorad.ResumeLayout(false);
            SetTimer(levVal);
        }

        /// <summary>
        /// This function creates the game board,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CellClick(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            int coordinatX = (clickedPictureBox.Location.X -15) /17;
            int coordinatY = (clickedPictureBox.Location.Y -15) /17;
            int hit = board.CellHit(coordinatX, coordinatY);
            if(hit == 1)
            {
                clickedPictureBox.BackColor = Color.FromArgb(255, 0, 0);
                clickeSubmarine++;
            }
            if (hit == 2)
            {
                clickedPictureBox.BackColor = Color.FromArgb(255, 255, 255); 
                clickeNotSubmarine++;
            }

            if(board.GetAllAreaSubmarine() == clickeSubmarine)
            {
                Form2 win2 = new Form2();
                decimal val1 =(xVal * yVal);
                decimal val2 = Convert.ToDecimal(clickeNotSubmarine);
                decimal val = (val2 / val1) * Convert.ToDecimal(100);
                int score = Convert.ToInt32( 100 - Math.Floor(val));
                win2.SendVals(xVal, yVal , clickeSubmarine, clickeNotSubmarine, board.GetDict(), score);
                win2.Show();
            }
        }

        /// <summary>
        /// This function creates a timer that operates at the beginning of the game
        /// according to the received level,it displays the submarines
        /// for the appropriate time.
        /// </summary>
        /// <param name="lev"></param>
        private void SetTimer(int lev)
        {
            var t = new Timer();

            if (lev < 5)
            {
                t.Start();
                ShowSubmarines();
                t.Interval = (5 - lev) * 1000;
                t.Tick += (s, e) =>
                {
                    UnShowSubmarines();
                    t.Stop();
                };
                
            }
        }

        /// <summary>
        /// This function hides the submarines
        /// </summary>
        private void UnShowSubmarines()
        {
            var controls = this.groupBoxBorad.Controls.Cast<PictureBox>();
            foreach (PictureBox control in controls)
            {
                int coordinatX = (control.Location.X - 15) / 17;
                int coordinatY = (control.Location.Y - 15) / 17;


                if (board.IsCellHit(coordinatX, coordinatY) == 0 && board.CellSubmarines(coordinatX, coordinatY) )
                {
                    control.BackColor = Color.FromArgb(255, 0, 0);
                }
                else if (board.IsCellHit(coordinatX, coordinatY) == 1)
                {
                    control.BackColor = Color.FromArgb(0, 0, 255);
                }

            }
        }

        /// <summary>
        /// This function displays the submarines
        /// </summary>
        private void ShowSubmarines()
        {
            var controls = this.groupBoxBorad.Controls.Cast<PictureBox>();
            foreach (PictureBox control in controls)
            {
                int coordinatX = (control.Location.X - 15) / 17;
                int coordinatY = (control.Location.Y - 15) / 17;
                

                if (board.CellSubmarines(coordinatX, coordinatY)) {
                    control.BackColor = Color.FromArgb(200, 30, 255);
                }
                
            }
        }
    }
}