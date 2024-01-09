﻿//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Author: Patrick Gourdet Reinhard
/// Company: Iron Finacials LLC
/// Date: 08/28/2020
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using Auth.Model;
using Microsoft.EntityFrameworkCore;

namespace Auth.DataAccess.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
   
        public DbSet<AuthModel> auth { get; set; }

    }
}