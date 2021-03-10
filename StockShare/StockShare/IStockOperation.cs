using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShare
{
    interface IStockOperation
    {
        float CalcPERatio();
        float calcDividend();
    }
}
