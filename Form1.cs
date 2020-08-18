using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fortuneTeller
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer theme = new System.Media.SoundPlayer(@"0731.wav");
        public Form1()
        {
            InitializeComponent();

            theme.Play();
        }

        private void btnTruth_Click(object sender, EventArgs e)
        {
            
            Random rand = new Random();
            var random = rand.Next(1, 15);
            if (random <= 1)
            {
                textBox1.Text = "No chance in hell!!!";
            }
            else if (random <= 2)
            {
                textBox1.Text = "Very likely.";
            }
            else if (random <= 3)
            {
                textBox1.Text = "You can only hope.";
            }
            else if (random <= 4)
            {
                textBox1.Text = "Looks like it.";
            }
            else if (random <= 5)
            {
                textBox1.Text = "No chance";
            }
            else if (random <= 6)
            {
                textBox1.Text = "Very unlikely";
            }
            else if (random <= 7)
            {
                textBox1.Text = "Yes Baby .";
            }
            else if (random <= 8)
            {
                textBox1.Text = "Offcourse...";
            }
            else if (random <= 9)
            {
                textBox1.Text = "Sarcastic Yes!!";
            }
            else if (random <= 10)
            {
                textBox1.Text = "Difficult to say...you probably know the answer already...";
            }
            else if (random <= 11)
            {
                textBox1.Text = "Better believe it";
            }
            else if (random <= 12)
            {
                textBox1.Text = "Your mama said so...";
            }
            else if (random <= 13)
            {
                textBox1.Text = "Well... maybe";
            }
            else
            {
                textBox1.Text = "Glitch in the Matrix try again.";
                {
                    return;
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.MaxLength = 100;
            textBox1.Text = textBox1.Text;
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }
    }
}
