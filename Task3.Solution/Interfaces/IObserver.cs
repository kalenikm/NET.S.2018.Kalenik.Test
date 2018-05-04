using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Solution.Interfaces
{
    public interface IObserver
    {
        void Update(object sender, StockInfo info);
    }
}
