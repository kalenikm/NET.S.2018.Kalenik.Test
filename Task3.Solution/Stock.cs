using System;
using Task3.Solution.Interfaces;

namespace Task3.Solution
{
    public delegate void OnUpdate(object sender, StockInfo info);

    public class Stock : IObservable
    {
        private StockInfo stocksInfo = new StockInfo();

        public event OnUpdate Update;

        public void Register(IObserver observer) => Update += observer.Update;

        public void Unregister(IObserver observer) => Update -= observer.Update;

        public void Notify()
        {
            Update?.Invoke(this, stocksInfo);
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
