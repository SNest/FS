namespace FlyingShapes.Logic
{
    using System;

    using FlyingShapes.Models;

    internal class ShapesKickedEventArgs : EventArgs
    {
        public ShapesKickedEventArgs(Shape shap1, Shape shape2)
        {
            Shape1 = shap1;
            Shape2 = shape2;
        }

        public Shape Shape1 { get; private set; }

        public Shape Shape2 { get; private set; }
    }
}