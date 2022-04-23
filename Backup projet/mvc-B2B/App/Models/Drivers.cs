namespace App.Models
{
    public class Drivers
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly BirthdayDate { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<Vehicule>? Vehicules { get; set; }
    }
}