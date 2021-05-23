using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridgeInventory.Data
{
    public class InventoryMgmtContext : DbContext

    {
        public InventoryMgmtContext(DbContextOptions<InventoryMgmtContext> options)
            : base(options)
        {
            
        }
        public DbSet<ShopBridgeInventory.Models.Category> category { get; set; }
        public DbSet<ShopBridgeInventory.Models.Product> product { get; set; }
    }
}
