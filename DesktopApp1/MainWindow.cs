using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        NewHighscore highscores;
        Stream saves;
        private String gameSavePath;
        private static Snake snake;
        private static Graphics g;
        private static Timer timer;
        private int score;
        private int level = 1;
        Random r;
        int x, y; //apple cordinates
        public Form1()
        {
            highscores = new NewHighscore(this);
            CheckforSavedGame();
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

        public void ReStartAfterHighscores()
        {
            nickname.Text = highscores.getNickname();
            highscore.Text = score.ToString();
            saveNewHighscore();
            highscoresHide(false);
        }

        private void saveNewHighscore()
        {
            string player = nickname.Text.ToString() + ';' + highscore.Text.ToString();
            File.WriteAllText(gameSavePath,player);
        }

        private void CheckforSavedGame()
        {
            gameSavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/ArisVonGames";
            if (!Directory.Exists(gameSavePath))
            {
                Directory.CreateDirectory(gameSavePath);
            }
            gameSavePath += "/SnakeSaves.txt";
            if (!File.Exists(gameSavePath))
            {
                var tmp = File.Create(gameSavePath);
                tmp.Close();
            }

        }

        private void setUI()
        {
            this.scorepanel.Visible = false;
            this.playagainButton.Visible = false;
            this.select_level_label.Visible = true;
            unhide_level_selection(true);
            highscoresHide(true);
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
        private void highscoresHide(bool val)
        {
            this.nickname.Visible = !val;
            this.highscore.Visible = !val;
            this.labelHighscore.Visible = !val;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            snake.Move();
            if (snake.lost)
            {
                MessageBox.Show("You lost!");
                CheckForNewHighScore();

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

        private void CheckForNewHighScore()
        {
            string scores;
            scores = File.ReadAllText(gameSavePath); //find previous high score
            if (String.IsNullOrEmpty(scores)) //no previous high scores
            {
                MessageBox.Show("You have a new high score!!!");
                highscores.Show();
            }
            else // if previous high score exists
            {
                string[] champion = scores.Split(';');
                if (int.Parse(champion[1]) < score)
                {
                    MessageBox.Show("You have a new high score!!!");
                    highscores.Show();
                }
                else
                {
                    this.nickname.Text = champion[0];
                    this.highscore.Text = champion[1];
                    highscoresHide(false);
                }
            }
            

        }

        private void ResetFunction()
        {
            this.playagainButton.Visible = false;
            this.scorepanel.Visible = false;
            unhide_level_selection(false);
            highscoresHide(true);
            snake.lost = false;
            ResizeRedraw();
            timer.Interval = 100 - 20*level;
            score = 0;
            x = generate_random(x); //apple cordinates
            y = generate_random(y); //apple cordinates
            snake.reset();
            this.Focus();
            g.Clear(Color.White);
            //redraw border line after g.clear()
            g.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(0, 0, 450, 450));
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
            // clear inside area, where the snake is
            g.FillRectangle(new SolidBrush(Color.White), new Rectangle(1, 1, 449, 449)); 
            //redraw new snake afte move
            snake.Draw(g);
            //redraw apple
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (highscores.Visible)
            {
                highscores.Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFunction();
        }


    }
}
