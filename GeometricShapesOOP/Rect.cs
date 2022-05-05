using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesOOP
    {
    internal class Rect : Quad
        {
        public int Area()
            {
            return L1 * L2;
            }
        public Rect(int Longside, int Shortside) : base(Longside, Shortside, Longside, Shortside)
            { 
            
            }
        public Rect() { }
        }
    }
