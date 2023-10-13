using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcPillow.Models
{
    public class PillowSizeViewModel
    {
        public List<Pillow> Pillows { get; set; }
        public SelectList Sizes { get; set; }
        public string PillowSize { get; set; }
        public string SearchString { get; set; }
    }
}