using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateDriverRequest
    {
        [Required(ErrorMessage = "Entre 2 et 30 lettres")]
        [MinLength(2)]
        [MaxLength(30)]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Entre 2 et 30 lettres")]
        [MinLength(2)]
        [MaxLength(30)]
        public string? LastName { get; set; }

        //[MinimumAge(16)]
        [Required(ErrorMessage = "Vous devez avoir plus de 16 ans pour vous créer un compte")]
        [DataType(DataType.Date)]
        public DateOnly Birthday { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe doit faire entre 8 et 15 caractères et doit contenir au moins 1 majuscule et 1 chiffre")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        [MaxLength(15)]
        public string? Password { get; set; }
    }
}