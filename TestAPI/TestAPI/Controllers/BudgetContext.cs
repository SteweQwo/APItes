using TestAPI.Models;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Controllers
{
    public class BudgetContext : DbContext
    {

        public BudgetContext(DbContextOptions<BudgetContext> options)
            : base(options)
        {

        }

        public DbSet<Budget> Budgets { get; set; }
    }

}
