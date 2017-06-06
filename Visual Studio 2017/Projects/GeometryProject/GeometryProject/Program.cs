using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GeometryProject {
    class Program {

        void Run() {
            //instance of quad
            Quadrillateral q1 = new Quadrillateral();
            q1.SetSideLength(8, 7, 4, 5);
            int perimeter = q1.CalcPerimeter();
            Debug.WriteLine(perimeter.ToString());
        }
        
        void Run1() { 
            //instance of square
            Square s1 = new Square();
            s1.SetSquareSides(2);
        int perimeter = s1.SetSideLength();
            Debug.WriteLine(perimeter.ToString());
        }
        static void Main(string[] args) {
            (new Program()).Run(1);
        }
    }
}
