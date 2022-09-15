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
using System.Media;

namespace PlayGame
{
    public partial class PlayGame : Form
    {
        int num = 5;
        int num2 = 4;
        int num3 = 3;
        int num4 = 2;
        int num5 = 1;
        public PlayGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void strtButton_Click(object sender, EventArgs e)
        {
            backGround.BackColor = Color.Black;
            outputLabel.BackColor = Color.Black;
            outputLabel.Text = $"Game will start in: {num}";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = $"Game will start in: {num2}";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = $"Game will start in: {num3}";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = $"Game will start in: {num4}";
            Refresh();
            Thread.Sleep(1000);
            outputLabel.Text = $"Game will start in: {num5}";
            Refresh();
            Thread.Sleep(1000);
            backGround.BackColor = Color.DarkGreen;
            outputLabel.BackColor = Color.DarkGreen;
            outputLabel.Text = "GO!!!!!";

        }
        }
    }
