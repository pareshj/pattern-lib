﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Pattern._1
{
    public class StockTicker: AbstractSubject
    {
        private Stock stock;
        public Stock Stock
        {
            get { return stock; }
            set 
            {
                stock = value;
                this.Notify();
            }
        }
    }
}
