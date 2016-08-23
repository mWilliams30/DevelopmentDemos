using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ShapeFactory : IShapeFactory
    {
        List<IShape> _Shapes;

        public ShapeFactory()
        {
            _Shapes = new List<IShape>();
            _Shapes.Add(new Circle());
            _Shapes.Add(new Triangle());
        }

        public IShape CreateShape(string shapeName)
        {
            var shape = _Shapes.FirstOrDefault(m => m.Name == shapeName);
            if (shape == null)
                throw new ApplicationException($"{shapeName} cannot be created");
            return shape;            
        }
    }
}
