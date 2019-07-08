using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Auction : ISubject
    {
        private static int ObserverCount;
        private ulong CurrentBid;
        private List<Observer> Observers;

        public Auction()
        {
            Observers = new List<Observer>();
            CurrentBid = 0;
            ObserverCount = 0;
        }

        public void AttachObserver(Observer observer)
        {
            Observers.Add(observer);
            ObserverCount++;
        }

        public void RemoveObserver(Observer observer)
        {
            Observers.Remove(observer);
            ObserverCount--;
        }

        public void NotifyAllObserver()
        {
            foreach(Observer observer in Observers)
            {
                observer.Update(CurrentBid);
            }
        }

        public void SetCurrentBid(ulong currentBid)
        {
            CurrentBid = currentBid;
            NotifyAllObserver();
        }

        public ulong GetCurrentBid()
        {
            return CurrentBid;
        }
        public int GetObserverCount()
        {
            return ObserverCount;
        }
    }
}
