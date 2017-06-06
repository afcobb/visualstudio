using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject1 {
    class Program {
        // changes way data comes in- this statement is a modification of the Console.Write("enter..." from below
        string PromptUserInput(string prompt) {
            Console.Write(prompt);
            string response = Console.ReadLine();
            return response; //this tells us to return the response string
        }

        string Fibonacci(string fib) {
            Console.Write(fib);
          
        }

        void Run() {
            Student student = new Student(); // (this is a constructor), method name = same as class.

            // commented out code below shows initial methods, which have been replaced by the string PromptUserInput

            //Console.Write("Enter First Name:  ");
            //string fname = Console.ReadLine();
            string fname = PromptUserInput("Enter First Name: ");
            student.EnterFirstName(fname);

            string lname = PromptUserInput("Enter Last Name: ");
            //Console.Write("Enter Last Name:  ");
            //string lname = Console.ReadLine();

            student.EnterLastName(lname);

            string tempEmail = PromptUserInput("Enter Email: ");
            //Console.Write("Enter Email:  ");
            //string tempEmail = Console.ReadLine();

            student.EnterEmail(tempEmail);
                string tempPhone = PromptUserInput("Enter Phone: ");
            //Console.Write("Enter Phone:  ");
            //string tempPhone = Console.ReadLine();

            student.EnterPhone(tempPhone);

          
            student.EnterFirstName("Alex");
            student.EnterLastName("Cobb");
            student.EnterCity("Bellevue");
            student.EnterState("KY");
            student.EnterZip("41703");
            student.EnterEmail("afcobb@gmail.com");
            student.EnterPhone("5135920744");
            student.Display();
            student.Print();

            //****** WHEN USER ENTERS DATA you often have to prompt them *******
            Console.Write("Enter some data: ");
            string response = Console.ReadLine(); //this should write "enter some data" then store in response whatever they write
            Console.WriteLine(response); //prints response from user
            Console.ReadKey();
        }

        static void Main (string[] args) {
            (new Program()).Run();
        }
    }
}

