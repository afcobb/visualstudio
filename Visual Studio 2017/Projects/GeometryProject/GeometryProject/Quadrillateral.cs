using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryProject {

    public class Quadrillateral {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public void SetSideLength(int a, int b, int c, int d) {
            Side1 = a;
            Side2 = b;
            Side3 = c;
            Side4 = d;
        }

        //calculation of perimeter
        public int CalcPerimeter() {
            return Side1 + Side2 + Side3 + Side4;
        }
    }
}
