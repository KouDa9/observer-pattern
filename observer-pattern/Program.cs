using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject sub = new ConcreteSubject();
            ConcreteObserver obs1 = new ConcreteObserver();
            ConcreteObserver obs2 = new ConcreteObserver();

            sub.registerObserver(obs1);
            sub.State = "odin";
            Console.WriteLine(obs1.counter);
            Console.WriteLine(obs2.counter);

            sub.registerObserver(obs2);
            sub.State = "dwa";
            Console.WriteLine(obs1.counter);
            Console.WriteLine(obs2.counter);

            sub.removeObserver(obs2);
            sub.State = "tri";
            Console.WriteLine(obs1.counter);
            Console.WriteLine(obs2.counter);
            Console.ReadKey();
        }
    }
}
