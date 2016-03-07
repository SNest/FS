namespace FlyingShapes.Models
{
    using System;
    using System.Drawing;
    using System.Runtime.Serialization;
    using System.Windows.Forms;

    [Serializable, DataContract]
    public class Circle : Shape
    {
        private readonly int halfOfWidth;

        public Circle()
        {
            halfOfWidth = Width / 2;
            XCoord = XCoord + halfOfWidth;
            YCoord = YCoord + halfOfWidth;
        }

        public override void Draw(Graphics graphics)
        {
            if (IsFilled)
            {
                graphics.FillEllipse(
                    new SolidBrush(Color), 
                    XCoord - halfOfWidth, 
                    YCoord - halfOfWidth, 
                    Width, 
                    Width);
            }
            else
            {
                graphics.DrawEllipse(
                    new Pen(Color, 3f), 
                    XCoord - halfOfWidth, 
                    YCoord - halfOfWidth, 
                    Width, 
                    Width);
            }
        }

        public override void Move(PictureBox pictureBox)
        {
            if (XCoord + halfOfWidth >= pictureBox.Width || XCoord <= 0 + halfOfWidth)
            {
                XSpeed = -XSpeed;
            }

            if (YCoord + halfOfWidth >= pictureBox.Height || YCoord <= 0 + halfOfWidth)
            {
                YSpeed = -YSpeed;
            }

            XCoord += XSpeed;
            YCoord += YSpeed;
        }
    }
}