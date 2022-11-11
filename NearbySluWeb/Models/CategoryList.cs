using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NearbySluWeb.Models
{
    public class CategoryList
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CategoryName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Description { get; set; }

    }
}
