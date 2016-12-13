using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_DataStructAndAlgorithms
{
    public partial class Form1 : Form
    {
        public Time time_score;

        public Form1()
        {
            InitializeComponent();

            this.Text = Application.ProductName + " " + Application.ProductVersion;

            NewGame();
        }
        private void NewGame()
        {
            minefields.NewGame();
            RenewForm();
        }
        private void NewGame(int rows, int cols, int mines)
        {
            minefields.NewGame(rows, cols, mines);
            RenewForm();
        }
        private void RenewForm()
        {
            BTN_Status.BackgroundImage = Properties.Resources.play;
            this.Height = minefields.Height + this.P_Head.Height + this.M_Head.Height + 40;
            this.Width = minefields.Width + 20;
            LB_Boom.Text = String.Format("{0:000}", minefields.MinesCount);
            UpdateFlag();

            //time 
            time_score = new Time();
            // timer
            timer1.Enabled = true;
        }
        void UpdateFlag()
        {
            LB_Flag.Text = String.Format("{0:000}", minefields.MinesCount - minefields.FlagsCount);
            if (minefields.RemainCellsCount == minefields.MinesCount)
                BTN_Status.BackgroundImage = Properties.Resources.win;                
        }

        // Playing event
        private void minesfields_firebombEvent(object sender, EventArgs e)
        {
            BTN_Status.BackgroundImage = Properties.Resources.lost;
            timer1.Enabled = false;
        }

        private void minefields_CellClick(object sender, EventArgs e)
        {
            UpdateFlag();
        }
        // Menu head
        private void TS_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Status_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        // Load
        private void minefields_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Mode
        private void TS_Easy_Click(object sender, EventArgs e)
        {
            NewGame(9, 9, 10);
        }

        private void TS_Normal_Click(object sender, EventArgs e)
        {
            NewGame(16, 16, 40);
        }

        private void TS_Advanced_Click(object sender, EventArgs e)
        {
            NewGame(16, 30, 99);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_score.loadTime();
            LB_Time.Text = time_score.ToString();
        }

    }
}
