using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class EditRaceRequest
    {
        [Required(ErrorMessage="Vous devez renseigner un nom à votre course")]
        public string? RaceName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime RaceDate { get; set; }

        public int FreePlaces { get; set; }
    }
}