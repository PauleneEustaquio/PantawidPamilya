#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PantawidPamilya.Data;
using PantawidPamilya._4ps;

namespace PantawidPamilya.Pages.pntwd
{
    public class DetailsModel : PageModel
    {
        private readonly PantawidPamilya.Data.PantawidPamilyaContext _context;

        public DetailsModel(PantawidPamilya.Data.PantawidPamilyaContext context)
        {
            _context = context;
        }

        public Class Class { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Class = await _context.Class.FirstOrDefaultAsync(m => m.ID == id);

            if (Class == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
