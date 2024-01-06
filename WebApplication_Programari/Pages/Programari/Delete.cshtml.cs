using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication_Programari.Data;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Pages.Programari
{
    public class DeleteModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public DeleteModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Programare Programare { get; set; } = default!;
        public List<SelectListItem> DoctorList { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            DoctorList = _context.Doctor
           .Select(d => new SelectListItem { Value = d.ID.ToString(), Text = d.FullName })
           .ToList(); 
            if (id == null || _context.Programare == null)
            {
                return NotFound();
            }

            var programare = await _context.Programare.FirstOrDefaultAsync(m => m.ID == id);

            if (programare == null)
            {
                return NotFound();
            }
            else 
            {
                Programare = programare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Programare == null)
            {
                return NotFound();
            }
            var programare = await _context.Programare.FindAsync(id);

            if (programare != null)
            {
                Programare = programare;
                _context.Programare.Remove(Programare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
