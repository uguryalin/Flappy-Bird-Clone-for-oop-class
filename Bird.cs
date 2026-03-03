using System.Windows.Forms;

namespace FlappyBirdClone
{
    public class Bird
    {
        public PictureBox Control { get; private set; }
        public int Velocity { get; set; }

        public Bird(PictureBox pictureBox)
        {
            Control = pictureBox;
            Velocity = GameSettings.Gravity;
        }

        public void Fall()
        {
            Control.Top += Velocity;
        }

        public void Jump()
        {
            Velocity = GameSettings.JumpStrength;
        }

        public void ApplyGravity()
        {
            Velocity = GameSettings.Gravity;
        }

        public bool CheckCollision(Control obstacle)
        {
            return Control.Bounds.IntersectsWith(obstacle.Bounds);
        }
    }
}
