using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPillow.Models
{
    public class Pillow
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
        public string Purpose { get; set; }
        public string Density { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
    }
}
