using System.Windows.Forms;

namespace AirFighterWork1
{
    public partial class Title1 : Form
    {

        public Draw? DrawFighter;


        public Title1()
        {
            InitializeComponent();
            Text = "Air Fighter v1.0";
            DrawFighter = new Draw();
            DrawFighter.Init(400, 200, Color.Gray, Color.Blue, pictureBox1.Width, pictureBox1.Height);
            Draw();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Draw()
        {
            if (DrawFighter == null) { return; }

            Bitmap bmp = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            Graphics g = Graphics.FromImage(bmp);

            DrawFighter.DrawTransport(g);
            pictureBox1.Image = bmp;
        }


        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (DrawFighter == null)
            {
                return;
            }
            string name = ((Button)sender)?.Name ?? string.Empty;
            switch (name)
            {
                case "buttonUp":
                    DrawFighter.movementForFighter(Movement.Up, pictureBox1.Height, pictureBox1.Height);
                    break;
                case "buttonDown":
                    DrawFighter.movementForFighter(Movement.Down, pictureBox1.Height, pictureBox1.Height);
                    break;
                case "buttonLeft":
                    DrawFighter.movementForFighter(Movement.Left, pictureBox1.Height, pictureBox1.Height);
                    break;
                case "buttonRight":
                    DrawFighter.movementForFighter(Movement.Right, pictureBox1.Height, pictureBox1.Height);
                    break;
                case "removeEngine":
                    DrawFighter.movementForFighter(Movement.RemoveEngine, pictureBox1.Height, pictureBox1.Height);
                    break;
                case "addEngine":
                    DrawFighter.movementForFighter(Movement.AddEngine, pictureBox1.Height, pictureBox1.Height);
                    break;
                case "wings":
                    DrawFighter.movementForFighter(Movement.wings, pictureBox1.Height, pictureBox1.Height);
                    break;
                case "rocket":
                    DrawFighter.movementForFighter(Movement.rocket, pictureBox1.Height, pictureBox1.Height);
                    break;
            }
            Draw();
        }
    }
}