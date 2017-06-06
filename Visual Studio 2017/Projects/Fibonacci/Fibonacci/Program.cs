using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Fibonacci {
    class Program {
        //random number generator
        void Run2() {
            Random random = new Random();
            for (int idx = 0; idx < 10; idx++) {
                int aRandomNumber = random.Next(1, 11); //between 1 and 11, specifying the degree of randomness
                Debug.WriteLine(aRandomNumber); //debug writeline writes to the output window
            }
        }
        //fib 
        void Run1() {
            int i = 1; //defining the integers
            int j = 2;
            while(true) { //if the if statement is true, this...
                var k = i + j;
                i = j;
                j = k;
            if (i > 19000 && j > 19000) { // looping mechanism
                    Console.WriteLine(i.ToString() + " and " + j.ToString()); //converting number to string
                    Console.ReadKey();
                    break; // get out of the loop
                }
            }
        }
        static void Main(string[] args) {
            (new Program()).Run2(); //this lets us specify which module/method we're using
        }
    }
}
