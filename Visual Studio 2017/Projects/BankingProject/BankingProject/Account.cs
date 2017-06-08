using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BankingProject {

    public class Account {

        public int Id { get; set; }
        private double Balance { get; set; }
        public double AvailableBalance { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }

        public double GetBalance() {
            return Balance;
        }

        //transfer method
        public void Transfer(double amount, Account accntIn) {
            Withdraw(amount);
            accntIn.Deposit(amount);
            Debug.WriteLine("Transfer complete");

        }

        //return the new balance

        //WE NEED TO CREATE A NEW METHOD FOR THE BELOW TO MAKE IT MORE ELEGANT - REFACTORING
        //method can be private, for internal use only
        //returns true if amount is negative
        private bool CheckForNegativeAmount(double amount) {
            if (amount < 0) {
                Debug.WriteLine("Cannot be less than zero");
                // add exception for this error
                throw new NegativeInputException("Deposit or withdrawal amount is negative.");
                return true;
            }
            return false;
        }

        //CheckForNegativeAmount comes back with true or false. true = amount is negative, the exclamation point flips it true to false and vice verse
        // commented out section below is contained within CheckForNegativeAmount
        public bool Deposit(double amount) {
            if (!CheckForNegativeAmount(amount)) {
                Balance += amount;
                return true;
            }
            return false;
        }
        //Debug.WriteLine("Cannot be less than zero");
        //} else { 
        //    //add to balance
        //    Balance += amount;
        //    }
        //// return the new Balance
        //if (amount > Balance) {
        //    Debug.WriteLine("Cannot be less than zero");
        //} else {
        //        Balance += amount;
        //    }
        //    return Balance;
        //}   
        public bool Withdraw(double amount) {
            if (!CheckForNegativeAmount(amount)) {
                return false;
            }
            if (amount > Balance) {
                // to prevent overdraft
                Debug.WriteLine("Insufficient Funds");
                 InsufficientFundsException("Insufficient");
                return false;
            } else {
                Balance -= amount;
                return true;
            }

        }
        //to display after process runs
        public void Display() {
            string message = String.Format("Account: id is {0}, desc is {1}, balance is {2}, cust name is {3}", Id, Description, Balance, Customer.Name);

    
    }
}


