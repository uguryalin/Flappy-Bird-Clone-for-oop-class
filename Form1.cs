using System;
using System.Windows.Forms;

namespace FlappyBirdClone
{
    public partial class Form1 : Form
    {
        private Bird _player;
        private Pipe _pipes;
        private int _score = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            _player = new Bird(pbBird);
            _pipes = new Pipe(pbPipeTop, pbPipeBottom);
            timerGame.Interval = GameSettings.GameInterval;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            _player.Fall();
            _pipes.Move();

            lblScore.Text = $"Score: {_score}";

            // Boru geçildiğinde skor artır (Basit mantık: boru belirli bir noktaya gelince)
            if (pbPipeTop.Left == 100) _score++;

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
            if (e.KeyCode == Keys.Space) _player.Jump();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) _player.ApplyGravity();
        }

        private void GameOver()
        {
            timerGame.Stop();
            MessageBox.Show($"Oyun Bitti! Skorunuz: {_score}");
            Application.Restart();
        }
    }
}
