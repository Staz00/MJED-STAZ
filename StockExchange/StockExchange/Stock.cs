using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public class Stock
    {
        private int baseStock;
        private int stockMultiplier;

        private string name;

        public Stock()
        {

        }

        public Stock(string _name, int _stock)
        {
            baseStock = _stock;
            name = _name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetMultiplier(int multiplier)
        {
            stockMultiplier = multiplier;
        }

        public int GetStock()
        {
            return baseStock;
        }
       
        public int GetStockPrice()
        {
            if (stockMultiplier == 0)
                return 1;

            return baseStock * stockMultiplier;
        }

    }
}
