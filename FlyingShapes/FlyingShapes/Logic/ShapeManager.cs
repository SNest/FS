﻿namespace FlyingShapes.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using FlyingShapes.Models;

    public class ShapeManager
    {
        private readonly Random random = new Random();

        public ShapeManager()
        {
            ShapeList = new List<Shape>();
        }

        public List<Shape> ShapeList { get; set; }

        public void AddShape(Shape shape, PictureBox pictureBox)
        {
            SetRandomPosition(shape, pictureBox);

            foreach (var tampShape in ShapeList)
            {
                var isEqual = ReferenceEquals(shape, tampShape);
                var isIntersects = tampShape.GetShapeBounds().IntersectsWith(shape.GetShapeBounds());

                if (!isEqual && isIntersects)
                {
                    SetRandomPosition(shape, pictureBox);
                }
            }

            ShapeList.Add(shape);
        }

        public void AddKickEvent()
        { 
            ShapeList.ForEach(AddKickEvent);
        }

        public void AddKickEvent(Shape shape)
        {
            shape.ShapesKicked += ShapeBeep;
        }

        public void AddKickEvent(List<Shape> shapes)
        {
            shapes.ForEach(shape => shape.ShapesKicked += ShapeBeep);
        }

        public void ChangeShapesSpeed(int speedStep)
        {
            foreach (var shape in ShapeList)
            {
                shape.ChangeSpeed(speedStep);
            }
        }

        public void DrawShapes(Graphics graphics)
        {
            foreach (var shape in ShapeList)
            {
                shape.Draw(graphics);
            }
        }

        public void FillShape(Shape shape)
        {
            ShapeList.Find(s => s.Equals(shape)).IsFilled = true;
        }

        public void FillShapes()
        {
            ShapeList.ForEach(shape => shape.IsFilled = true);
        }

        public void FillShapes(string type)
        {
            GetShapes(type).ForEach(shape => shape.IsFilled = true);
        }

        public Shape GetShape(string type, int number)
        {
            var result =
                ShapeList.Where(shape => shape.GetType().Name == type.Substring(0, type.Length - 1))
                    .ToList()
                    .ElementAt(number);
            return result;
        }

        public List<Shape> GetShapes(string type)
        {
            var result = ShapeList.Where(shape => shape.GetType().Name == type.Substring(0, type.Length - 1)).ToList();
            return result;
        }

        public string GetShapesInfo()
        {
            var allfigures = new StringBuilder();
            foreach (var shape in ShapeList)
            {
                allfigures.Append(shape + ", ");
            }

            return allfigures.ToString();
        }

        public void MoveShapes(object obj)
        {
            var pictureBox = (PictureBox)obj;

            foreach (var shape1 in ShapeList)
            {
                foreach (var shape2 in ShapeList)
                {
                    var isEqual = ReferenceEquals(shape1, shape2);
                    var isIntersects = shape1.IntersectsWith(shape2);

                    if (!isEqual && isIntersects)
                    {
                        shape1.ReverseDirection();
                        shape1.Move(pictureBox);
                        break;
                    }
                }

                shape1.Move(pictureBox);
            }
        }

        public void RemoveShape(Shape shape)
        {
            ShapeList.Remove(shape);
        }

        public void RemoveShapeKickEvent(Shape shape)
        {
            shape.ShapesKicked -= ShapeBeep;
        }

        public void RemoveShapes()
        {
            ShapeList.Clear();
        }

        public void RemoveShapes(string type)
        {
            ShapeList.Where(shape => shape.GetType().Name == type.Substring(0, type.Length - 1))
                .ToList()
                .ForEach(innerShape => ShapeList.Remove(innerShape));
        }

        public void UnfillShape(Shape shape)
        {
            ShapeList.Find(s => s.Equals(shape)).IsFilled = false;
        }

        public void UnfillShapes()
        {
            ShapeList.ForEach(shape => shape.IsFilled = false);
        }

        public void UnfillShapes(string type)
        {
            GetShapes(type).ForEach(shape => shape.IsFilled = false);
        }

        private void SetRandomPosition(Shape shape, Control pictureBox)
        {
            shape.XCoord = random.Next(10, pictureBox.Width - (shape.Width + 10));
            shape.YCoord = random.Next(10, pictureBox.Height - (shape.Height + 10));
        }

        private void ShapeBeep(object sender, ShapesKickedEventArgs e)
        {
            e.Shape1.Beep();
        }
    }
}