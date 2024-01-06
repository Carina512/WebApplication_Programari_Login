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
    public class EditModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public EditModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
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

            var programare =  await _context.Programare.FirstOrDefaultAsync(m => m.ID == id);
            if (programare == null)
            {
                return NotFound();
            }
            Programare = programare;
            ViewData["DoctorID"] = new SelectList(_context.Set<Doctor>(), "ID",
  "FullName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Programare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramareExists(Programare.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProgramareExists(int id)
        {
          return (_context.Programare?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
