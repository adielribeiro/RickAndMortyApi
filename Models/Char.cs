using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rm.API.Models
{
    public class Char
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public string? status { get; set; }
        public string? especies  { get; set; }
        public string? type { get; set; }
        public string? render { get; set; }
       // public CharOrigin? origin { get; set; }
        //public CharLocation? location { get; set; }
        public string? image { get; set; }
       // public string? episode { get; set; }
        public string? url { get; set; }
        public string? created { get; set; }

    }
}