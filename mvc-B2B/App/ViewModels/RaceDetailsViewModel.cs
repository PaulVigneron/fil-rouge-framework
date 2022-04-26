using App.Models;

namespace App.ViewModels
{
    public class RaceDetailsViewModel
    {
        public Race Course { get; }
        public RaceDetailsViewModel(Race race)
        {
            Course = race;
        }
    }
}