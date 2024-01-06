using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication_Programari.Data;
using WebApplication_Programari.Models;

namespace WebApplication_Programari.Pages.Reviews
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public IndexModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Review != null)
            {
                Review = await _context.Review.ToListAsync();
            }
        }
        public string GetStarRating(int nota)
        {
            string stelutePline = string.Empty;
            string steluteGoale = string.Empty;

            for (int i = 0; i < nota; i++)
            {
                stelutePline += "★"; // Adăugați un caracter stea plină
            }

            for (int i = nota; i < 5; i++)
            {
                steluteGoale += "☆"; // Adăugați un caracter stea goală
            }

            return stelutePline + steluteGoale;
        }
    }
}

