#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryApp.Data;
using InventoryApp.Models;

namespace InventoryApp.Views.PageInventory
{
    public class IndexModel : PageModel
    {
        private readonly InventoryApp.Data.InventoryAppContext _context;

        public IndexModel(InventoryApp.Data.InventoryAppContext context)
        {
            _context = context;
        }

        public IList<Inventory> Inventory { get;set; }

        public async Task OnGetAsync()
        {
            Inventory = await _context.Inventory.ToListAsync();
        }
    }
}
