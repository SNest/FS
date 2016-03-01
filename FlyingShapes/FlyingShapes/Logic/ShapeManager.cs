using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FlyingShapes.Models;

namespace FlyingShapes.Logic
{
    public class ShapeManager
    {
        public List<Shape> ShapeList { get; set; }

        public ShapeManager()
        {
            ShapeList = new List<Shape>();
        }

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
            foreach (var shape in ShapeList)
            {
                shape.Move(pictureBox);
            }
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
