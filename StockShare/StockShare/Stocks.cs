using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShare
{
    public class Stocks:IStockOperation
    {
        public string StockName;
        public int StockId;
        public int Quantity;
        public float Price;
        public float AnnualDividend;

       public Stocks(string stockName, int stockId,int quantity,float price, float annualDividend)
        {
            StockName = stockName;
            StockId = stockId;
            Quantity = quantity;
            Price = price;
            AnnualDividend = annualDividend;
        }
       public float calcDividend()
       {
           try
           {
               return (AnnualDividend / Price) * 100;

           }
           catch
           {
               return 0;
           }
         
       }
        public float CalcPERatio()
        {
            try
            {
                return calcDividend() / Price;
            }
            catch
            {
                return 0;
            }
            
        }
      
    }
}
