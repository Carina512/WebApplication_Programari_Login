using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication_Programari.Data;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Pages.Doctori
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public CreateModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Doctor Doctor { get; set; } = new Doctor();

        public IActionResult OnGet()
        {
           
            return Page();
        }

      


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Doctor == null || Doctor == null)
            {
                return Page();
            }

            _context.Doctor.Add(Doctor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}