using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Agriturismo.Data;
using Agriturismo.Models;
using AutoMapper;

namespace Agriturismo.Areas.Administrator.Controllers
{
    public class CreateAppModel : PageModel
    {
        private readonly Agriturismo.Data.DataAgriContext _context;

        public CreateAppModel(Agriturismo.Data.DataAgriContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AppartamentVM AppartamentVM { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AppartamentVM.Add(AppartamentVM);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
