using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    interface Subject
    {
        string registerObserver(IObserver observer);
        string removeObserver(IObserver observer);
        void notifyObservers();
    }
}
