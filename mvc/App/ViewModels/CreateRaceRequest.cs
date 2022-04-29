using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateRaceRequest
    {
        [Required(ErrorMessage = "Vous devez renseigner un nom à votre course")]
        [MinLength(2)]
        [MaxLength(50)]
        public string? RaceName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime RaceDate { get; set; }

        [Required]
        public int FreePlaces { get; set; }
    }
}