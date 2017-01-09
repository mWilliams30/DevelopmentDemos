using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    /// <summary>
    /// The composite pattern describes that a group of objects is to be treated in the same way as a single instance of an object(the composite).
    /// 
    /// A composite is an object designed as a composition of one-or-more similar objects, all exhibiting similar functionality. This is known as a "has-a" relationship between objects.
    /// The key concept is that you can manipulate a single instadrdd sdafjipsacc nce of the object just as you would manipulate a group of them
    /// 
    /// If we find that they are using multiple objects in the same way, and often have nearly identical code to handle each of them, then composite is a good choice
    /// </summary>
    public class ShapeComposite : IShape
    {
        private readonly ArrayList _shapesList;

        public ShapeComposite()
        {
            _shapesList = new ArrayList();
        }

        public void Add(IShape shape)
        {
            _shapesList.Add(shape);
        }

        public void AddRange(IShape[] shapes)
        {
            _shapesList.AddRange(shapes);
        }

        public void Draw()
        {
            foreach (IShape shape in _shapesList)
            {
                shape.Draw();
            }
        }

    }
}
