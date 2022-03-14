using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ConcreteSubject
    {
        List<ConcreteObserver> people = new List<ConcreteObserver>();
        string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value; notifyObservers();
            }
        }

        public void registerObserver(ConcreteObserver observer)
        {
            people.Add(observer);
        }
        public void removeObserver(ConcreteObserver observer)
        {
            people.Remove(observer);
        }
       
        public void notifyObservers()
        {
            foreach(var human in people)
            {
                human.update();
            }
            
        }
    }
}
