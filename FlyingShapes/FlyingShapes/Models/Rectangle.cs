using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace FlyingShapes.Models
{
    [Serializable, DataContract]
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            
        }

        public override void Draw(Graphics graphics)
        {
            if (IsFilled)
            {
                graphics.FillRectangle(new SolidBrush(Color), XCoord, YCoord, Width, Height);
            }
            else
            {
                graphics.DrawRectangle(new Pen(Color, 3f), XCoord, YCoord, Width, Height);
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
