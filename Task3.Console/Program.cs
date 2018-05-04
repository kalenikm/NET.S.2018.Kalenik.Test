using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;
using Task3.Solution;
using Task3.Solution.Observers;

namespace Task3.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank1 = new Bank("Bank1");
            Bank bank2 = new Bank("Bank2");
            Broker broker = new Broker("Broker");

            Stock stock = new Stock();
            stock.Register(bank1);
            stock.Register(bank2);
            stock.Register(broker);

            stock.Market();
            System.Console.WriteLine();
            stock.Market();
            System.Console.WriteLine();

            stock.Unregister(bank1);

            stock.Market();
            System.Console.WriteLine();
        }
    }
}
