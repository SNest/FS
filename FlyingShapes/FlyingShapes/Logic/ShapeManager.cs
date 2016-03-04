using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FlyingShapes.Models;
using Rectangle = System.Drawing.Rectangle;

namespace FlyingShapes.Logic
{
    public class ShapeManager
    {
        private Rectangle shapeRectangle1;
        private Rectangle shapeRectangle2;

        public ShapeManager()
        {
            ShapeList = new List<Shape>();
        }

        public List<Shape> ShapeList { get; set; }

        public void AddShape(Shape shape)
        {
            ShapeList.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            ShapeList.Remove(shape);
        }

        public void DrawAllShapes(Graphics graphics)
        {
            foreach (var shape in ShapeList)
            {
                shape.Draw(graphics);
            }
        }

        public void MoveAllShapes(PictureBox pictureBox)
        {
            foreach (var shape1 in ShapeList)
            {
                shapeRectangle1 = new Rectangle(
                    shape1.XCoord, shape1.YCoord, shape1.Width, shape1.Height);

                foreach (var shape2 in ShapeList)
                {
                    shapeRectangle2 = new Rectangle(
                        shape2.XCoord, shape2.YCoord, shape2.Width, shape2.Height);

                    if (!ReferenceEquals(shape1, shape2) && IsIntersected())
                    {
                        shape1.ReverseDirection();
                        shape2.ReverseDirection();
                    }
                }

                shape1.Move(pictureBox);
            }
        }

        public bool IsIntersected()
        {
            return shapeRectangle1.IntersectsWith(shapeRectangle2);
        }

        public void ChangeAllShapesSpeed(int speedStep)
        {
            foreach (var shape in ShapeList)
            {
                shape.ChangeSpeed(speedStep);
            }
        }

        public void RemoveAllShapes()
        {
            ShapeList.Clear();
        }

        public void RemoveAllShapesByType(Shape shape)
        {
            ShapeList.RemoveAll(f => f.GetType().Equals(shape.GetType()));
        }

        public string GetAllShapesInfo()
        {
            var allfigures = new StringBuilder();
            foreach (var shape in ShapeList)
            {
                allfigures.Append(shape + ", ");
            }

            return allfigures.ToString();
        }
    }
}