using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BowlingProject {

    public class Program {

        //below: an array of 10 items, 0-9
        // using the generic library and the data source List is better for this function because it doesnst have a hard limit
        //a dynamic array that grows and shrinks, inside the angled brackets we specify type
        //int[] scores = new int[10];
        private List<int> scores = new List<int>(); 

        //**Declare 10 integers**
        void Run() {
            Random rnd = new Random();
            // loop 10x each time through generate a number, put in integer random number which goes in the array 
            for (int idx = 0; idx < 10; idx++) {
                int number = rnd.Next(11);
                scores.Add(number); 
            }
            // for each iterates through an array or list
            foreach(int anInt in scores) { //loads array with 10 itmes
                Debug.WriteLine(anInt); //prints the array
                }


        }
        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
