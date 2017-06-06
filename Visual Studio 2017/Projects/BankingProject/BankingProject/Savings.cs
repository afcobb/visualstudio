using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    public class Savings: Account {

        //creating the interest rate and amount
        public double intRate { get; set; }
        public double CalcIntRateForMonth() {
            double intAmount = intRate / 12 * GetBalance();
            return intAmount;
        }
        public void PayInterest() {
            double intToBePaid = CalcIntRateForMonth();
            Deposit(intToBePaid);
        }
    }
}
