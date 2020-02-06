using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show_Ratings_Core_Web_App.BusinessModel
{
    public class TVShow
    {
        public int Id { get; set; }

        public int TVChannelId { get; set; }

        public string ShowName { get; set; }

        public TVChannel TvChannel { get; set; }
    }
}
