using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE_WinForm
{
    public partial class Form1 : Form
    {
        int turn = 1;
        int i, j;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (turn == 1)
            {
                btn.Text = "O";
            }
            else
            {
                btn.Text = "X";
            }
            btn.Enabled = false;
            win(btn.Text.ToString());
            turn += 1;
            if (turn > 2)
                turn = 1;
        }
        private void win(string btnContent)
        {
            if ((button1.Text == btnContent & button2.Text == btnContent &
                 button3.Text == btnContent)
               | (button1.Text == btnContent & button4.Text == btnContent &
                 button7.Text == btnContent)
               | (button1.Text == btnContent & button5.Text == btnContent &
                 button9.Text == btnContent)
               | (button2.Text == btnContent & button5.Text == btnContent &
                 button8.Text == btnContent)
               | (button3.Text == btnContent & button6.Text == btnContent &
                 button9.Text == btnContent)
               | (button4.Text == btnContent & button5.Text == btnContent &
                 button6.Text == btnContent)
               | (button7.Text == btnContent & button8.Text == btnContent &
                 button9.Text == btnContent)
               | (button3.Text == btnContent & button5.Text == btnContent &
                 button7.Text == btnContent))
            {
                if (btnContent == "O")
                {
                    MessageBox.Show("PLAYER NO. 1 WINS");
                }
                else if (btnContent == "X")
                {
                    MessageBox.Show("PLAYER NO. 2 WINS");
                }
                ClearGame();
            }
            else
            {
                foreach (Button btn in panel1.Controls)
                {
                    if (btn.Enabled == true)
                        return;
                }
                MessageBox.Show("GAME OVER NO ONE WINS");
                ClearGame();
            }
        }
       
        private void ClearGame()
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (Button btn in panel1.Controls)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
        }

    }
}
