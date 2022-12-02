using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace NearbySluWeb.Models
{
    public class storeOffersAdd
    {
        [Key]
        public int offerId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Offer_Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Offer_Description { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Offer_Category { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Offer_Valid_upto { get; set; }
    }
}
