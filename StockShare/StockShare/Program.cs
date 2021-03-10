using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShare
{
    class Program
    {
        static void Main(string[] args)
        {

            Stocks stocks1 = new Stocks("AB", 1,100,30,10);
            Stocks stocks2 = new Stocks("cd", 2, 500, 40,20);
            Stocks stocks3 = new Stocks("ef", 3, 200, 50,30);
            List<Stocks> stockList=new List<Stocks>();
            stockList.Add(stocks1);
            stockList.Add(stocks2);
            stockList.Add(stocks3);
            foreach (var stock in stockList)
            {
               var dividendYield= stock.calcDividend();
               var PeRatio= stock.CalcPERatio();
               Console.WriteLine($"DividendYield {dividendYield} and PeRatio {PeRatio}");

            }
            TradeDetails trade1 =new TradeDetails(DateTime.Now, DateTime.Now.AddMinutes(1),2,TradeDetails.ActionOnShare.Buy);
            TradeDetails trade2 = new TradeDetails(DateTime.Now, DateTime.Now.AddMinutes(1), 5, TradeDetails.ActionOnShare.Buy);
            TradeDetails trade3 = new TradeDetails(DateTime.Now, DateTime.Now.AddMinutes(2), 8, TradeDetails.ActionOnShare.Buy);
            trade1.RecordTrade(stocks1);//will display record trade
            trade2.RecordTrade(stocks2);
            trade3.RecordTrade(stocks3);
            trade1.VolumeWeightStockPrice();
            var VolumeWeightedStock = TradeDetails.VolumePrice;
            var AllStockGeometricmean = (float)Math.Pow(TradeDetails.gmValue, (float)1 / TradeDetails.TotalQuantity);
            Console.WriteLine($"VolumeWeightedStock {VolumeWeightedStock} and AllStockGeometricmean {AllStockGeometricmean}");
            Console.ReadLine();
        }

       
    }
}
