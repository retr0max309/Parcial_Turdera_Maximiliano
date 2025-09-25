using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = ""; 

        [StringLength(200)]
        public string? Description { get; set; }

        
        public List<Recipe> Recipes { get; set; } = new();
    }
}
