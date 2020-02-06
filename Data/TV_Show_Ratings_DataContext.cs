using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TV_Show_Ratings_Core_Web_App.BusinessModel;

namespace TV_Show_Ratings_Core_Web_App.Models
{
    public class TV_Show_Ratings_DataContext : DbContext
    {
        public TV_Show_Ratings_DataContext (DbContextOptions<TV_Show_Ratings_DataContext> options)
            : base(options)
        {
        }

        public DbSet<TV_Show_Ratings_Core_Web_App.BusinessModel.Rating> Rating { get; set; }

        public DbSet<TV_Show_Ratings_Core_Web_App.BusinessModel.Subscriber> Subscriber { get; set; }

        public DbSet<TV_Show_Ratings_Core_Web_App.BusinessModel.TVChannel> TVChannel { get; set; }

        public DbSet<TV_Show_Ratings_Core_Web_App.BusinessModel.TVShow> TVShow { get; set; }
    }
}
