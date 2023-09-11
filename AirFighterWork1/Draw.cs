using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static AirFighterWork1.Movement;

namespace AirFighterWork1
{
    public class Draw
    {
        public AirFighter? AirFighter { get; private set; }

        private int startPosX;

        private int startPosY = 0 + 315 / 5;

        private readonly int AirFighterWidth = 315/5*2;

        private readonly int AirFighterHeight = 640/5;

        Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
        internal DockStyle Dock;

        public bool Init(int Speed, double Weight, Color BodyColor, Color AddictionalColor, int width, int height)
        {
            if (width < AirFighterWidth || AirFighterHeight > height)
            {
                MessageBox.Show("Размер окна слишком маленький!");
                return false;
            }
            AirFighter = new AirFighter();
            AirFighter.init(Speed, Weight, BodyColor, AddictionalColor);
            return true;
        }

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y + 314 / 5 * 2;
        }


        public void movementForFighter(Movement movement, int maxX, int maxY)
        {
            if (AirFighter == null)
{
                return;
            }
            switch (movement)
            {
                case Movement.Left:
                    if (startPosX - AirFighter.step > 0)
                    {
                        startPosX -= (int)AirFighter.step;
                        break;
                    }
                    startPosX = 0;
                    break;
                case Movement.Up:
                    if (startPosY - AirFighter.step > 0)
                    {
                        startPosY -= (int)AirFighter.step;
                        break;
                    }
                    startPosY = 0 + 315 / 5;
                    break;
                case Movement.Right:
                    if (startPosX + 314 / 5 + AirFighter.step < maxX)
                    {
                        startPosX += (int)AirFighter.step;
                        break;

                    }
                    startPosX = maxX - 640 / 5;
                    break;
                case Movement.Down:
                    if (startPosY + 314 / 5 + AirFighter.step < maxY)
                    {
                        startPosY += (int)AirFighter.step;
                        break;
                    }
                    startPosY = maxY - 315 / 5;
                    break;
                case Movement.AddEngine:
                    if (AirFighter.additionalEngine < 6)
                    {
                        AirFighter.additionalEngine += 2;
                    }break;
                case Movement.RemoveEngine:
                    if(AirFighter.additionalEngine > 2)
                    {
                        AirFighter.additionalEngine -= 2;
                    } break;
                case Movement.wings:
                    if (AirFighter.additionalWings == true)
                    {
                        AirFighter.additionalWings = false;
                        break;
                    }
                    AirFighter.additionalWings = true;
                    break;
                case Movement.rocket:
                    if(AirFighter.rocket == true)
                    {
                        AirFighter.rocket = false;
                        break;
                    }
                    AirFighter.rocket = true;
                    break;
            }
        }

