using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TV_Show_Ratings_Core_Web_App.BusinessModel;
using TV_Show_Ratings_Core_Web_App.Models;

namespace TV_Show_Ratings_Core_Web_App.Pages.Ratings
{
    public class CreateModel : PageModel
    {
        private readonly TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext _context;

        public CreateModel(TV_Show_Ratings_Core_Web_App.Models.TV_Show_Ratings_DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["SubscriberId"] = new SelectList(_context.Set<Subscriber>(), "Id", "SubscriberName");
        ViewData["TVShowId"] = new SelectList(_context.Set<TVShow>(), "Id", "ShowName");
            return Page();
        }

        [BindProperty]
        public Rating Rating { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rating.Add(Rating);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
