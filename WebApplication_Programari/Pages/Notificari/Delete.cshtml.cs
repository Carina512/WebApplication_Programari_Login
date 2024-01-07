using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication_Programari.Data;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Pages.Notificari
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public DeleteModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Notificare Notificare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Notificare == null)
            {
                return NotFound();
            }

            var notificare = await _context.Notificare.FirstOrDefaultAsync(m => m.id == id);

            if (notificare == null)
            {
                return NotFound();
            }
            else 
            {
                Notificare = notificare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.Notificare == null)
            {
                return NotFound();
            }
            var notificare = await _context.Notificare.FindAsync(id);

            if (notificare != null)
            {
                Notificare = notificare;
                _context.Notificare.Remove(Notificare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
