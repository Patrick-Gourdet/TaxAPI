﻿//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Author: Patrick Gourdet Reinhard
/// Company: Iron Finacials LLC
/// Date: 09/03/2020
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TaxDemo.DataAccess.Contexts;
using TaxDemo.DataAccess.InterfaceContexts;
using TaxDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace TaxDemo.DataAccess
{
    /// <summary>
    /// Calculation Db access
    /// the data from tax rates can be accessed either DB or API 
    /// </summary>
    public class CalculatorDbContext :  ICalculateDbContext
    {

        private readonly DataContextCalc _context;
        /// <summary>
        /// Injecting the shared DB context into the controller
        /// TODO Abstract db from controller in separate class
        /// </summary>
        /// <param name="context"></param>
        public CalculatorDbContext(DataContextCalc context)
        {
            _context = context;
        }

        public async Task<int> SaveChanges(TaxCalculationItemEvent item)
        {
            _context.taxCalculationUsingZip.Add(item);
            return await _context.SaveChangesAsync();
            
        }
        public async Task<List<TaxCalculationItemEvent>> GetCalculations()
        {
            return await _context.taxCalculationUsingZip.ToListAsync();

        }
    }
}