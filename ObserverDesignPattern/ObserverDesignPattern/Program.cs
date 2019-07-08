using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Auction Auction = new Auction();

            Bidder Bidder1 = new Bidder(Auction);
            Bidder Bidder2 = new Bidder(Auction);

            Auction.SetCurrentBid(10000000);

            Auction.RemoveObserver(Bidder1);

            Auction.SetCurrentBid(20000000);

            Console.ReadKey();
        }
    }
}
