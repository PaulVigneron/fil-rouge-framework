using App.Data;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class VehiculesController : Controller
    {
        private readonly AppDbContext _dbContext;

        public VehiculesController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var vehicules = _dbContext.Vehicules.ToList();

            var vehiculeListViewModel = new VehiculesListViewModel(
                vehicules,
                "Liste des véhicules"
            );

            return View("VehiculesList", vehiculeListViewModel);
        }

        public ActionResult ListVehicules()
        {
            return View("VehiculesList");
        }
    }
}