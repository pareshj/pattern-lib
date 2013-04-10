﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._1
{
    public class GoogleObserver: AbstractObserver
    {
        public GoogleObserver(StockTicker subj)
        {
            this.DataSource = subj;
            subj.Register(this);
        }
        private StockTicker DataSource { get; set; }
        public override void Update()
        {
            decimal price = DataSource.Stock.Price;
            string symbol = DataSource.Stock.Symbol;

            if (symbol == "GOOG")
                Console.WriteLine("Google's new price is: {0}", price);
        }
    }
}
