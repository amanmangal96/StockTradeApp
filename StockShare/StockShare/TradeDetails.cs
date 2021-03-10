using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShare
{
    public class TradeDetails:ITradeOperations
    {
        public DateTime StartTime;
        public DateTime EndTime;
        public int Quantity;
        public ActionOnShare Action;
        public static float TotalQuantity;
        public static float TotalPrice;
        public static float TotalValue;
        public static float VolumePrice;
        public static float gmValue=1;
        public enum ActionOnShare
        {
            Buy,Sell
        }
        public TradeDetails(DateTime startTime, DateTime endTime, int quantity,ActionOnShare action) 
        {
            StartTime = startTime;
            EndTime = endTime;
            Quantity = quantity;
            Action = action;
        }

        public void RecordTrade(Stocks s)
        {
            var timestamp = EndTime.Subtract(StartTime);
            AllShareGM(s.Price, TotalQuantity,Quantity);
            Console.WriteLine("Timestamp:"+timestamp.TotalMinutes+ " Quantity purchased: "+Quantity+ " Action Performed buy or sell:"+Action +" Share name"+s.StockName+"Share price"+s.Price);
            if (timestamp.TotalMinutes <= 5)
            {
                TotalPrice = TotalPrice + s.Price;
                TotalQuantity = TotalQuantity + Quantity;
                TotalValue = TotalValue + (TotalPrice * TotalQuantity);
            }
           
           
        }
        public void AllShareGM(float price,float TotalQuantity,int quantity)
        {
            for(float count=TotalQuantity;count<TotalQuantity+quantity;count++)
                gmValue = gmValue *price*(count+1);
           
        }
        public void VolumeWeightStockPrice()
        {
            try
            {
               VolumePrice= (TotalValue / TotalQuantity);
            }
            catch
            {
               //log exception
            }
        }
    }
}
