using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace FlyingShapes.Models
{
    [Serializable, DataContract]
    public class Triangle : Shape
    {
        private Point[] points;

        public Triangle()
        {
            
        }

        public override void Draw(Graphics graphics)
        {
            points = new[]
            {
                new Point(XCoord + Width/2, YCoord),
                new Point(XCoord + Width, YCoord + Height),
                new Point(XCoord, YCoord + Height)
            };

            if (IsFilled)
            {
                graphics.FillPolygon(new SolidBrush(Color), points);
            }
            else
            {
                graphics.DrawPolygon(new Pen(Color, 3f), points);
            }
        }

        public override void Move(PictureBox pictureBox)
        {
           if (YCoord + Height >= pictureBox.Height || YCoord <= 0)
            {
                YSpeed = -YSpeed;
            }
            if (XCoord + Width >= pictureBox.Width || XCoord <= 0)
            {
                XSpeed = -XSpeed;
            }

            XCoord += XSpeed;
            YCoord += YSpeed;
        }
    }
}
