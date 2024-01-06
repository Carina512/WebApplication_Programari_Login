using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication_Programari.Data;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Pages.Programari
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;
        public CreateModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
            
        }
        [BindProperty]
        public Programare Programare { get; set; }

        public List<SelectListItem> DoctorList { get; set; }


        public IActionResult OnGet()
        {
            DoctorList = _context.Doctor
           .Select(d => new SelectListItem { Value = d.ID.ToString(), Text = d.FullName })
           .ToList();
           

            return Page();
        }

        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Programare == null || Programare == null )
            {
                return Page();
            }

            _context.Programare.Add(Programare);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
