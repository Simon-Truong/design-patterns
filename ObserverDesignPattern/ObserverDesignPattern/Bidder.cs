using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    public class Bidder : Observer
    {
        private ulong CurrentBid;
        private ISubject Subject;
        private int Id;
        public Bidder(ISubject subject)
        {
            Subject = subject;
            Subject.AttachObserver(this);
            Id = Subject.GetObserverCount();
        }
        public void Update(ulong currentBid)
        {
            CurrentBid = currentBid;
            PrintCurrentBid();
        }

        private void PrintCurrentBid()
        {
            Console.WriteLine($"Observer: {Id}");
            Console.WriteLine($"NOTIFY! Current bid : ${CurrentBid}");
        }
    }
}
