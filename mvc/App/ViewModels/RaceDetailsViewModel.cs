using App.Models;

namespace App.ViewModels
{
    public class RaceDetailsViewModel
    {
        public Race Course { get; }
        public string HeaderTitle { get; }
        public RaceDetailsViewModel(Race race, string headerTitle)
        {
            Course = race;
            HeaderTitle = headerTitle;
        }
    }
}