        public void DrawTransport(Graphics g)
        {
            if (AirFighter == null)
            {
                return;
            }

            Pen pen = new(Color.Black);
            Brush mainBrush = new SolidBrush(AirFighter.bodyColor);
            Brush secondBrush = new SolidBrush(AirFighter.addictionalColor);
            Brush rocketBrush = new SolidBrush(Color.Gray);

            List<int> x;
            List<int> y;

            if (AirFighter.rocket == true)
            {
                List<Point> rockets = new List<Point>();
                x = new List<int>() { 210, 170, 170, 210, 470, 515, 470, 210, 210, 170, 170, 210, 470, 515, 470, 210 };
                y = new List<int>() { 120, 140, 160, 180, 180, 148, 120, 120, -120, -140, -160, -180, -180, -148, -120, -120 };

                for (int i = 0; i < x.Count / 2; i++)
                {
                    rockets.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }
                g.FillPolygon(rocketBrush, rockets.ToArray());
                g.DrawPolygon(pen, rockets.ToArray());
                rockets.Clear();

                for (int i = x.Count / 2; i < x.Count; i++)
                {
                    rockets.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }
                g.FillPolygon(rocketBrush, rockets.ToArray());
                g.DrawPolygon(pen, rockets.ToArray());
                rockets.Clear();
            }

            List<Point> mainBody = new List<Point>();
            x = new List<int>() {0,0,30,73,230,293,209,275,408,560,640,560,408,275,209,293,230,73,30,0,0};
            y = new List<int>() { 0,90,90,35,54,54,314,314,54,54,0,-54,-54,-314,-314,-54,-54,-35,-90,-90,0 };


            //main body

            for (int i = 0; i < x.Count; i++)
            {
                mainBody.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
            }

            g.FillPolygon(mainBrush, mainBody.ToArray());
            g.DrawPolygon(pen, mainBody.ToArray());

            //window
            g.FillEllipse(secondBrush, startPosX + 220 / 5, startPosY - 5, 10, 10);
            g.FillEllipse(secondBrush, startPosX + 280 / 5, startPosY - 5, 10, 10);
            g.FillEllipse(secondBrush, startPosX + 340 / 5, startPosY - 5, 10, 10);
            g.FillEllipse(secondBrush, startPosX + 400 / 5, startPosY - 5, 10, 10);
            g.FillEllipse(secondBrush, startPosX + 460 / 5, startPosY - 5, 10, 10);

            //engines
            if (AirFighter.additionalEngine == 2)
            {
                List<Point> engine = new List<Point>();
                x = new List<int> { 383, 410, 410, 355, 383, 410, 410, 355 };
                y = new List<int> { 100, 100, 150, 150, -100, -100, -150, -150 };

                for (int i = 0; i < x.Count / 2; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

                for (int i = x.Count / 2; i < x.Count; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

            }

            if (AirFighter.additionalEngine == 4)
            {

                List<Point> engine = new List<Point>();
                x = new List<int> { 383, 410, 410, 355, 342, 375, 375, 320, 342, 375, 375, 320, 383, 410, 410, 355 };
                y = new List<int> { 100, 100, 150, 150, 175, 175, 222, 222, -175, -175, -222, -222, -100, -100, -150, -150 };

                for (int i = 0; i < x.Count / 4 ; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

                for(int i = x.Count / 4; i < x.Count / 2 ; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();


                for(int i = x.Count/2; i < x.Count - x.Count / 4; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));

                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

                for (int i = x.Count - x.Count / 4; i < x.Count; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();
            }

            if (AirFighter.additionalEngine == 6)
            {

                List<Point> engine = new List<Point>();
                x = new List<int> { 383, 410, 410, 355, 342, 375, 375, 320,310,335,335,295, 310, 335, 335, 295, 342, 375, 375, 320, 383, 410, 410, 355 };
                y = new List<int> { 100, 100, 150, 150, 175, 175, 222, 222,250,250,280,280, -250, -250, -280, -280, -175, -175, -222, -222, -100, -100, -150, -150 };

                for (int i = 0; i < x.Count / 6; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

                for (int i = x.Count / 6; i < x.Count / 6 * 2; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();


                for (int i = x.Count / 6 * 2; i < x.Count / 2; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));

                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

                for (int i = x.Count / 2; i < x.Count / 6 * 4; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

                for (int i = x.Count / 6 * 4; i < x.Count / 6 * 5; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();

                for (int i = x.Count / 6 * 5; i < x.Count; i++)
                {
                    engine.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }

                g.FillPolygon(secondBrush, engine.ToArray());
                g.DrawPolygon(pen, engine.ToArray());
                engine.Clear();
            }

            if (AirFighter.additionalWings == true)
            {
                List<Point> Wings = new List<Point>();
                x = new List<int>() { 150, 120, 180, 220, 150, 150, 120, 180, 220, 150 };
                y = new List<int>() { 43, 120, 120, 51, 43, -43, -120, -120, -51, -43 };

                for (int i = 0; i < x.Count / 2; i++)
                {
                    Wings.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }
                g.FillPolygon(secondBrush, Wings.ToArray());
                g.DrawPolygon(pen, Wings.ToArray());
                Wings.Clear();

                for (int i = x.Count / 2; i < x.Count; i++)
                {
                    Wings.Add(new Point(x[i] / 5 + startPosX, y[i] / 5 + startPosY));
                }
                g.FillPolygon(secondBrush, Wings.ToArray());
                g.DrawPolygon(pen, Wings.ToArray());
                Wings.Clear();
            }
        }
    }
}