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
    public class IndexModel : PageModel
    {
        private readonly TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext _context;

        public IndexModel(TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext context)
        {
            _context = context;
        }

        public IList<TVShow> TVShow { get;set; }

        public async Task OnGetAsync()
        {
            TVShow = await _context.TVShow
                .Include(t => t.TvChannel).ToListAsync();
        }
    }
}
