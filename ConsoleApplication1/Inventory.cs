using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Inventory
    {
        public double costOfIce;
        public double costOfLemon;
        public double costOfLemonade;
        public double costOfPitcher;
        public double costOfSugar;
        public List<Lemon> lemon;
        public List<Ice> ice;
        public List<Pitcher> pitcher;
        public List<Sugar> sugar;
        public Inventory()
        {
            lemon = new List<Lemon>();
            ice = new List<Ice>();
            pitcher = new List<Pitcher>();
            sugar = new List<Sugar>();
        }
        public void AddIce()
        {
        }
        public void AddInventory()
        {
        }
        public void AddLemon()
        {
        }
        public void AddPitcher()
        {
        }
        public void AddSugar()
        {
        }
    }
}
