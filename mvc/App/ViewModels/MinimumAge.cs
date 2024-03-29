using System.ComponentModel.DataAnnotations;
namespace App.ViewModels
{
    public class MinimumAge : ValidationAttribute
    {
        int _minimumAge;

    public MinimumAge(int minimumAge)
    {
      _minimumAge = minimumAge;
    }

    public override bool IsValid(object value)
    {
        DateTime date;
        if (DateTime.TryParse(value.ToString(),out date))
        {
            return date.AddYears(_minimumAge) < DateTime.Now;
        }

        return false;
    }
    }
}