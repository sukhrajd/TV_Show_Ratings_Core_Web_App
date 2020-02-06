using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TV_Show_Ratings_Core_Web_App.BusinessModel
{
    public class TVChannel
    {
        public int Id { get; set; }

        public string ChannelName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Established { get; set; }
    }
}
