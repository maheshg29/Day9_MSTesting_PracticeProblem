﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_MSTesting_PracticeProblem
{
    public class Purches
    {
        public List<string> OnlyOnce(string inputPrices)
        {
            string[] prices = inputPrices.Split(' ');
            Dictionary<string, int> sales = new Dictionary<string, int>();
            List<string> onceValue= new List<string>();

            for (int i = 0; i < prices.Length; i++)
            {
                if (sales.ContainsKey(prices[i]))
                {
                    sales[prices[i]]++;
                }
                else
                {
                    sales[prices[i]] = 1;
                }
            }

            bool foundSingleSale = false;

            foreach (KeyValuePair<string, int> sale in sales)
            {
                if (sale.Value == 1)
                {
                   
                    foundSingleSale = true;
                    onceValue.Add(sale.Key);
                }
            }

            if (!foundSingleSale)
            {
                
                onceValue.Add(null);
            }
            return onceValue;

        }
    }
}
