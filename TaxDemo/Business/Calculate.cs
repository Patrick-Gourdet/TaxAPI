﻿///////////////////////////////////////////////////////////////////////////////////////////////
// Author: Patrick Gourdet Reinhard
// License: Iron Financials LLC All Rights Reserved
// Email: patrick.g.reinhard@ironfinancials.com
// Date: 09/11/2020
///////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Threading.Tasks;
using TaxDemo.Model;

namespace TaxDemo.Business
{
    /// <summary>
    /// Calculate the tax for an order using taxjar 
    /// </summary>
    public class Calculate : ICalculate
    {
        /// <summary>
        /// This method uses the (combined tax rate) field from TaxJar 
        /// </summary>
        /// <param name="item"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public async Task<TaxCalculationItemEvent> CalculatedTax(RatesRate item, decimal amount)
        {
          
            var calculated = Convert.ToDecimal(item.rate.combined_rate) * amount + 0.00m;
            var calculateAsync = Task.Run( () =>
            {
                return new TaxCalculationItemEvent()
                {
                    TaxId = Guid.NewGuid(),
                    Amount = amount,
                    CalcId = Guid.NewGuid(),
                    CalculatedAmount = calculated,
                    CreatedDate = DateTime.Now,
                    Percent = Convert.ToDecimal(item.rate.combined_rate)
                };

            });
           
            return  await calculateAsync;
        }

        //Arizona
        //    California*
        //Illinois
        //    Mississippi
        //Missouri
        //    New Mexico
        //    Ohio
        //Pennsylvania
        //    Tennessee
        //Texas
        //    Utah
        //Virginia

    }
}
