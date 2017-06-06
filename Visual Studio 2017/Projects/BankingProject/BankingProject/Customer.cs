using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {

    public class Customer {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    
    public void Display() {
            String.Format("Id is {0}, Name is {1}, Username is {2}", Id, Name, Username, Password);
        }

    }
}
