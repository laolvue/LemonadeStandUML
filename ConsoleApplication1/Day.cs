using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Day
    {
        public List<string> dayNames;
        public Weather weather;
        public Day()
        {
            dayNames = new List<string>();
            weather = new Weather();
        }
        public void DefineDay();
    }
}
