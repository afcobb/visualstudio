using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppProject
{
    class Program {
        static void MyFirstMethod() {
            Console.WriteLine("Main is nearly finished :p");
            Console.ReadKey();
        }
        static void Main(string[] args) {
            Console.WriteLine("Hello, World"); 
            int counter = 0; // create an int and set to zero
            string message = "This is a message";
            double nbrWithDecimal = 1.23; //double is for numbers 
            bool trueOrFalse = false; //bool is for boolean, can only have values of t or f (always lowercase)
            DateTime today = DateTime.Now;
            int[] grades = new int[] [100, 98, 95]; //after the = sign we need a "new _____" to create a new instance of an array of ints
            int highSchore = grades[0];
            string[] messages = { "hi", "hello", "how are you" };
            MyFirstMethod(); //this refers back to the first method aftrer the main method completes
        }
    }
}
