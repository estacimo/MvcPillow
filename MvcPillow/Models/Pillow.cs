using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcPillow.Models
{
    public class Pillow
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Size { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(50)]
        public string Purpose { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Density { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Color { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Shape { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string Material { get; set; }
        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")] 
        [Display(Name = "Customer Rating"), Range(1.0, 5.0)]
        public decimal CustomerRating { get; set; }
    }
}
