using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopShapeDemo
{
    public class triangle : Regular2DShape
    {
        public triangle(double length) : base(length)
        {
        }

        public override double Area()
        {
            return ((Math.Sqrt(3) / 4 ) * Math.Pow(_length, 2));
        }
    }
}
