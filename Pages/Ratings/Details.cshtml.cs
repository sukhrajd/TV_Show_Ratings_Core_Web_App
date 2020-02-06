using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TV_Show_Ratings_Core_Web_App.BusinessModel;
using TV_Show_Ratings_Core_Web_App.Models;

namespace TV_Show_Ratings_Core_Web_App.Pages.Ratings
{
    public class DetailsModel : PageModel
    {
        private readonly TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext _context;

        public DetailsModel(TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext context)
        {
            _context = context;
        }

        public Rating Rating { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rating = await _context.Rating
                .Include(r => r.Subscriber)
                .Include(r => r.TVShow).FirstOrDefaultAsync(m => m.Id == id);

            if (Rating == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
