using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App.Controllers
{
    public class DriversController : Controller
    {
        private readonly AppDbContext _dbContext;

        public DriversController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ActionResult Create()
        {

            return View("CreateDriver");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateDriverRequest driver)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    
                    // TODO: Add insert logic here
                    Drivers newDriver = new()
                    {
                        FirstName = driver.FirstName,
                        LastName = driver.LastName,
                        BirthdayDate = driver.Birthday,
                        Email = driver.Email,
                        Password = driver.Password
                    };

                    _dbContext.Drivers.Add(newDriver);
                    _dbContext.SaveChanges();

                    return RedirectToAction(nameof(Create));
                }

                return View("CreateDriver");
            }
            catch
            {
                return View("CreateDriver");
            }
        }

        public ActionResult Login()
        {

            return View("Login");
        }

        public ActionResult Profil()
        {

            return View("Profil");
        }
    }
}