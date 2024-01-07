using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication_Programari.Data;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Pages.Utilizator
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public IndexModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
        }

        public IList<Utilizatori> Utilizatori { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Utilizatori != null)
            {
                Utilizatori = await _context.Utilizatori.ToListAsync();
            }
        }
    }
}
