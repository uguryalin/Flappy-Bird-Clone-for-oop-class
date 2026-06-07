using System;
using System.Windows.Forms;

namespace FlappyBirdClone
{
    public class Pipe
    {
        public PictureBox TopPipe { get; private set; }
        public PictureBox BottomPipe { get; private set; }
        private Random _random = new Random();

        public Pipe(PictureBox top, PictureBox bottom)
        {
            TopPipe = top;
            BottomPipe = bottom;
        }

        public void Move()
        {
            TopPipe.Left -= GameSettings.PipeSpeed;
            BottomPipe.Left -= GameSettings.PipeSpeed;

            if (TopPipe.Left < -100)
            {
                ResetPipes();
            }
        }

        public void ResetPipes()
        {
            int gap = 150; // Borular arası boşluk
            int randomY = _random.Next(50, 250);
            
            TopPipe.Left = GameSettings.PipeStartPos;
            BottomPipe.Left = GameSettings.PipeStartPos;

            TopPipe.Top = randomY - TopPipe.Height;
            BottomPipe.Top = randomY + gap;
        }
    }
}
