using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Form1 : Form
    {
        private static Snake snake;
        private static Graphics g;
        private static Timer timer;
        private int score;
        private int level = 1;
        Random r;
        int x, y; //apple cordinates
        public Form1()
        {
            InitializeComponent();
            snake = new Snake();
            timer = new Timer();
            r = new Random();
            g = this.CreateGraphics();
            score = 0;
            timer.Tick += Timer_Tick;

            unhide_level_selection(false);
            setUI();
        }

        private void setUI()
        {
            this.scorepanel.Visible = false;
            this.playagainButton.Visible = false;
            this.select_level_label.Visible = true;
            unhide_level_selection(true);
            this.startbutton.Visible = true;
        }

        private void unhide_level_selection(bool val)
        {
            this.radioButton1.Visible = val;
            this.radioButton2.Visible = val;
            this.radioButton3.Visible = val;
            this.radioButton4.Visible = val;
            this.select_level_label.Visible = val;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            snake.Move();
            if (snake.lost)
            {
                MessageBox.Show("You lost!");
                this.playagainButton.Visible = true;
                this.scorepanel.Visible = true;
                this.score_label.Text = score.ToString();
                unhide_level_selection(true);
                g.Clear(Color.White);

                return;
            }
            ResizeRedraw();
            if (snake.check_if_eaten(x, y))
            {
                snake.ate();
                x = generate_random(x); //apple cordinates
                y = generate_random(y); //apple cordinates
                score++;
            }
            timer.Start();
        }

        private void ResetFunction()
        {
            this.playagainButton.Visible = false;
            this.scorepanel.Visible = false;
            unhide_level_selection(false);
            snake.lost = false;
            ResizeRedraw();
            timer.Interval = 100 - 20*level;
            score = 0;
            x = generate_random(x); //apple cordinates
            y = generate_random(y); //apple cordinates
            snake.reset();
            this.Focus();
            timer.Start();

        }

        private int generate_random(int x)
        {
            x = r.Next(10, 440);
            x -= x % 10;
            return x;
        }

        private void ResizeRedraw()
        {
            g.Clear(Color.White);
            
            snake.Draw(g);
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(0,0,450,450));
            g.FillRectangle(new SolidBrush(Color.Red), new Rectangle(x, y, 10, 10));
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Down:
                    snake.changeDirection("DOWN");
                    break;
                case Keys.Right:
                    snake.changeDirection("RIGHT");
                    break;
                case Keys.Up:
                    snake.changeDirection("UP");
                    break;
                case Keys.Left:
                    snake.changeDirection("LEFT");
                    break;
            }
            if (this.playagainButton.Visible == true)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    this.playagainButton.PerformClick();
                }
            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            level = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            level = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            level = 4;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            this.startbutton.Visible = false;
            ResetFunction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFunction();
        }


    }
}
