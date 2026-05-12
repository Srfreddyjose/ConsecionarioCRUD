using System.ComponentModel.DataAnnotations;

namespace CONCESIONARIO.Models
{
    public class Cars
    {
        [Key]
        [Display (Name = "Cars ID")]
        public int carsId { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }

        public int Precio { get; set; }
    }
}
