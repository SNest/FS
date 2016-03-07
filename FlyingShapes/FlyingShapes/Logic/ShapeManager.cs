namespace FlyingShapes.Logic
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using FlyingShapes.Models;

    public class ShapeManager
    {
        public ShapeManager()
        {
            ShapeList = new List<Shape>();
        }

        public List<Shape> ShapeList { get; set; }

        public void AddShape(Shape shape)
        {
            ShapeList.Add(shape);
        }

        public void ChangeAllShapesSpeed(int speedStep)
        {
            foreach (var shape in ShapeList)
            {
                shape.ChangeSpeed(speedStep);
            }
        }

        public void DrawAllShapes(Graphics graphics)
        {
            foreach (var shape in ShapeList)
            {
                shape.Draw(graphics);
            }
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

        public Shape GetShape(string type, int number)
        {
            var result =
                ShapeList.Where(shape => shape.GetType().Name == type.Substring(0, type.Length - 1))
                    .ToList()
                    .ElementAt(number);
            return result;
        }

        public void MoveAllShapes(PictureBox pictureBox)
        {
            foreach (var shape1 in ShapeList)
            {
                foreach (var shape2 in ShapeList)
                {
                    var isEqual = ReferenceEquals(shape1, shape2);
                    var isIntersects = shape1.GetShapeBounds().IntersectsWith(shape2.GetShapeBounds());
                    var isIntersectsAllowSpeed =
                        shape1.GetShapeBoundAllowSpeed().IntersectsWith(shape2.GetShapeBoundAllowSpeed());

                    if (!isEqual && isIntersectsAllowSpeed && !isIntersects)
                    {
                        break;
                    }

                    shape1.ReverseDirection();
                    shape2.ReverseDirection();
                }

                shape1.Move(pictureBox);
            }
        }

        public void RemoveAllShapes()
        {
            ShapeList.Clear();
        }

        public void RemoveShapesByType(string type)
        {
            ShapeList.Where(shape => shape.GetType().Name == type.Substring(0, type.Length - 1))
                .ToList()
                .ForEach(innerShape => ShapeList.Remove(innerShape));
        }

        public void RemoveShape(Shape shape)
        {
            ShapeList.Remove(shape);
        }
    }
}