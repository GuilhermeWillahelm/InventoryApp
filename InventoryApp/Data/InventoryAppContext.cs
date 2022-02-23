#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryApp.Models;

namespace InventoryApp.Data
{
    public class InventoryAppContext : DbContext
    {
        public InventoryAppContext (DbContextOptions<InventoryAppContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryApp.Models.Inventory> Inventory { get; set; }
    }
}
