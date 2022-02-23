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
    public class DetailsModel : PageModel
    {
        private readonly InventoryApp.Data.InventoryAppContext _context;

        public DetailsModel(InventoryApp.Data.InventoryAppContext context)
        {
            _context = context;
        }

        public Inventory Inventory { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Inventory = await _context.Inventory.FirstOrDefaultAsync(m => m.InventoryId == id);

            if (Inventory == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
