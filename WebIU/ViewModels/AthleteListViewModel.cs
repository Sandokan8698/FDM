using System.Collections.Generic;
using Domain.Entities;

namespace WebIU.ViewModels
{
    public class AthleteListViewModel
    {
        public IEnumerable<Athlete> Athletes { get; set; }

        public string CurrentSport { get; set; }
    }
}