using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RacesController : Controller
    {
        private readonly IRepository<Race> _raceRepository;
        public RacesController(IRepository<Race> raceRepository)
        {
            _raceRepository = raceRepository;
        }

        // GET: Races
        public ActionResult Index()
        {
            var races = _raceRepository.GetAll();

            var raceListViewModel = new RaceListViewModel(
                races,
                "Liste de courses"
            );

            return View("RaceList", raceListViewModel);
        }

        // GET: Races/Details/5
        public ActionResult Details(int id)
        {
            try {
                var race = _raceRepository.GetById(id);
                var raceDetailsViewModel = new RaceDetailsViewModel(
                    race
                );
                return View("DetailsRace", raceDetailsViewModel);
            } catch (InvalidOperationException e) {
                Console.WriteLine(e);
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Races/Create
        public ActionResult Create()
        {
            return View("CreateRace");
        }

        // POST: Races/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRaceRequest race)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Race newRace = new()
                    {
                        Name = race.RaceName,
                        EventDate = race.RaceDate,
                        MaxParticipants = race.RaceMaxParticipants,
                    };

                    _raceRepository.Add(newRace);
                    _raceRepository.Commit();

                    return RedirectToAction(nameof(Index));
                }
                return View("CreateRace");
            }
            catch
            {
                return View("CreateRace");
            }
        }

        // GET: Races/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            try {
                var race = _raceRepository.GetById(id);
                EditRaceRequest EditViewModel = new ()
                {
                    RaceName = race.Name,
                    RaceDate = race.EventDate,
                    RaceMaxParticipants = race.MaxParticipants,
                };
                return View("EditRace", EditViewModel);
            } catch (InvalidOperationException e) {
                Console.WriteLine(e);
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Races/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditRaceRequest race, int id)
        {
            try
            {
                var oldRace = _raceRepository.GetById(id);
                if (ModelState.IsValid) {
                    Race newRace = new()
                    {
                        Id = id,
                        Name = race.RaceName,
                        EventDate = race.RaceDate,
                        MaxParticipants = race.RaceMaxParticipants,
                    };
                    _raceRepository.Delete(oldRace);
                    _raceRepository.Add(newRace);
                    _raceRepository.Commit();
                } else {
                    return View("RaceList");
                }
            } catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Races/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                var race = _raceRepository.GetById(id);
                _raceRepository.Delete(race);
                _raceRepository.Commit();
            }
            catch
            {
            }
            return RedirectToAction(nameof(Index));
        }
    }
}