using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject1 {
    public class Student {
        public Student() { //default constructor - created by vs.net if no other constructor exists
            firstName = "George";
            //this would become the default first name if non entered
        }
        public Student(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        private string firstName;
        private string lastName;
        private string city;
        private string state;
        private string zip;
        private string email;
        private string phone;

        public void Display() {
            Console.WriteLine(firstName + " " + lastName); //writes the two above lines as one line with a space
            Console.WriteLine(city + ", " + state + " " + zip);
            Console.WriteLine(email);
            Console.WriteLine(phone);
            Console.ReadKey();
        }
        public void EnterFirstName(string FirstName) {
            firstName = FirstName; //thisallows us to store what the user inputs into the variable we created
        }
        public void EnterLastName(string LastName) {
            lastName = LastName;
        }
        public void EnterCity(string City) {
            city = City;
        }
        public void EnterState(string State) {
            state = State;
        }
        public void EnterZip(string Zip) {
            zip = Zip;
        }
        public void EnterEmail(string Email) {
            email = Email;
        }
        public void EnterPhone(string Phone) {
            phone = Phone;
        }
        //another method to print name in a different way
        public void Print() {
            Console.WriteLine(firstName + " " + lastName + "|" + email + "|" + phone);
            Console.ReadKey();

        }
    }
}
