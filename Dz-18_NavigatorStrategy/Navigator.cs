using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_18_NavigatorStrategy
{
    class Navigator
    { 
        private IStrategy _strategy;

        public Navigator() { }
         
        public Navigator(IStrategy strategy)
        {
            _strategy = strategy;
        }
         
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
         
        public void ChoiseMarsh()
        {
            Console.WriteLine(_strategy.Marshrut()) ;
        }
    }
}
