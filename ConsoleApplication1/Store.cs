using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Store
    {
        public double budget;
        public Customer customer;
        public double dailyProfit;
        Regex number = new Regex();
        public string playerName;
        public double startingBudget;
        public double tip;
        public double tipCheck;
        public int winLose;
        private Inventory inventory;
        //------
        public Store()
        {
            customer = new Customer();
            inventory = new Inventory();
        }
        public void BuyIce(string question)
        {
        }
        public void BuyLemon(string question)
        {
        }
        public void BuyPitcher(string question)
        {
        }
        public void BuySugar(string question)
        {
        }
        public void CalculateBudget(Action buyIngredient, string question, int ingredient)
        {
        }
        public void CalculateBudgetGivenPitchers()
        {
        }
        public void DecreaseCharge()
        {
        }
        public void DetermineCustomers(string weather)
        {
        }
        public void DetermineDayProfit()
        {
        }
        public void DetermineNumberOfBuyers(string weather)
        {
        }
        public void DetermineSales()
        {
        }
        public void DisplayCostOfLemonade()
        {
        }
        public void DisplayInventory()
        {
        }
        public void DisplayResults()
        {
        }
        public void IncreaseCharge()
        {
        }
        public void PromptInputNumber(string question, Func testNumber)
        {
        }
        public void SetName()
        {
        }
        public void TestNumber(string input)
        {
        }
    }
}
