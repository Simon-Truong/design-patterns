using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightDesignPattern
{
    public class ShapeFatory : IFactory
    {
        private Dictionary<string, IShape> _shapes;
        public ShapeFatory()
        {
            _shapes = new Dictionary<string, IShape>();
        }
        public int GetCount()
        {
            return _shapes.Count;
        }

        public IShape GetShape(string shape)
        {
            if (_shapes.TryGetValue(shape, out IShape existingShape))
            {
                return existingShape;
            }
            else
            {
                switch (shape)
                {
                    case "square":
                        IShape newSquare = new Square();
                        _shapes["square"] = newSquare;
                        return newSquare;
                    case "rectangle":
                        IShape newRectangle = new Rectangle();
                        _shapes["rectangle"] = newRectangle;
                        return newRectangle;
                    default:
                        return new NullObject();
                }
            }
        }
    }
}
