using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NearbySluWeb.Models
{
    public class addNewPlace
    {
        [Key]
        public int placeId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string PlaceName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Category { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Distance { get; set; }
    }
}
