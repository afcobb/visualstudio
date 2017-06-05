using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject1 {
    class Program {
        void Run() {
            Student student = new Student(); // (this is a constructor), method name = same as class.
            student.EnterFirstName("Alex");
            student.EnterLastName("Cobb");
            student.EnterCity("Bellevue");
            student.EnterState("KY");
            student.EnterZip("41703");
            student.EnterEmail("afcobb@gmail.com");
            student.EnterPhone("5135920744");
            student.Display();
            student.Print();
        }

        static void Main (string[] args) {
            (new Program()).Run();
        }
    }
}

