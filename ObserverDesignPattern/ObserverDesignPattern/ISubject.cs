using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public interface ISubject
    {
        void AttachObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyAllObserver();
        void SetCurrentBid(ulong currentBid);
        ulong GetCurrentBid();
        int GetObserverCount();
    }
}
