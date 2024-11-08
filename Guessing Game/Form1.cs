using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        int num;
        int rando;
        int count;
        int distance;

        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rando = randGen.Next(1, 101);
            count = 0;
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            count++;
            num = Convert.ToInt32(numInput.Text);
            distance = rando - num;
            int hint = Math.Abs(distance);   

            if (num == rando)
            {
                numOutput.Text = "You Win!";
                numOutput.Text += $"\nIt took you {count} times";
                count = 0;
            }
            else if (hint <= 4)
            {
                numOutput.Text = "Boiling!";
            }
            else if (hint <= 10)
            {
                numOutput.Text = "Hot!";
            }
            else if (hint <= 10)
            {
                numOutput.Text = "Hot!";
            }
            else if (hint <= 15)
            {
                numOutput.Text = "Warm!";
            }
            else if (hint <= 25)
            {
                numOutput.Text = "Cool!";
            }
            else if (hint < 50)
            {
                numOutput.Text = "Cold!";
            }
            else if (hint >= 50)
            {
                    numOutput.Text = "Freezing!";
            }

            if (num > rando)
            {
                numOutput.Text += "\nToo High!";
            }

            if (num < rando)
            {
                numOutput.Text += "\nToo Low!";
            }

        }
    }
}
