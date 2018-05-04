using System;
using Task3.Solution.Interfaces;

namespace Task3.Solution.Observers
{
    public class Broker : IObserver
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Update(object sender, StockInfo info)
        {
            if (info.USD > 30)
            {
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, info.USD);
            } 
            else
            {
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, info.USD);
            }
        }
    }
}
