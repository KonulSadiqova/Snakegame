using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Panel snakeHead;
        private Panel food;

        private int directionX = 0;
        private int directionY = 0;
        private int score = 0;
        private Random random = new Random();
        private int stepSize = 20;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            btnUp.Click += new EventHandler(btnUp_Click);
            btnDown.Click += new EventHandler(btnDown_Click);
            btnLeft.Click += new EventHandler(btnLeft_Click);
            btnRight.Click += new EventHandler(btnRight_Click);
            btnExit.Click += new EventHandler(btnExit_Click);

            gameTimer.Tick += new EventHandler(gameTimer_Tick);

            StartNewGame();
        }

        private void StartNewGame()
        {
            score = 0;
            lblScore.Text = "Xal: " + score;

            pnlGameArea.Controls.Clear();

            snakeHead = new Panel();
            snakeHead.Size = new Size(stepSize, stepSize);
            snakeHead.BackColor = Color.Black;
            snakeHead.Location = new Point(100, 100);
            pnlGameArea.Controls.Add(snakeHead);

            food = new Panel();
            food.Size = new Size(stepSize, stepSize);
            food.BackColor = Color.Black;
            GenerateFoodLocation();
            pnlGameArea.Controls.Add(food);

            directionX = 0;
            directionY = 0;

            gameTimer.Interval = 150;
            gameTimer.Start();
        }

        private void GenerateFoodLocation()
        {
            int maxX = (pnlGameArea.Width / stepSize) - 1;
            int maxY = (pnlGameArea.Height / stepSize) - 1;

            int randomX = random.Next(0, maxX) * stepSize;
            int randomY = random.Next(0, maxY) * stepSize;

            food.Location = new Point(randomX, randomY);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (directionX != 0 || directionY != 0)
            {
                snakeHead.Left += directionX * stepSize;
                snakeHead.Top += directionY * stepSize;

                if (snakeHead.Left < 0 || snakeHead.Right > pnlGameArea.Width ||
                    snakeHead.Top < 0 || snakeHead.Bottom > pnlGameArea.Height)
                {
                    GameOver();
                    return;
                }

                if (snakeHead.Bounds.IntersectsWith(food.Bounds))
                {
                    score += 1;
                    lblScore.Text = "Xal: " + score;

                    snakeHead.Width += food.Width;
                    snakeHead.Height += food.Height;

                    GenerateFoodLocation();
                }
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            DialogResult result = MessageBox.Show("Oyun Bitti! Xalınız: " + score + "\nYenidən başlamaq istəyirsiniz?", "Oyun Sonu", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                StartNewGame();
            }
        }

        private void btnUp_Click(object sender, EventArgs e) { directionX = 0; directionY = -1; }
        private void btnDown_Click(object sender, EventArgs e) { directionX = 0; directionY = 1; }
        private void btnLeft_Click(object sender, EventArgs e) { directionX = -1; directionY = 0; }
        private void btnRight_Click(object sender, EventArgs e) { directionX = 1; directionY = 0; }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { directionX = 0; directionY = -1; }
            else if (e.KeyCode == Keys.Down) { directionX = 0; directionY = 1; }
            else if (e.KeyCode == Keys.Left) { directionX = -1; directionY = 0; }
            else if (e.KeyCode == Keys.Right) { directionX = 1; directionY = 0; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}