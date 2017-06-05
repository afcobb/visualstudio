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
        }
        static void Tutorial() {
            Console.WriteLine("Hello, World");
            int counter = 0; // create an int and set to zero
            string message = "This is a message";
            double nbrWithDecimal = 1.23; //double is for numbers 
            bool trueOrFalse = false; //bool is for boolean, can only have values of t or f (always lowercase)
            DateTime today = DateTime.Now;
            int[] grades = new int[][100, 98, 95]; //after the = sign we need a "new _____" to create a new instance of an array of ints
            int highScore = grades[0];
            string[] messages = { "hi", "hello", "how are you" };
            if (trueOrFalse == false) { 
                //do this if true

                else { //do this if false

                }
                //while statement 
                while (trueOrFalse == false)
                {

                }
                //do while
                do
                {
                    //do this at least once and while true
                } while (trueOrFalse == false);
                //for statement
                for (int idx = 0; idx < 10; idx++)
                {

                }
                //for each statement
                foreach (int i in { 1, 2, 3}) 
                //do this for i as 1, 2, 3 
            }

            object obj = 1; // base type that everything derives from 
            obj.ToString() //takes numeric representation of 1 and converts it into a string
                string[] names = new string[] { "Alex" }

                struct
            MyFirstMethod(); //this refers back to the first method aftrer the main method completes
        }
}
