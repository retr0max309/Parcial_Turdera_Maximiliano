using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = "";

        [StringLength(500)]
        public string? Description { get; set; }

        // Relación con Category 
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        // Relación con Ingredient 
        public List<Ingredient> Ingredients { get; set; } = new();
    }
}
