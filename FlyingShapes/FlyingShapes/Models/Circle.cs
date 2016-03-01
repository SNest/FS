using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace FlyingShapes.Models
{
    [Serializable, DataContract]
    public class Circle : Shape
    {
        public Circle()
        {
            XCoord = XCoord + Width / 2;
            YCoord = YCoord + Width / 2;
        }

        public override void Draw(Graphics graphics)
        {
            if (IsFilled)
            {
                graphics.FillEllipse(new SolidBrush(Color), XCoord - Width / 2, YCoord - Width / 2, Width, Width);
            }
            else
            {
                graphics.DrawEllipse(new Pen(Color, 3f), XCoord - Width / 2, YCoord - Width / 2, Width, Width);
            }
        }

        public override void Move(PictureBox pictureBox)
        {
            if (XCoord + Width / 2 >= pictureBox.Width || XCoord <= 0 + Width / 2)
            {
                XSpeed = -XSpeed;
            }
            if (YCoord + Width / 2 >= pictureBox.Height || YCoord <= 0 + Width / 2)
            {
                YSpeed = -YSpeed;
            }

            XCoord += XSpeed;
            YCoord += YSpeed;
        }
    }
}