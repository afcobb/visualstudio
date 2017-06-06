using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    class Program {

        void Run() {
            Customer cust1 = new Customer();
            cust1.Id = 1;
            cust1.Name = "Max Tech Training";
            cust1.Username = "MTT12345";
            cust1.Password = "password";
            cust1.Display();

            //creating the first instance of a customer
            Account acct1 = new Account();
            acct1.Id = 100;
            acct1.Description = "My first account";
            acct1.Deposit(100.0);
            acct1.Customer = cust1; //ties customer to this instance
            acct1.Display();
            acct1.Withdraw(25.0);
            acct1.Display();
            acct1.Withdraw(10000.0);
            acct1.Display();

            //transfer 25 from one to another

            //creating a second account
            Account acct2 = new Account();
            acct2.Id = 200;
            acct2.Description = "My second account";
            acct2.Deposit(0.0);
            acct2.Customer = cust1;
            acct2.Display();

            //transfer code
            acct1.Display();
            acct2.Display();
            acct1.Transfer(25.0, acct2);
            acct1.Display();
            acct2.Display();

            //savings class
            Savings sav1 = new Savings();
            sav1.Id = 300;
            sav1.Description = "This is the savings account";
            sav1.Customer = cust1;
            sav1.Deposit(500.00);
            sav1.Withdraw(200.00);
            sav1.Display();
            sav1.intRate = .12; //set interest rate
            sav1.PayInterest(); // pay the interest
            sav1.Display();

        }
        static void Main(string[] args) {
            (new Program()).Run();
        }
    }
}
