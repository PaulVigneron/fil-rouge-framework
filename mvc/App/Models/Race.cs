
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public DateOnly EventDate { get; set; }
    }
}