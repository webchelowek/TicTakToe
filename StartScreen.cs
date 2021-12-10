using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTakToe
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.Location = new Point(Width / 2 - tableLayoutPanel1.Width / 2, Height / 2 - tableLayoutPanel1.Height / 2 + 100);
            pictureBox1.Location = new Point(Width / 2 - pictureBox1.Width / 2, Height / 2 - 250);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
