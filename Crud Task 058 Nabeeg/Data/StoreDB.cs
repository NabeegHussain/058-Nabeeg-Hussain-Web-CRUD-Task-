using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_Task_058_Nabeeg.Models;

namespace Crud_Task_058_Nabeeg.Data
{
    public class StoreDB : DbContext
    {
        public StoreDB(DbContextOptions<StoreDB> options)
            : base(options)
        {
        }

        public DbSet<Crud_Task_058_Nabeeg.Models.Order> Order { get; set; }
    }
}
