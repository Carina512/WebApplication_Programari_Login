﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly WebApplication_Programari.Data.WebApplication_ProgramariContext _context;

        public DetailsModel(WebApplication_Programari.Data.WebApplication_ProgramariContext context)
        {
            _context = context;
        }

      public Utilizatori Utilizatori { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Utilizatori == null)
            {
                return NotFound();
            }

            var utilizatori = await _context.Utilizatori.FirstOrDefaultAsync(m => m.id == id);
            if (utilizatori == null)
            {
                return NotFound();
            }
            else 
            {
                Utilizatori = utilizatori;
            }
            return Page();
        }
    }
}