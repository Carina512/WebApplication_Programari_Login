using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using WebApplication_Programari.Data;
using WebApplication_Programari.Migrations;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Pages.Doctori
{
   
    public class IndexModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public IndexModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
        }

        public IList<Doctor> Doctor { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder)
        {
            if (_context.Doctor != null)
            {
                Doctor = await _context.Doctor.ToListAsync();
            }
            
        }
    }
}
