namespace App.Models
{
    public class VehiculeCat
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Vehicule>? Vehicules { get; set; }
    }
}