using App.Models;

namespace App.ViewModels
{
    public class VehiculesListViewModel
    {
        public IEnumerable<Vehicule> VehiculeList { get; }
        public string HeaderTitle { get; set; }

        public VehiculesListViewModel(IEnumerable<Vehicule> vehicules, string headerTitle)
        {
            VehiculeList = vehicules;
            HeaderTitle = headerTitle;
        }
    }
}