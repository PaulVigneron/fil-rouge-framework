using System.ComponentModel.DataAnnotations;
using App.Models;

namespace App.ViewModels
{
    public class RaceEditViewModel
    {
        public Race Course { get; set; }
        public RaceEditViewModel(Race race){
            Course = race;
        }
    }
}