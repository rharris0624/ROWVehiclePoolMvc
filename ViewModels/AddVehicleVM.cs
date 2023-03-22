using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RowVehiclePoolMVC.Models.Validation;

namespace RowVehiclePoolMVC.ViewModels
{
    public class AddVehicleVM
    {
        [Key]
        [StringLength(5)]
        [Required(ErrorMessage="Invalid Tag Number")]
        [ValidVehicleToAdd]
        public string TagNumber { get; set; }
        [Column(TypeName = "numeric(4, 0)")]
        public decimal VehYear { get; set; }
        [Required]
        [StringLength(30)]
        public string Make { get; set; }
        [Required]
        [StringLength(30)]
        public string Model { get; set; }
        [Required]
        [StringLength(30)]
        public string Color { get; set; }
        [Required]
        [StringLength(10)]
        public string VehicleType { get; set; }
        [Required]
        [StringLength(3)]
        public string OwnerBudget { get; set; }
        [Range(1,12)]
        public int ServiceMonth { get; set; }
        [Range(1,31)]
        public int ServiceDay { get; set; }
        [Range(2012,2050)]
        public int ServiceYear { get; set; }
        public bool searchAttempted { get; set; }
        public bool searchSuccessful { get; set; }
    }
}
