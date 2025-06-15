using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektProg
{
    public partial class buttonReset : Form
    {
        public buttonReset()
        {
            InitializeComponent();
        }

        bool Player1 = true;
        int turn = 0;

        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
            lblScoreO.Text = "0";
            lblScoreX.Text = "0";
            lblTurn.Text = "X";
            Player1 = true;
        }

        private void Reset()
        {
            turn = 0;
            Button[] all = new Button[9];
            all[0] = button1;
            all[1] = button2;
            all[2] = button3;
            all[3] = button4;
            all[4] = button5;
            all[5] = button6;
            all[6] = button7;
            all[7] = button8;
            all[8] = button9;
            foreach (Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";
        }

        private void Check()
        {
            if (button1.Text != "" && button1.Text == button2.Text && button2.Text == button3.Text)
            {
                Win();
            }
            else if (button1.Text != "" && button1.Text == button4.Text && button4.Text == button7.Text)
            {
                Win();
            }
            else if (button1.Text != "" && button1.Text == button5.Text && button5.Text == button9.Text)
            {
                Win();
            }
            else if (button2.Text != "" && button2.Text == button5.Text && button5.Text == button8.Text)
            {
                Win();
            }
            else if (button3.Text != "" && button3.Text == button6.Text && button6.Text == button9.Text)
            {
                Win();
            }
            else if (button4.Text != "" && button4.Text == button5.Text && button5.Text == button6.Text)
            {
                Win();
            }
            else if (button7.Text != "" && button7.Text == button8.Text && button8.Text == button9.Text)
            {
                Win();
            }
            else if (button3.Text != "" && button3.Text == button5.Text && button5.Text == button7.Text)
            {
                Win();
            }
            else if(turn==9)
            {
                MessageBox.Show("It's a tie!", "Good game!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

        }

        private void Win()
        {
            MessageBox.Show("The winner is: " + (Player1 ? "X" : "O"), "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Player1)
                lblScoreX.Text = ((int.Parse(lblScoreX.Text)) + 1).ToString();
            else
                lblScoreO.Text = ((int.Parse(lblScoreO.Text)) + 1).ToString();
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            turn++;
            ((Button)sender).Text = Player1 ? "X" : "O";
            ((Button)sender).Enabled = false;
            if (turn >= 5)
            {
                Check();
            }
            Player1 = !Player1;
            lblTurn.Text = Player1 ? "X" : "O";

        }
    }
}
