using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Customer
    {
        public List<int> customer;
        Random customerVisit;
        public int TotalCustomers;
        public Customer()
        {
            customer = new List<int>();
            customerVisit = new Random();
        }
        public void DetermineBuyers(string weather, double lemonadePrice, int pitchers)
        {
        }
        public void DetermineNumberOfCustomers(string weather)
        {
        }
    }
}
