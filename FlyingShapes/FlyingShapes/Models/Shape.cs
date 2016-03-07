namespace FlyingShapes.Models
{
    using System;
    using System.Drawing;
    using System.Runtime.Serialization;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    using FlyingShapes.Interfaces;

    [Serializable, DataContract, XmlInclude(typeof(Square)), XmlInclude(typeof(Circle)), XmlInclude(typeof(Triangle)), 
     KnownType(typeof(Square)), KnownType(typeof(Circle)), KnownType(typeof(Triangle))]
    public abstract class Shape : IMovable, IDrawable
    {
        private const int MaxSpeed = 50;

        private const int MinSpeed = 1;

        private readonly Random random = new Random();

        private readonly double xRatio;

        private readonly double yRatio;

        [NonSerialized]
        private SolidBrush brush;

        [NonSerialized]
        private Pen pen;

        protected Shape()
        {
            var size = random.Next(10, 100);
            Width += size;
            Height += size;
            XCoord = random.Next(100);
            YCoord = random.Next(100);

            Speed = random.Next(2, 10);
            xRatio = random.NextDouble();
            yRatio = 1 - xRatio;

            if (XSpeed >= 0)
            {
                XSpeed = (int)(xRatio * Speed);
            }
            else
            {
                XSpeed = -(int)(xRatio * Speed);
            }

            if (YSpeed >= 0)
            {
                YSpeed = (int)(yRatio * Speed);
            }
            else
            {
                YSpeed = -(int)(yRatio * Speed);
            }

            Color = GetRandomColor();
        }

        [DataMember, XmlIgnore]
        public Color Color { get; set; }

        [XmlElement("Color")]
        public int ColorAsArgb
        {
            get
            {
                return Color.ToArgb();
            }

            set
            {
                Color = Color.FromArgb(value);
            }
        }

        [DataMember]
        public int Height { get; set; }

        [DataMember]
        public bool IsFilled { get; set; }

        [DataMember]
        public int Speed { get; set; }

        [DataMember]
        public int Width { get; set; }

        [DataMember]
        public int XCoord { get; set; }

        [DataMember]
        public int XSpeed { get; set; }

        [DataMember]
        public int YCoord { get; set; }

        [DataMember]
        public int YSpeed { get; set; }

        protected SolidBrush Brush
        {
            get
            {
                return brush;
            }

            set
            {
                brush = value;
            }
        }

        protected Pen Pen
        {
            get
            {
                return pen;
            }

            set
            {
                pen = value;
            }
        }

        public void ChangeSpeed(int speedStep)
        {
            if (Speed + speedStep >= MinSpeed && Speed + speedStep <= MaxSpeed)
            {
                Speed += speedStep;

                if (XSpeed >= 0)
                {
                    XSpeed = (int)(xRatio * Speed);
                }
                else
                {
                    XSpeed = -(int)(xRatio * Speed);
                }

                if (YSpeed >= 0)
                {
                    YSpeed = (int)(yRatio * Speed);
                }
                else
                {
                    YSpeed = -(int)(yRatio * Speed);
                }
            }
        }

        public abstract void Draw(Graphics graphics);

        public Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }

        public System.Drawing.Rectangle GetShapeBoundAllowSpeed()
        {
            return new System.Drawing.Rectangle(XCoord + XSpeed, YCoord + YSpeed, Width, Height);
        }

        public System.Drawing.Rectangle GetShapeBounds()
        {
            return new System.Drawing.Rectangle(XCoord, YCoord, Width, Height);
        }

        public System.Drawing.Rectangle GetShapeBounds(int x)
        {
            return new System.Drawing.Rectangle(XCoord + x, YCoord + x, Width, Height);
        }

        public abstract void Move(PictureBox pictureBox);

        public void ReverseDirection()
        {
            Speed = -Speed;
        }

        public override string ToString()
        {
            return string.Format("Shape type: {0}; \nShape speed: {1};", GetType().Name, Speed);
        }

        void IDrawable.Test()
        {
        }

        void IMovable.Test()
        {
        }
    }
}