using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesOOP
    {
    internal class Quad
        {
        public int L1 { get; set; } = 0;
        public int L2 { get; set; } = 0;
        public int L3 { get; set; } = 0;
        public int L4 { get; set; } = 0;

        public int Perimiter()
            {
            return L1 + L2 + L3 + L4;
            }

        public Quad(int l1, int l2, int l3, int l4)
            {
            L1 = l1;
            L2 = l2;
            L3 = l3;
            L4 = l4;
            }
        public Quad() { }

        }
    }
