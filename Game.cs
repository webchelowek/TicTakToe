using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTakToe
{
    public partial class Game : Form
    {

        private int turn = 0;
        private int[,] tictac = new int [3,3];

        public Game()
        {
            InitializeComponent();
            tableLayoutPanel1.Location = new Point(Width/2 - tableLayoutPanel1.Width/2, Height / 2 - tableLayoutPanel1.Height/2);
            label1.Location = new Point(Width/2 - 125, 90);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            StartScreen start = new StartScreen();
            start.Show();
            Close();

        }

        private void win() 
        {
            Form1 win = new Form1();
            win.Show();
        }

        private void winnerCheck(int[,] arr)
        {
            int x = 0, y = 0, t = 1;
            int checker1 = arr[x,0];
            int checker2 = arr[x,1];
            int checker3 = arr[x,2];
            while(t<9)
            {

                if (checker1 != 0 && checker1 == checker2 && checker2 == checker3)
                {                 
                    label1.Text = checker1 == 1 ? "Победили крестики" : "Победили нолики";
                    win();
                    break;
                }
                else
                {
                    if(x < 2)
                    {
                        x++;
                        checker1 = arr[x, 0];
                        checker2 = arr[x, 1];
                        checker3 = arr[x, 2]; 
                    }
                    else if(y<3)
                    {
                        checker1 = arr[0, y];
                        checker2 = arr[1, y];
                        checker3 = arr[2, y];
                        y++;
                    }
                    if (arr[1,1] != 0 && ((arr[0, 0] == arr[1, 1] && arr[1, 1] == arr[2, 2]) ||
                                         (arr[2, 0] == arr[1, 1] && arr[1, 1] == arr[0, 2])))
                    {

                        label1.Text = arr[1,1] == 1 ? "Победили крестики" : "Победили нолики";
                        win();
                        break;
                    }

                }
                t++;
            }
            if (turn == 9) label1.Text = "Ничья";
            
        }

        private void stateChanger(Button btn, int x, int y)
        {
            if(turn%2 == 0)
            {
                btn.BackgroundImage = Properties.Resources.X;
                tictac[x, y] = 1;
            } 
            else
            {
                btn.BackgroundImage = Properties.Resources.O;
                tictac[x, y] = 2;
            }
            turn++;
            btn.Enabled = false;
            winnerCheck(tictac);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 0, 0); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 1, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 2, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 0, 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 1, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 2, 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 0 , 2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 1, 2);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            stateChanger(btn, 2, 2);
        }
    }
}
