using System;
using Task3.Solution;
using Task3.Solution.Interfaces;

namespace Task3.Solution.Observers
{
    public class Bank : IObserver
    {
        public string Name { get; set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        public void Update(object sender, StockInfo info)
        {
            if (info.Euro > 40)
            {
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, info.Euro);
            }
            else
            {
                 Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, info.Euro);
            }
               
        }
    }
}
