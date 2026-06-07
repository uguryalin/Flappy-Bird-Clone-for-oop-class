using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBirdClone
{
    public partial class Form1 : Form
    {
        private Bird _player = null!;
        private Pipe _pipes = null!;
        private int _score = 0;
        private bool _gameStarted = false;
        private bool _pipePassed = false;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            try
            {
                if (System.IO.File.Exists("pbGround.png"))
                {
                    this.BackgroundImage = Image.FromFile("pbGround.png");
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                
                if (System.IO.File.Exists("pbBird.png"))
                {
                    pbBird.Image = Image.FromFile("pbBird.png");
                }
                
                if (System.IO.File.Exists("pbPipeBottom.png"))
                {
                    pbPipeBottom.Image = Image.FromFile("pbPipeBottom.png");
                }
                
                if (System.IO.File.Exists("pbPipeTop.png"))
                {
                    Image topPipeImg = Image.FromFile("pbPipeTop.png");
                    topPipeImg.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    pbPipeTop.Image = topPipeImg;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Görseller yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _player = new Bird(pbBird);
            _pipes = new Pipe(pbPipeTop, pbPipeBottom);
            timerGame.Interval = GameSettings.GameInterval;

            ResetGame();
        }

        private void ResetGame()
        {
            _score = 0;
            _gameStarted = false;
            _pipePassed = false;
            lblScore.Text = "Score: 0";
            pbBird.Location = new Point(100, 220);
            if (_player != null)
            {
                _player.Velocity = GameSettings.Gravity;
            }
            if (_pipes != null)
            {
                _pipes.ResetPipes();
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            _player.Fall();
            _pipes.Move();

            lblScore.Text = $"Score: {_score}";

            // Boru geçildiğinde skor artır
            if (pbPipeTop.Left + pbPipeTop.Width < pbBird.Left)
            {
                if (!_pipePassed)
                {
                    _score++;
                    _pipePassed = true;
                }
            }
            else if (pbPipeTop.Left > pbBird.Left)
            {
                _pipePassed = false;
            }

            // Çarpışma Kontrolü
            if (_player.CheckCollision(pbPipeTop) || 
                _player.CheckCollision(pbPipeBottom) || 
                _player.CheckCollision(pbGround) || 
                _player.Control.Top < 0)
            {
                GameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!_gameStarted)
                {
                    _gameStarted = true;
                    timerGame.Start();
                }
                _player.Jump();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) _player.ApplyGravity();
        }

        private void GameOver()
        {
            timerGame.Stop();
            MessageBox.Show($"Oyun Bitti! Skorunuz: {_score}", "Oyun Bitti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetGame();
        }
    }
}

