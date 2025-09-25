using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = ""; 

        [Required, StringLength(60)]
        public string Quantity { get; set; } = ""; 

        
        [Required]
        public int RecipeId { get; set; }

        
        public Recipe? Recipe { get; set; }
    }
}
