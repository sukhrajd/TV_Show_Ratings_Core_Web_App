using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TV_Show_Ratings_Core_Web_App.BusinessModel;
using TV_Show_Ratings_Core_Web_App.Models;

namespace TV_Show_Ratings_Core_Web_App.Pages.TVShows
{
    public class DeleteModel : PageModel
    {
        private readonly TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext _context;

        public DeleteModel(TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TVShow TVShow { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TVShow = await _context.TVShow
                .Include(t => t.TvChannel).FirstOrDefaultAsync(m => m.Id == id);

            if (TVShow == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TVShow = await _context.TVShow.FindAsync(id);

            if (TVShow != null)
            {
                _context.TVShow.Remove(TVShow);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
