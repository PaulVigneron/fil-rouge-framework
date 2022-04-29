using System.Net.Mime;
namespace App.Models
{
    public class Vehicule
    {
        public int Id { get; set; }
        public List<VehiculeCat>? Categories { get; set; }
        public int DateBuild { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Power { get; set; }
        public string? Image { get; set; }
    }
}