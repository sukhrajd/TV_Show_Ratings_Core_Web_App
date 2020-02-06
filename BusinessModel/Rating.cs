using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show_Ratings_Core_Web_App.BusinessModel
{
    public class Rating
    {
        public int Id { get; set; }

        public int SubscriberId { get; set; }

        public int TVShowId { get; set; }

        public Subscriber Subscriber { get; set; }

        public TVShow TVShow { get; set; }

        [Range(0,5)]
        public int RatingValue { get; set; }



    }
}
