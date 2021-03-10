using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShare
{
    interface ITradeOperations
    {
        void RecordTrade(Stocks s);
        void VolumeWeightStockPrice();
    }
}
