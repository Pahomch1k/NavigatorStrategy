using System;
using static System.Console;

namespace Dz_18_NavigatorStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var navigator = new Navigator();

            int flag = 0;
            while (flag == 0)
            {
                WriteLine("1. Road\n2. Walk\n3. Transport\n4. Exit");
                int choise = Convert.ToInt32(ReadLine());

                switch (choise)
                {
                    case 1: navigator.SetStrategy(new RoadStrat()); break;
                    case 2: navigator.SetStrategy(new WalkingStrat()); break;
                    case 3: navigator.SetStrategy(new TransportStrat()); break;
                    default: flag++; break;
                }
                navigator.ChoiseMarsh();
            } 
        }
    }
}
