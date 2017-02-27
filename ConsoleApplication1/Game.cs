using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Game
    {
        public Store store;
        public Day day;
        public UserInterface userInterface;
        private int gameMode;
        private int gameRound;
        private int startingBudget;
        //-------------------------
        public Game()
        {
            store = new Store();
            day = new Day();
            userInterface = new UserInterface();
        }
        //-------------------------
        public void AddPlayer()
        {
        }
        public void DeleteLosingPLayer()
        {
        }
        public void StartGame()
        {
        }
        public void StartWeek()
        {
        }
    }
}
